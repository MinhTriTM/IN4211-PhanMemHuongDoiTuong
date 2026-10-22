using EduHub.Ch02.Logging;
using EduHub.Ch02.Notifications;
using EduHub.Ch02.Patterns.Observers;
using EduHub.Ch02.Patterns.Strategies;
using EduHub.Ch02.Repositories;
using EduHub.Ch02.Services;

Console.WriteLine("EduHub Ch02 — demo sau refactor SOLID và Design Patterns\n");

// Composition root: lớp nghiệp vụ chỉ nhận abstraction qua constructor.
IAppLogger logger = new ConsoleLogger();
IClubRepository clubs = new LoggingClubRepository(new InMemoryClubRepository(), logger);
IMemberRepository members = new InMemoryMemberRepository();
IEventRepository events = new InMemoryEventRepository();
INotificationServiceFactory notificationFactory = new NotificationServiceFactory();
INotificationService email = notificationFactory.Create(NotificationChannel.Email);

IClubService clubService = new ClubService(clubs, members, email, logger);
IEventService eventService = new EventService(clubs, members, events);
IReportService reportService = new ReportService(clubs, members, events);

// Factory chọn kênh; Observer được đăng ký mà không sửa EventService.
eventService.Subscribe(new LogNotifier(logger));
eventService.Subscribe(new EmailNotifier(members, email));

var club = clubService.CreateClub(
    "Tech, \"Makers\" Club",
    "Câu lạc bộ công nghệ và chế tạo.",
    "president@dthu.edu.vn");
var member = clubService.AddMember(club.Id, "Nguyễn Văn A", "a@student.dthu.edu.vn");
var ev = eventService.CreateEvent(club.Id, "Workshop SOLID", new DateTime(2026, 11, 20));
eventService.Register(ev.Id, member.Id);
eventService.CheckIn(ev.Id, member.Id);

Console.WriteLine("\n--- Strategy: báo cáo Console ---");
Console.Write(reportService.Generate(new ConsoleReportStrategy()));

Console.WriteLine("--- Strategy: báo cáo CSV (đã escape tên CLB) ---");
Console.Write(reportService.Generate(new CsvReportStrategy()));
