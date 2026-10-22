namespace EduHub.Ch01.Domain;

/// <summary>Câu lạc bộ sinh viên.</summary>
public class Club
{
    private readonly List<Member> _members = [];

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public IReadOnlyList<Member> Members => _members;

    private Club(string name, string description)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        CreatedAt = DateTime.UtcNow;
    }

    public static Club Create(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Tên CLB không được để trống.", nameof(name));

        return new Club(name.Trim(), description?.Trim() ?? string.Empty);
    }

    public void AddMember(Member member)
    {
        ArgumentNullException.ThrowIfNull(member);
        if (_members.Any(m => m.Id == member.Id))
            throw new InvalidOperationException($"{member} đã là thành viên của {Name}.");

        _members.Add(member);
    }

    public int MemberCount() => _members.Count;
}
