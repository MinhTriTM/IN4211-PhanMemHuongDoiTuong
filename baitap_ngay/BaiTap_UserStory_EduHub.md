# BÀI TẬP: THIẾT KẾ USER STORY CHO HỆ THỐNG EDUHUB

- **Học phần**: Phát triển phần mềm hướng đối tượng (IN4211)
- **Bài toán**: Hệ sinh thái Quản lý Câu lạc bộ & Sự kiện Sinh viên (**EduHub**)
- **Yêu cầu đề bài**: Tự viết ít nhất 5 User Story, bao quát đủ 3 vai trò (Sinh viên, Ban CLB, Admin), tuyệt đối không chép lại story mẫu trong slide.
- **Quy chuẩn định dạng**:
  - Cấu trúc: *“Là [vai trò], tôi muốn [việc cần làm], để [lợi ích].”*
  - Tiêu chí nghiệm thu (Acceptance Criteria): Mô hình **Given** (cho trước) – **When** (khi) – **Then** (thì).

---

## 👥 Bảng phân bổ 3 vai trò (Actors)

| Mã Story | Vai trò (Actor) | Hành vi nghiệp vụ mới (Không trùng mẫu) | Lợi ích nghiệp vụ |
| :--- | :--- | :--- | :--- |
| **US-M01** | 🎓 Sinh viên (*Member*) | Hủy đăng ký sự kiện trước hạn chót | Giải phóng chỗ cho bạn khác khi có lịch bận đột xuất |
| **US-M02** | 🎓 Sinh viên (*Member*) | Đánh giá sao & gửi nhận xét sau sự kiện | Góp ý xây dựng giúp nâng cao chất lượng các sự kiện sau |
| **US-C01** | 🧑‍💼 Ban CLB (*Club Leader*) | Phê duyệt hoặc từ chối đơn xin gia nhập CLB | Tuyển chọn thành viên đáp ứng tiêu chí và kỹ năng của CLB |
| **US-C02** | 🧑‍💼 Ban CLB (*Club Leader*) | Dời lịch / đổi địa điểm tổ chức sự kiện | Chủ động thích ứng khi có sự cố phòng ốc và báo kịp thời |
| **US-A01** | 🛠️ Admin (*Quản trị viên*) | Phê duyệt cấp phép thành lập Câu lạc bộ mới | Quản lý tính pháp lý và quy chuẩn các CLB trong nhà trường |
| **US-A02** | 🛠️ Admin (*Quản trị viên*) | Tạm đình chỉ quyền tạo sự kiện của CLB vi phạm | Giữ vững kỷ luật, an toàn thông tin và nội quy học đường |

---

## 📝 Chi tiết các User Story & Tiêu chí nghiệm thu (Acceptance Criteria)

### 🎓 VAI TRÒ 1: SINH VIÊN (MEMBER)

#### 🔹 US-M01: Hủy đăng ký sự kiện trước hạn chót
> **User Story:**  
> Là một **Sinh viên**, tôi muốn **hủy phiếu đăng ký của một sự kiện mà tôi đã đăng ký trước đó (trước khi sự kiện diễn ra ít nhất 24 giờ)**, để **nhường chỗ cho các sinh viên khác trong danh sách chờ khi tôi có lịch học/lịch thi đột xuất**.

**Tiêu chí nghiệm thu (Acceptance Criteria):**
- **Kịch bản 1 — Hủy hợp lệ trước thời hạn:**
  - **Given**: Sinh viên đã có phiếu đăng ký `Registration` ở trạng thái `Confirmed` hoặc `Pending`, và thời điểm hiện tại cách thời gian bắt đầu sự kiện lớn hơn 24 giờ.
  - **When**: Sinh viên chọn "Hủy đăng ký" trên giao diện sự kiện.
  - **Then**: Trạng thái của phiếu chuyển thành `Cancelled`, số chỗ trống khả dụng (`AvailableSeats`) của sự kiện tăng thêm 1, và hệ thống gửi thông báo xác nhận hủy thành công.
- **Kịch bản 2 — Hủy quá thời hạn quy định:**
  - **Given**: Sự kiện chỉ còn dưới 24 giờ trước khi diễn ra hoặc sự kiện đã bắt đầu.
  - **When**: Sinh viên bấm nút "Hủy đăng ký".
  - **Then**: Hệ thống từ chối thao tác, giữ nguyên trạng thái phiếu đăng ký và hiển thị cảnh báo: *"Đã quá hạn hủy đăng ký trực tuyến (quy định trước 24h). Vui lòng liên hệ Ban tổ chức nếu vắng mặt."*

---

