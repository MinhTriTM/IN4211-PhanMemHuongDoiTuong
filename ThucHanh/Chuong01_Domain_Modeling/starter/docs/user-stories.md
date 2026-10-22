# User Stories — Hệ sinh thái EduHub

Tài liệu đặc tả các câu chuyện người dùng (User Stories) của hệ thống Quản lý Câu lạc bộ và Sự kiện Sinh viên EduHub, phục vụ đầy đủ 3 nhóm tác nhân (Actors) theo mô hình Agile và tiêu chí nghiệm thu Given – When – Then.

---

## 👥 Nhóm vai trò 1: Sinh viên (Member)

### US-01 · Sinh viên: Hủy đăng ký sự kiện trước giờ G
**User Story**: Là một **Sinh viên**, tôi muốn **hủy phiếu đăng ký tham dự sự kiện trước giờ bắt đầu ít nhất 24 giờ**, để **nhường cơ hội và chỗ trống cho các bạn sinh viên khác trong danh sách chờ khi tôi có lịch học đột xuất**.

**Tiêu chí nghiệm thu (Acceptance Criteria)**:
- **Kịch bản 1 (Hủy hợp lệ trước 24h)**:
  - **Given**: Sinh viên đã có phiếu đăng ký (`Registration`) ở trạng thái `Pending` hoặc `Confirmed`, và thời điểm hiện tại cách giờ diễn ra sự kiện lớn hơn 24 giờ.
  - **When**: Sinh viên nhấn nút "Hủy đăng ký" trên giao diện sự kiện.
  - **Then**: Phiếu chuyển sang trạng thái `Cancelled`, số lượng chỗ khả dụng (`Capacity`) của sự kiện được hoàn trả (+1), và hệ thống gửi thông báo hủy thành công.
- **Kịch bản 2 (Chặn hủy muộn sát giờ diễn ra)**:
  - **Given**: Sự kiện chỉ còn ít hơn 24 giờ trước thời điểm bắt đầu.
  - **When**: Sinh viên cố gắng yêu cầu hủy phiếu đăng ký.
  - **Then**: Hệ thống từ chối yêu cầu, giữ nguyên trạng thái `Confirmed` của phiếu và hiển thị thông báo "Đã quá thời hạn hủy tự động theo quy chế".

---

### US-02 · Sinh viên: Xem lịch sử tham gia và tỷ lệ điểm danh
**User Story**: Là một **Sinh viên**, tôi muốn **xem lại danh sách các sự kiện mình đã đăng ký và kết quả check-in thực tế**, để **theo dõi điểm rèn luyện và mức độ tích cực tham gia phong trào của bản thân**.

**Tiêu chí nghiệm thu (Acceptance Criteria)**:
- **Kịch bản 1 (Xem lịch sử có đủ dữ liệu check-in)**:
  - **Given**: Sinh viên đã đăng nhập và đã tham dự ít nhất 1 sự kiện có ghi nhận `CheckIn`.
  - **When**: Sinh viên truy cập trang cá nhân mục "Lịch sử sự kiện".
  - **Then**: Hệ thống liệt kê chi tiết tên sự kiện, ngày tổ chức, trạng thái phiếu (`Confirmed`) và thời điểm check-in cụ thể (`CheckedInAt`).
- **Kịch bản 2 (Chưa tham gia sự kiện nào)**:
  - **Given**: Sinh viên mới tạo tài khoản và chưa đăng ký bất kỳ sự kiện nào.
  - **When**: Sinh viên vào mục "Lịch sử sự kiện".
  - **Then**: Hệ thống hiển thị trạng thái trống kèm lời mời: "Bạn chưa đăng ký sự kiện nào, hãy khám phá các sự kiện mới!".

---

## 🏛️ Nhóm vai trò 2: Ban chủ nhiệm CLB (Club Board)

### US-03 · Ban CLB: Tạo sự kiện mới và giới hạn sức chứa
**User Story**: Là một **Trưởng ban CLB**, tôi muốn **tạo sự kiện mới có ấn định thời gian, địa điểm và sức chứa tối đa**, để **đảm bảo chất lượng tổ chức workshop không bị quá tải phòng máy**.

