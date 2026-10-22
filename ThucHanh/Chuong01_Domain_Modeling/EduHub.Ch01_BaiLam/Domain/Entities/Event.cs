namespace EduHub.Domain.Entities;

/// <summary>
/// Đại diện cho một sự kiện (Workshop, Seminar, Hackathon) do CLB tổ chức.
/// </summary>
public class Event
{
    public Guid Id { get; private set; }
    public Guid ClubId { get; private set; } // Khóa ngoại FK về Club
    public string Title { get; private set; } = string.Empty;
    public DateTime StartTime { get; private set; }
    public int Capacity { get; private set; }
    public bool IsRescheduled { get; private set; }

    private Event(Guid id, Guid clubId, string title, DateTime startTime, int capacity)
    {
        Id = id;
        ClubId = clubId;
        Title = title;
        StartTime = startTime;
        Capacity = capacity;
        IsRescheduled = false;
    }

    /// <summary>
    /// Factory Method khởi tạo sự kiện mới.
    /// </summary>
    public static Event Create(Guid clubId, string title, DateTime startTime, int capacity)
    {
        if (clubId == Guid.Empty)
            throw new ArgumentException("ClubId không hợp lệ.", nameof(clubId));

        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Tiêu đề sự kiện không được để trống.", nameof(title));

        if (capacity <= 0)
            throw new ArgumentOutOfRangeException(nameof(capacity), "Sức chứa sự kiện phải lớn hơn 0.");

        return new Event(Guid.NewGuid(), clubId, title.Trim(), startTime, capacity);
    }

    /// <summary>
    /// Kiểm tra xem sự kiện còn đủ chỗ trống để đăng ký hay không.
    /// </summary>
    public bool HasCapacity(int currentActiveRegistrations)
    {
        return currentActiveRegistrations < Capacity;
    }

    /// <summary>
    /// Dời lịch hoặc cập nhật lại thời gian tổ chức sự kiện.
    /// </summary>
    public void Reschedule(DateTime newStartTime)
    {
        if (newStartTime <= DateTime.UtcNow)
            throw new ArgumentException("Thời gian dời lịch mới phải là thời điểm trong tương lai.", nameof(newStartTime));

        StartTime = newStartTime;
        IsRescheduled = true;
    }
}
