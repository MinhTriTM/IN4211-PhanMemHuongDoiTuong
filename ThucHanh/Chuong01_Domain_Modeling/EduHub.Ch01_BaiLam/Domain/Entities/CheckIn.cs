namespace EduHub.Domain.Entities;

using EduHub.Domain.Enums;

/// <summary>
/// Đại diện cho một lượt điểm danh (Check-in) thực tế tại sự kiện.
/// </summary>
public class CheckIn
{
    public Guid Id { get; private set; }
    public Guid RegistrationId { get; private set; } // Khóa ngoại FK về Registration
    public DateTime CheckedInAt { get; private set; }
    public string DeviceInfo { get; private set; } = string.Empty;

    private CheckIn(Guid id, Guid registrationId, string deviceInfo)
    {
        Id = id;
        RegistrationId = registrationId;
        CheckedInAt = DateTime.UtcNow;
        DeviceInfo = deviceInfo;
    }

    /// <summary>
    /// Factory Method khởi tạo lượt điểm danh từ một phiếu đăng ký hợp lệ.
    /// </summary>
    public static CheckIn Create(Registration registration, string deviceInfo = "GATE_SCANNER_A")
    {
        ArgumentNullException.ThrowIfNull(registration);

        if (registration.Status != RegistrationStatus.Confirmed)
            throw new InvalidOperationException($"Chỉ có phiếu đăng ký đã xác nhận (Confirmed) mới được phép điểm danh. Trạng thái hiện tại: {registration.Status}.");

        return new CheckIn(Guid.NewGuid(), registration.Id, string.IsNullOrWhiteSpace(deviceInfo) ? "UNKNOWN_DEVICE" : deviceInfo.Trim());
    }
}
