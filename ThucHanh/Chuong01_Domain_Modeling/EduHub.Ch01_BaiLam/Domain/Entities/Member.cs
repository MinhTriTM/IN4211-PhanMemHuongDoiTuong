namespace EduHub.Domain.Entities;

/// <summary>
/// Đại diện cho một sinh viên / thành viên trong hệ sinh thái EduHub.
/// </summary>
public class Member
{
    public Guid Id { get; private set; }
    public string FullName { get; private set; } = string.Empty;
    public string StudentCode { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public bool IsActive { get; private set; }

    // Constructor private: bắt buộc khởi tạo qua Factory Method Create()
    private Member(Guid id, string fullName, string studentCode, string email)
    {
        Id = id;
        FullName = fullName;
        StudentCode = studentCode;
        Email = email;
        IsActive = true;
    }

    /// <summary>
    /// Factory Method khởi tạo thành viên mới với kiểm tra dữ liệu đầu vào.
    /// </summary>
    public static Member Create(string fullName, string studentCode, string email)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Họ và tên không được để trống.", nameof(fullName));

        if (string.IsNullOrWhiteSpace(studentCode))
            throw new ArgumentException("Mã số sinh viên không được để trống.", nameof(studentCode));

        if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            throw new ArgumentException("Email không đúng định dạng.", nameof(email));

        return new Member(Guid.NewGuid(), fullName.Trim(), studentCode.Trim().ToUpper(), email.Trim().ToLower());
    }

    /// <summary>
    /// Đình chỉ hoặc ngưng hoạt động của thành viên.
    /// </summary>
    public void Deactivate()
    {
        IsActive = false;
    }

    /// <summary>
    /// Kích hoạt lại tài khoản thành viên.
    /// </summary>
    public void Activate()
    {
        IsActive = true;
    }
}
