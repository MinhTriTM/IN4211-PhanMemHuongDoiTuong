# Sơ đồ lớp miền — Hệ sinh thái EduHub (Ch01)

Sơ đồ lớp chi tiết của 5 thực thể Rich Domain Model trong hệ thống EduHub, thể hiện thuộc tính, kiểu dữ liệu, phương thức nghiệp vụ, khóa ngoại và các mối quan hệ (1:1, 1:N, M:N).

```mermaid
classDiagram
    direction TB

    class MemberStatus {
        <<enumeration>>
        Active
        Inactive
    }

    class RegistrationStatus {
        <<constants>>
        +string Pending = "Pending"
        +string Confirmed = "Confirmed"
        +string Cancelled = "Cancelled"
    }

    class CheckInMethod {
        <<constants>>
        +string Manual = "Manual"
        +string QrCode = "QrCode"
    }

    class Club {
        -List~Member~ _members
        +Guid Id
        +string Name
        +string Description
        +DateTime CreatedAt
        +IReadOnlyList~Member~ Members
        +Create(string name, string description)$ Club
        +AddMember(Member member) void
        +MemberCount() int
    }

    class Member {
        +Guid Id
        +string Name
        +string Email
        +string StudentCode
        +DateTime JoinedAt
        +MemberStatus Status
        +Create(string name, string email, string studentCode)$ Member
        +IsActive() bool
        +Deactivate() void
        +ToString() string
    }

    class Event {
        +Guid Id
        +Guid ClubId
        +string Title
        +DateTime Date
        +int Capacity
        +Create(Guid clubId, string title, DateTime date, int capacity)$ Event
        +HasCapacity(int currentRegistrationsCount) bool
    }

    class Registration {
        +Guid Id
        +Guid MemberId
        +Guid EventId
        +DateTime RegisteredAt
        +string Status
        +Create(Guid memberId, Guid eventId)$ Registration
        +Confirm() void
        +Cancel() void
    }

    class CheckIn {
        +Guid Id
        +Guid RegistrationId
        +DateTime CheckedInAt
        +string Method
        +Create(Registration registration, string method)$ CheckIn
        +Summary() string
    }

    %% Quan hệ
    Club "1" o-- "0..*" Member : quản lý danh sách thành viên
    Club "1" *-- "0..*" Event : tổ chức các sự kiện
    Member "1" <-- "0..*" Registration : sinh viên đăng ký (MemberId)
    Event "1" <-- "0..*" Registration : sự kiện tiếp nhận (EventId)
    Registration "1" <.. "0..1" CheckIn : ghi nhận điểm danh (RegistrationId)
    Member ..> MemberStatus : sử dụng
    Registration ..> RegistrationStatus : kiểm soát trạng thái
    CheckIn ..> CheckInMethod : phương thức quét mã
```

---

## 🔒 Quy tắc bất biến (Invariants) được mã hóa trong mô hình:
1. **Tính đóng gói (Encapsulation)**:
   - Các trường dữ liệu đều có `private set;`, không có setter công khai tùy tiện.
   - Hàm dựng `constructor` đều đặt ở phạm vi `private`, bắt buộc mọi luồng khởi tạo phải đi qua phương thức tĩnh `Create(...)`.
2. **Quy tắc thực thể CLB**:
   - `Club.AddMember()` kiểm tra không cho phép thêm cùng một sinh viên hai lần vào CLB (`InvalidOperationException`).
   - `Club.Members` trả về `IReadOnlyList<Member>` để ngăn chặn thao tác thêm/sửa/xóa trực tiếp từ bên ngoài.
3. **Quy tắc đăng ký & Điểm danh**:
   - `Registration.Status`: Chuyển từ `Pending` sang `Confirmed` hoặc `Cancelled`. Khi đã `Cancelled` thì không bao giờ được phép `Confirm()` lại.
   - `CheckIn.Create()`: Bắt buộc phiếu `Registration` phải có trạng thái `Confirmed` mới được phép điểm danh.
