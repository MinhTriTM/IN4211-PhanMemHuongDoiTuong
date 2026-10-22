# Phân tích SOLID cho `ClubManager`

`ClubManager.cs` được giữ nguyên như baseline God class để đối chiếu. Demo chính trong `Program.cs` chỉ khởi tạo các thành phần sau refactor, không gọi lớp baseline.

## Các vi phạm có bằng chứng trong baseline

| # | Vị trí trong `ClubManager.cs` | Nguyên lý | Bằng chứng và hậu quả | Refactor áp dụng |
| --- | --- | --- | --- | --- |
| 1 | Lớp và các phương thức `CreateClub`, `AddMemberToClub`, `CreateEvent`, `PrintClubReport` | SRP | Một lớp cùng lúc kiểm tra dữ liệu, giữ danh sách, ghi tệp, gửi thông báo và dựng báo cáo. Mỗi thay đổi ở các trách nhiệm này đều có thể buộc sửa cùng một lớp. | `ClubService`, `EventService`, `ReportService`, repository, logger và notifier tách trách nhiệm. |
| 2 | `CreateClub`: chuỗi `if`/`else if` theo tên miền email | OCP | Thêm kênh SMS hoặc Slack đòi hỏi sửa nhánh điều kiện đang tồn tại. | `INotificationServiceFactory` tạo `INotificationService` theo `NotificationChannel`; các lớp Email/SMS/Slack thực hiện hợp đồng. |
| 3 | `PrintClubReport`: in Console cố định | OCP | Thêm định dạng CSV sẽ phải sửa phương thức báo cáo cũ. | `ReportService.Generate(IReportStrategy)` nhận `ConsoleReportStrategy` hoặc `CsvReportStrategy`. |
| 4 | Các lời gọi `File.AppendAllText` trong `CreateClub`, `AddMemberToClub`, `CreateEvent`, `PrintClubReport` | DIP | Nghiệp vụ cấp cao phụ thuộc trực tiếp vào API tệp; Unit Test có thể làm phát sinh I/O thật. | `IAppLogger` được constructor-inject vào services và decorator. |
| 5 | Các lời gọi `Console.WriteLine` để gửi thông báo trong `CreateClub`, `AddMemberToClub`, `CreateEvent` | DIP | Nghiệp vụ cấp cao biết chi tiết đầu ra và kênh gửi, nên khó thay thế bằng fake trong kiểm thử. | `INotificationService` được inject; các lớp kênh thông báo sở hữu chi tiết Console trong demo. |

Các mục 2 và 3 là hai điểm mở rộng độc lập của OCP; các mục 4 và 5 là hai phụ thuộc chi tiết độc lập của DIP. Vì vậy bảng có ít nhất bốn vi phạm có thể chỉ ra từ code gốc.

## Ranh giới của nhận định LSP và ISP

Không kết luận `ClubManager` vi phạm LSP: baseline không có hierarchy kế thừa hay hợp đồng subtype để kiểm tra thay thế được hay không. Cũng không đủ bằng chứng để gọi việc chưa có repository interface là vi phạm ISP; ISP cần một interface lớn ép client phụ thuộc vào phương thức không dùng, trong khi baseline không định nghĩa interface nào.

Refactor **áp dụng** ISP bằng các hợp đồng hẹp `IClubRepository`, `IMemberRepository`, `IEventRepository`, `IAppLogger`, `INotificationService` và `IReportStrategy`. `LoggingClubRepository` thực hiện cùng `IClubRepository` và chuyển tiếp kết quả của repository bọc, nên đây là ví dụ cần được kiểm tra về tính thay thế khi phát triển tiếp, không phải bằng chứng hồi tố rằng baseline đã vi phạm LSP.

## Bốn design pattern trong bản refactor

| Pattern | Thành phần | Vai trò trong demo |
| --- | --- | --- |
| Factory | `NotificationServiceFactory` | Chọn implementation thông báo qua `NotificationChannel.Email`. |
| Decorator | `LoggingClubRepository` | Bọc `InMemoryClubRepository`, ghi log khi truy cập nhưng vẫn cung cấp `IClubRepository`. |
| Strategy | `IReportStrategy`, `ConsoleReportStrategy`, `CsvReportStrategy` | Dựng cùng số liệu theo Console và CSV; CSV escape dấu `"` bằng `""`. |
| Observer | `EventService`, `IEventObserver`, `LogNotifier`, `EmailNotifier` | Khi tạo sự kiện, service phát tới các observer đã đăng ký mà không phụ thuộc implementation cụ thể. |

## Phụ thuộc qua interface

`ClubService` nhận `IClubRepository`, `IMemberRepository`, `INotificationService`, `IAppLogger`; `EventService` nhận ba repository và làm việc với `IEventObserver`; `ReportService` nhận ba repository và `IReportStrategy`; `EmailNotifier` nhận `IMemberRepository` và `INotificationService`; `LoggingClubRepository` nhận `IClubRepository` và `IAppLogger`. Đây là nhiều hơn bốn lớp có dependency qua interface.

## Kiểm thử

`Ch02.Refactor.Tests/DomainTests.cs` có sáu test AAA trực tiếp cho `Club` và `Event`, gồm tên CLB hợp lệ/rỗng, sức chứa đạt ngưỡng, đăng ký lần đầu/lặp lại, và check-in khi chưa đăng ký. `PatternTests.cs` thêm một test AAA cho CSV có dấu phẩy và dấu nháy kép. Test baseline `ClubManager` còn lại xác nhận hành vi từ chối tên rỗng.

Kết quả build, test và demo đã chạy được lưu nguyên văn tại [ket-qua-chay.txt](ket-qua-chay.txt).