**Tiêu chí nghiệm thu (Acceptance Criteria)**:
- **Kịch bản 1 (Tạo sự kiện hợp lệ)**:
  - **Given**: Trưởng ban CLB có quyền quản trị CLB, nhập tiêu đề "Workshop AI", ngày diễn ra trong tương lai và sức chứa `Capacity = 50`.
  - **When**: Nhấn nút "Tạo sự kiện".
  - **Then**: Thực thể `Event` được khởi tạo thành công với `ClubId` tương ứng, và sự kiện hiển thị trên bảng tin trường.
- **Kịch bản 2 (Chặn sự kiện có thông tin không hợp lệ)**:
  - **Given**: Trưởng ban nhập tiêu đề rỗng hoặc sức chứa `Capacity <= 0`.
  - **When**: Nhấn nút "Tạo sự kiện".
  - **Then**: Hệ thống ném ngoại lệ `ArgumentException`, từ chối tạo và đánh dấu vi phạm dữ liệu.

---

### US-04 · Ban CLB: Điểm danh thành viên bằng mã QR
**User Story**: Là một **Cán bộ tổ chức sự kiện**, tôi muốn **quét mã QR trên phiếu đăng ký của sinh viên tại bàn check-in**, để **ghi nhận điểm danh tức thì và chống gian lận người lạ vào sự kiện**.

**Tiêu chí nghiệm thu (Acceptance Criteria)**:
- **Kịch bản 1 (Check-in QR thành công cho phiếu Confirmed)**:
  - **Given**: Sinh viên đưa mã QR tương ứng với phiếu `Registration` đang ở trạng thái `Confirmed`.
  - **When**: Cán bộ ban tổ chức quét mã qua camera.
  - **Then**: Hệ thống tạo bản ghi `CheckIn` với `Method = "QrCode"`, lưu thời điểm `CheckedInAt` (UTC) và hiển thị thông báo "Điểm danh thành công".
- **Kịch bản 2 (Chặn check-in phiếu chưa xác nhận hoặc đã hủy)**:
  - **Given**: Phiếu đăng ký của sinh viên đang ở trạng thái `Pending` hoặc `Cancelled`.
  - **When**: Cán bộ quét mã QR của phiếu này.
  - **Then**: Hệ thống từ chối và báo lỗi: "Chỉ phiếu đã Confirmed mới được check-in".

---

## 🛡️ Nhóm vai trò 3: Quản trị viên hệ thống (Admin)

### US-05 · Quản trị viên: Phê duyệt thành lập CLB mới
**User Story**: Là một **Quản trị viên Đoàn trường**, tôi muốn **xem xét và phê duyệt đề xuất thành lập CLB sinh viên mới**, để **đảm bảo CLB hoạt động đúng tôn chỉ học thuật và nội quy nhà trường**.

**Tiêu chí nghiệm thu (Acceptance Criteria)**:
- **Kịch bản 1 (Phê duyệt đề xuất CLB đầy đủ thông tin)**:
  - **Given**: Đơn thành lập CLB có tên hợp lệ không rỗng, mô tả chi tiết mục tiêu hoạt động và danh sách sinh viên sáng lập.
  - **When**: Admin nhấn "Phê duyệt".
  - **Then**: Thực thể `Club` chính thức được tạo trong hệ thống, chuyển sang trạng thái hoạt động và gửi thông báo thành lập tới sinh viên chủ nhiệm.
- **Kịch bản 2 (Từ chối CLB vi phạm tên)**:
  - **Given**: Đơn thành lập CLB có tên bị bỏ trống hoặc vượt quá 100 ký tự.
  - **When**: Hệ thống kiểm tra dữ liệu đầu vào.
  - **Then**: Hệ thống từ chối khởi tạo với thông báo lỗi `ArgumentException: Tên CLB không hợp lệ`.

---

### US-06 · Quản trị viên: Khóa hoặc giải thể CLB vi phạm
**User Story**: Là một **Quản trị viên**, tôi muốn **ngừng kích hoạt (Deactivate) một thành viên hoặc CLB vi phạm quy chế**, để **bảo vệ môi trường sinh hoạt lành mạnh cho toàn thể sinh viên**.

**Tiêu chí nghiệm thu (Acceptance Criteria)**:
- **Kịch bản 1 (Chuyển trạng thái Inactive thành công)**:
  - **Given**: Thành viên `Member` đang có trạng thái `Active`.
  - **When**: Admin thực hiện lệnh kỷ luật `Deactivate()`.
  - **Then**: Trạng thái thành viên chuyển thành `Inactive`, và sinh viên không thể tiếp tục đăng ký tham dự các sự kiện mới.