#### 🔹 US-M02: Đánh giá và gửi nhận xét sau sự kiện
> **User Story:**  
> Là một **Sinh viên**, tôi muốn **chấm điểm sao (1 - 5 sao) và gửi lời nhận xét về nội dung sau khi đã tham gia sự kiện**, để **bày tỏ cảm nhận và giúp Ban CLB cải thiện chất lượng các chương trình trong tương lai**.

**Tiêu chí nghiệm thu (Acceptance Criteria):**
- **Kịch bản 1 — Gửi đánh giá sau khi đã điểm danh:**
  - **Given**: Sinh viên đã có bản ghi `CheckIn` hợp lệ tại sự kiện và chưa từng gửi phản hồi cho sự kiện này.
  - **When**: Sinh viên gửi biểu mẫu đánh giá với mức điểm từ 1 đến 5 sao kèm nội dung nhận xét.
  - **Then**: Hệ thống lưu bản ghi `EventFeedback` mới liên kết với sinh viên và sự kiện, đồng thời tự động cập nhật lại điểm trung bình (`AverageRating`) của sự kiện.
- **Kịch bản 2 — Chưa tham gia sự kiện nhưng cố tình gửi đánh giá:**
  - **Given**: Sinh viên chưa có bản ghi `CheckIn` tại sự kiện (vắng mặt hoặc không đăng ký).
  - **When**: Sinh viên truy cập vào liên kết đánh giá sự kiện.
  - **Then**: Hệ thống khóa chức năng đánh giá và thông báo: *"Chỉ những thành viên đã tham dự và điểm danh thành công mới có quyền đánh giá sự kiện này."*

---

### 🧑‍💼 VAI TRÒ 2: BAN CHỦ NHIỆM CLB (CLUB LEADER)

#### 🔹 US-C01: Phê duyệt đơn xin gia nhập Câu lạc bộ
> **User Story:**  
> Là **Ban chủ nhiệm CLB**, tôi muốn **xem xét và duyệt hoặc từ chối các đơn xin gia nhập CLB của sinh viên**, để **đảm bảo số lượng và chất lượng thành viên phù hợp với định hướng hoạt động của câu lạc bộ**.

**Tiêu chí nghiệm thu (Acceptance Criteria):**
- **Kịch bản 1 — Chấp thuận đơn gia nhập:**
  - **Given**: Sinh viên gửi đơn đăng ký gia nhập và đơn đang ở trạng thái `PendingApproval`.
  - **When**: Ban chủ nhiệm chọn "Duyệt thành viên".
  - **Then**: Trạng thái đơn chuyển sang `Approved`, sinh viên được chính thức thêm vào danh sách thành viên hoạt động (`Club.ActiveMembers`), và hệ thống gửi thư chào mừng gia nhập CLB.
- **Kịch bản 2 — Từ chối đơn gia nhập kèm lý do:**
  - **Given**: Đơn gia nhập đang ở trạng thái `PendingApproval`.
  - **When**: Ban chủ nhiệm chọn "Từ chối" và nhập lý do (ví dụ: *Đã đủ chỉ tiêu thành viên kỳ này*).
  - **Then**: Trạng thái đơn chuyển sang `Rejected`, lý do từ chối được lưu trữ và hệ thống gửi thông báo phản hồi lịch sự đến sinh viên.

---

#### 🔹 US-C02: Cập nhật dời lịch hoặc thay đổi địa điểm sự kiện
> **User Story:**  
> Là **Ban chủ nhiệm CLB**, tôi muốn **cập nhật lại ngày giờ tổ chức hoặc phòng hội trường của sự kiện**, để **kịp thời điều chỉnh khi nhà trường có thông báo trùng lịch phòng ốc và thông tin ngay đến người tham gia**.

**Tiêu chí nghiệm thu (Acceptance Criteria):**
- **Kịch bản 1 — Dời lịch thành công và phát thông báo:**
  - **Given**: Sự kiện đang ở trạng thái chuẩn bị diễn ra (`Scheduled`), thời gian mới được chọn hợp lệ trong tương lai.
  - **When**: Ban chủ nhiệm cập nhật thời gian/địa điểm mới và nhập lý do thay đổi.
  - **Then**: Thuộc tính ngày giờ/địa điểm của `Event` được cập nhật, trạng thái ghi nhận cờ `IsRescheduled = true`, và hệ thống tự động gửi thông báo khẩn tới toàn bộ sinh viên đã đăng ký sự kiện đó.
- **Kịch bản 2 — Cập nhật thời gian không hợp lệ:**
  - **Given**: Ban chủ nhiệm nhập thời gian tổ chức mới là thời điểm trong quá khứ hoặc thời gian kết thúc trước thời gian bắt đầu.
  - **When**: Bấm "Lưu thay đổi".
  - **Then**: Hệ thống báo lỗi validation, chặn cập nhật và giữ nguyên lịch trình ban đầu.

