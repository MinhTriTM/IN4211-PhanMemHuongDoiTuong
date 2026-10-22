# User Story - EduHub Chương 1

Các story dưới đây được viết riêng cho bài làm này và không lặp lại các story mẫu trong slide. Mỗi story có ít nhất hai tiêu chí Given-When-Then.

## Sinh viên

### US-01 - Theo dõi kết quả xử lý phiếu đăng ký

Là một sinh viên, tôi muốn xem trạng thái Pending, Confirmed hoặc Cancelled của phiếu đăng ký, để biết mình có được phép chuẩn bị tham gia sự kiện hay không.

1. Given phiếu vừa được tạo, When sinh viên xem phiếu, Then trạng thái là `Pending`.
2. Given Club Leader đã xác nhận phiếu, When sinh viên xem lại, Then trạng thái là `Confirmed`.

### US-02 - Hủy đăng ký trước hạn

Là một sinh viên, tôi muốn hủy phiếu khi sự kiện còn ít nhất 24 giờ, để chỗ trống có thể được ban tổ chức sử dụng cho kế hoạch tiếp theo.

1. Given phiếu đang `Pending` hoặc `Confirmed` và sự kiện còn hơn 24 giờ, When sinh viên hủy, Then phiếu chuyển thành `Cancelled`.
2. Given sự kiện còn không quá 24 giờ, When sinh viên hủy, Then hệ thống từ chối bằng `InvalidOperationException` (C#) hoặc `RuntimeError` (Python).

## Ban chủ nhiệm CLB

### US-03 - Xác nhận danh sách đủ điều kiện

Là Club Leader, tôi muốn xác nhận các phiếu đang chờ, để chỉ các sinh viên hợp lệ mới có thể check-in tại cổng.

1. Given phiếu ở `Pending`, When Club Leader xác nhận, Then phiếu chuyển thành `Confirmed`.
2. Given phiếu đã `Confirmed` hoặc `Cancelled`, When Club Leader xác nhận lại, Then hệ thống từ chối vì vòng đời phiếu không hợp lệ.

### US-04 - Dời lịch sự kiện do trùng lịch phòng

Là Club Leader, tôi muốn dời sự kiện sang thời điểm tương lai, để bảo toàn thông tin đăng ký khi phòng tổ chức bị điều chuyển.

1. Given sự kiện chưa diễn ra, When Club Leader nhập thời điểm tương lai, Then `StartTime` được cập nhật và `IsRescheduled` là `true`.
2. Given Club Leader chọn thời điểm quá khứ, When lưu thay đổi, Then hệ thống ném `ArgumentException` (C#) hoặc `ValueError` (Python).

## Quản trị viên

### US-05 - Tạm dừng và khôi phục quyền tổ chức của CLB

Là Admin, tôi muốn tạm dừng hoặc khôi phục quyền tạo sự kiện của một CLB, để xử lý CLB vi phạm nội quy mà vẫn giữ lịch sử thành viên và đăng ký.

1. Given CLB đang được phép tổ chức, When Admin tạm dừng quyền, Then `CanCreateEvent` là `false`.
2. Given CLB đang bị tạm dừng, When Admin khôi phục quyền, Then `CanCreateEvent` là `true`.

### US-06 - Khôi phục thành viên sau khi xác minh

Là Admin, tôi muốn kích hoạt lại sinh viên đã bị tạm ngưng sau khi xác minh, để Club Leader có thể thêm sinh viên đó vào CLB.

1. Given thành viên bị ngưng, When Club Leader thêm vào CLB, Then thao tác bị từ chối.
2. Given Admin đã gọi `Activate`, When Club Leader thêm thành viên, Then thành viên xuất hiện trong `Club.Members` nếu không trùng lặp.

## Phạm vi hiện thực

Năm entity trung tâm đã hiện thực là `Member`, `Club`, `Event`, `Registration` và `CheckIn`. Demo có luồng đăng ký, xác nhận, check-in và báo cáo tham dự. Feedback sự kiện và đơn xin gia nhập CLB chỉ là đề xuất mở rộng ở các chương sau; chúng không phải tính năng đã có trong mã nguồn này.
