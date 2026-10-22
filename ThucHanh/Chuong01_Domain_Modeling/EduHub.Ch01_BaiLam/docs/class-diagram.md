# Sơ đồ lớp Domain Model

```mermaid
classDiagram
    class Member {
        +Guid Id
        +string FullName
        +string StudentCode
        +string Email
        +bool IsActive
        +Create(...) Member$
        +Deactivate() void
        +Activate() void
    }
    class Club {
        +Guid Id
        +string Name
        +string Description
        +bool CanCreateEvent
        +IReadOnlyList~Member~ Members
        +Create(...) Club$
        +AddMember(Member) void
        +SetCanCreateEvent(bool) void
    }
    class Event {
        +Guid Id
        +Guid ClubId FK
        +string Title
        +DateTime StartTime
        +int Capacity
        +bool IsRescheduled
        +Create(...) Event$
        +Reschedule(DateTime) void
    }
    class Registration {
        +Guid Id
        +Guid EventId FK
        +Guid MemberId FK
        +DateTime RegisteredAt
        +RegistrationStatus Status
        +Create(...) Registration$
        +Confirm() void
        +Cancel(DateTime, DateTime) void
    }
    class CheckIn {
        +Guid Id
        +Guid RegistrationId FK
        +DateTime CheckedInAt
        +string DeviceInfo
        +Create(Registration, string) CheckIn$
    }

    Club "1" --> "0..*" Event : tổ chức, Event.ClubId
    Member "1" --> "0..*" Registration : đăng ký, Registration.MemberId
    Event "1" --> "0..*" Registration : nhận phiếu, Registration.EventId
    Registration "1" --> "0..1" CheckIn : điểm danh, CheckIn.RegistrationId
    Club "0..*" -- "0..*" Member : membership in-memory
```

`Id` là khóa chính của mỗi entity. Các khóa ngoại hiện diện trong source C# và Python là `Event.ClubId`, `Registration.EventId`, `Registration.MemberId` và `CheckIn.RegistrationId`. Quan hệ nhiều-nhiều Club-Member hiện được giữ trong danh sách nội bộ `Club.Members`; bảng nối chỉ là hướng triển khai khi có cơ sở dữ liệu ở chương sau.