---

### 🛠️ VAI TRÒ 3: QUẢN TRỊ VIÊN HỆ THỐNG (ADMIN)

#### 🔹 US-A01: Phê duyệt đề xuất thành lập Câu lạc bộ mới
> **User Story:**  
> Là một **Admin**, tôi muốn **thẩm định hồ sơ và phê duyệt quyết định thành lập Câu lạc bộ mới do nhóm sinh viên nộp lên**, để **chính thức công nhận tổ chức và cấp tài nguyên số trên hệ thống EduHub**.

**Tiêu chí nghiệm thu (Acceptance Criteria):**
- **Kịch bản 1 — Hồ sơ hợp lệ được phê duyệt:**
  - **Given**: Hồ sơ thành lập CLB mới có đầy đủ tên CLB không trùng lặp, tôn chỉ mục đích, mã giảng viên cố vấn và danh sách ban sáng lập tối thiểu 5 sinh viên.
  - **When**: Admin phê duyệt hồ sơ.
  - **Then**: Một thực thể `Club` mới được khởi tạo với trạng thái `Active`, trưởng nhóm đề xuất được tự động cấp quyền `ClubLeader`, và CLB bắt đầu xuất hiện công khai trên bảng tin chung.
- **Kịch bản 2 — Hồ sơ bị từ chối do trùng lặp hoặc thiếu thông tin:**
  - **Given**: Tên CLB đề xuất đã tồn tại trên hệ thống hoặc thiếu xác nhận của giảng viên cố vấn.
  - **When**: Admin chọn "Yêu cầu chỉnh sửa / Từ chối".
  - **Then**: Trạng thái hồ sơ chuyển sang `NeedsRevision`, kèm theo các ghi chú hướng dẫn của Admin gửi về tài khoản đại diện nộp đơn.

---

#### 🔹 US-A02: Tạm đình chỉ quyền tạo sự kiện của CLB vi phạm nội quy
> **User Story:**  
> Là một **Admin**, tôi muốn **khóa quyền tạo sự kiện mới của một Câu lạc bộ vi phạm nội quy học đường hoặc tài chính**, để **đảm bảo kỷ cương sinh viên và bảo vệ an toàn cho nhà trường**.

**Tiêu chí nghiệm thu (Acceptance Criteria):**
- **Kịch bản 1 — Khóa quyền tổ chức sự kiện:**
  - **Given**: Câu lạc bộ đang ở trạng thái hoạt động bình thường (`CanCreateEvent = true`).
  - **When**: Admin kích hoạt tính năng "Tạm ngưng quyền sự kiện", chọn thời hạn đình chỉ và nhập biên bản vi phạm.
  - **Then**: Cờ `Club.CanCreateEvent` chuyển thành `false`, Ban chủ nhiệm của CLB đó bị ẩn nút tạo sự kiện mới, nhưng các thành viên hiện tại vẫn có thể sinh hoạt nội bộ bình thường.
- **Kịch bản 2 — Mở lại quyền khi hết thời hạn phạt:**
  - **Given**: CLB đang trong thời gian bị đình chỉ quyền tạo sự kiện.
  - **When**: Hết thời hạn quy định hoặc Admin chủ động nhấn "Gỡ bỏ hình phạt".
  - **Then**: Cờ `Club.CanCreateEvent` được khôi phục thành `true`, gửi thông báo nhắc nhở đến ban chủ nhiệm CLB.

---

## 🔍 Liên hệ Domain Model (Mở rộng từ User Story sang Class OOP)

Từ 6 User Story thực tế trên, hệ thống EduHub có thể mở rộng thêm các Entity và thuộc tính trong tư duy thiết kế hướng đối tượng:

1. **`EventFeedback`** (Thực thể mới sinh ra từ US-M02):
   - Thuộc tính: `Id`, `EventId`, `MemberId`, `Rating` (1..5), `Comment`, `CreatedAt`.
2. **`MembershipApplication`** (Thực thể mới sinh ra từ US-C01 & US-A01):
   - Thuộc tính: `Id`, `ClubId`, `ApplicantId`, `Status` (Pending / Approved / Rejected), `Reason`.
3. **`Club`** (Mở rộng thuộc tính từ US-A01 & US-A02):
   - Thuộc tính: `AdvisorId`, `CanCreateEvent` (bool), `Status` (Active / Suspended).
4. **`Event`** (Mở rộng thuộc tính từ US-M01 & US-C02):
   - Thuộc tính: `CancellationDeadlineHours`, `IsRescheduled` (bool), `AverageRating` (float).
