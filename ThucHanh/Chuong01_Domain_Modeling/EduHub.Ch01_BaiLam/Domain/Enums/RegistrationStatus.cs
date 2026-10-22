namespace EduHub.Domain.Enums;

/// <summary>
/// Trạng thái của phiếu đăng ký sự kiện.
/// </summary>
public enum RegistrationStatus
{
    /// <summary>
    /// Đang chờ xác nhận từ ban tổ chức.
    /// </summary>
    Pending = 0,

    /// <summary>
    /// Đã được xác nhận tham gia.
    /// </summary>
    Confirmed = 1,

    /// <summary>
    /// Đã bị hủy (bởi người dùng hoặc ban tổ chức).
    /// </summary>
    Cancelled = 2
}
