using EduHub.Ch01.Domain;

const string Separator = "========================================";
const int EventCapacity = 50;

static void Step(int number, string title) => Console.WriteLine($"\n{Separator}\nBước {number}: {title}\n{Separator}");

Console.WriteLine("=== EduHub — Club & Event Management ===");

// TODO 1: Tạo CLB "Tech Club"
Step(1, "Tạo câu lạc bộ");
var club = Club.Create("Tech Club", "Câu lạc bộ công nghệ: workshop, hackathon, chia sẻ kiến thức.");
Console.WriteLine($"CLB: {club.Name} — {club.Description}");

// TODO 2: Tạo 3 Member, thêm vào CLB
Step(2, "Thêm thành viên");
var members = new[]
{
    Member.Create("Nguyễn Văn An", "an.nv@student.dthu.edu.vn", "DH24001"),
    Member.Create("Trần Thị Bình", "binh.tt@student.dthu.edu.vn", "DH24002"),
    Member.Create("Lê Hoàng Cường", "cuong.lh@student.dthu.edu.vn", "DH24003"),
};
foreach (var member in members)
{
    club.AddMember(member);
    Console.WriteLine($"+ {member} <{member.Email}>");
}
Console.WriteLine($"Tổng thành viên: {club.MemberCount()}");

// TODO 3: Tạo sự kiện "Workshop AI", capacity = 50
Step(3, "Tạo sự kiện");
var workshop = Event.Create(club.Id, "Workshop AI", DateTime.Today.AddDays(7).AddHours(14), EventCapacity);
Console.WriteLine($"Sự kiện: {workshop.Title} — {workshop.Date:dd/MM/yyyy HH:mm} — sức chứa {workshop.Capacity}");

// TODO 4: 2 Member đăng ký (kiểm tra HasCapacity) → Pending → gọi Confirm()
Step(4, "Đăng ký tham dự");
var registrations = new List<Registration>();
foreach (var member in members.Take(2))
{
    if (!workshop.HasCapacity(registrations.Count))
    {
        Console.WriteLine($"! Hết chỗ, không nhận {member}");
        continue;
    }
    var registration = Registration.Create(member.Id, workshop.Id);
    registrations.Add(registration);
    Console.WriteLine($"{member} đăng ký → {registration.Status}");
}

Step(5, "Xác nhận đăng ký");
foreach (var registration in registrations)
{
    registration.Confirm();
    Console.WriteLine($"Phiếu {registration.Id.ToString()[..8]} → {registration.Status}");
}

// TODO 5: 1 Member check-in
Step(6, "Check-in sự kiện");
var checkIns = new List<CheckIn> { CheckIn.Create(registrations[0], CheckInMethod.QrCode) };
Console.WriteLine(checkIns[0].Summary());

// TODO 6: In báo cáo tham dự: số đăng ký, số check-in, danh sách tên
Step(7, "Báo cáo tham dự");
Console.WriteLine($"Số đăng ký: {registrations.Count}/{workshop.Capacity}");
Console.WriteLine($"Số check-in: {checkIns.Count}");
var memberById = members.ToDictionary(m => m.Id);
foreach (var registration in registrations)
{
    var attended = checkIns.Any(c => c.RegistrationId == registration.Id);
    Console.WriteLine($"- {memberById[registration.MemberId].Name}: {(attended ? "đã check-in" : "chưa check-in")}");
}

// Kiểm tra quy tắc nghiệp vụ bất biến
Step(8, "Kiểm tra bất biến (Cancelled không thể Confirm lại)");
registrations[1].Cancel();
try
{
    registrations[1].Confirm();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Đúng như mong đợi: {ex.Message}");
}

Console.WriteLine("\n✅ Demo complete!");
