namespace EduHub.Domain.Entities;

/// <summary>
/// Đại diện cho một Câu lạc bộ sinh viên trong trường.
/// </summary>
public class Club
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public bool CanCreateEvent { get; private set; }

    // Đóng gói danh sách: private bên trong, công khai IReadOnlyList ra ngoài
    private readonly List<Member> _members = new();
    public IReadOnlyList<Member> Members => _members.AsReadOnly();

    private Club(Guid id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
        CanCreateEvent = true;
    }

    /// <summary>
    /// Factory Method khởi tạo Câu lạc bộ.
    /// </summary>
    public static Club Create(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Tên câu lạc bộ không được để trống.", nameof(name));

        return new Club(Guid.NewGuid(), name.Trim(), description?.Trim() ?? string.Empty);
    }

    /// <summary>
    /// Thêm thành viên vào CLB, kiểm tra tính duy nhất và trạng thái hoạt động.
    /// </summary>
    public void AddMember(Member member)
    {
        ArgumentNullException.ThrowIfNull(member);

        if (!member.IsActive)
            throw new InvalidOperationException($"Sinh viên {member.FullName} đã bị ngưng hoạt động, không thể tham gia CLB.");

        if (_members.Any(m => m.Id == member.Id || m.StudentCode == member.StudentCode))
            throw new InvalidOperationException($"Sinh viên {member.FullName} ({member.StudentCode}) đã là thành viên của CLB.");

        _members.Add(member);
    }

    /// <summary>
    /// Cập nhật quyền tạo sự kiện (do Admin điều khiển).
    /// </summary>
    public void SetCanCreateEvent(bool canCreate)
    {
        CanCreateEvent = canCreate;
    }
}
