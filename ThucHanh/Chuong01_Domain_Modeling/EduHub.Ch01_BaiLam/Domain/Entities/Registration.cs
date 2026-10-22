namespace EduHub.Domain.Entities;

using EduHub.Domain.Enums;

/// <summary>
/// Đại diện cho một phiếu đăng ký tham dự sự kiện của sinh viên.
/// </summary>
public class Registration
{
    public Guid Id { get; private set; }
    public Guid EventId { get; private set; }  // Khóa ngoại FK về Event
    public Guid MemberId { get; private set; } // Khóa ngoại FK về Member
    public DateTime RegisteredAt { get; private set; }
    public RegistrationStatus Status { get; private set; }

    private Registration(Guid id, Guid eventId, Guid memberId)
    {
        Id = id;
        EventId = eventId;
        MemberId = memberId;
        RegisteredAt = DateTime.UtcNow;
        Status = RegistrationStatus.Pending;
    }

    /// <summary>
    /// Factory Method khởi tạo phiếu đăng ký mới ở trạng thái Pending.
    /// </summary>
    public static Registration Create(Guid eventId, Guid memberId)
    {
        if (eventId == Guid.Empty)
            throw new ArgumentException("EventId không hợp lệ.", nameof(eventId));

        if (memberId == Guid.Empty)
            throw new ArgumentException("MemberId không hợp lệ.", nameof(memberId));

        return new Registration(Guid.NewGuid(), eventId, memberId);
    }

    /// <summary>
    /// Xác nhận phiếu đăng ký tham gia (chuyển sang Confirmed).
    /// </summary>
    public void Confirm()
    {
        if (Status != RegistrationStatus.Pending)
            throw new InvalidOperationException($"Không thể xác nhận phiếu ở trạng thái {Status}.");

        Status = RegistrationStatus.Confirmed;
    }

    /// <summary>
    /// Hủy đăng ký khi sự kiện còn cách thời điểm hiện tại ít nhất 24 giờ.
    /// </summary>
    public void Cancel(DateTime eventStartTime, DateTime currentTime)
    {
        if (Status == RegistrationStatus.Cancelled)
            throw new InvalidOperationException("Phiếu đăng ký đã bị hủy trước đó.");

        if (eventStartTime <= currentTime.AddHours(24))
            throw new InvalidOperationException("Chỉ được hủy đăng ký khi sự kiện còn ít nhất 24 giờ.");

        Status = RegistrationStatus.Cancelled;
    }
}
