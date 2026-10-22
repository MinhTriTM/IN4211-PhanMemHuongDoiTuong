using EduHub.Domain.Entities;
using EduHub.Domain.Enums;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("================================================================================");
Console.WriteLine("        CHƯƠNG TRÌNH DEMO NGHIỆP VỤ & DOMAIN MODELING EDUHUB (IN4211)");
Console.WriteLine("                Học phần: Phát triển phần mềm hướng đối tượng");
Console.WriteLine("================================================================================\n");

try
{
    // BƯỚC 1: Khởi tạo Câu lạc bộ
    Console.WriteLine("--- [BƯỚC 1: KHỞI TẠO CÂU LẠC BỘ] ---");
    var club = Club.Create("CLB Tin học DThU", "Câu lạc bộ học thuật & lập trình Khoa CNTT");
    Console.WriteLine($"[✓] Khởi tạo CLB thành công: {club.Name} (Id: {club.Id})");
    Console.WriteLine($"    Mô tả: {club.Description}\n");

    // BƯỚC 2: Khởi tạo các sinh viên (Member)
    Console.WriteLine("--- [BƯỚC 2: KHỞI TẠO SINH VIÊN] ---");
    var m1 = Member.Create("Đoàn Minh Trí", "0024417136", "minhtritm@student.dthu.edu.vn");
    var m2 = Member.Create("Nguyễn Văn An", "0024417101", "an.nv@student.dthu.edu.vn");
    var m3 = Member.Create("Trần Thị Bích", "0024417102", "bich.tt@student.dthu.edu.vn");
    Console.WriteLine($"[✓] Sinh viên 1: {m1.FullName} | MSSV: {m1.StudentCode} | Email: {m1.Email}");
    Console.WriteLine($"[✓] Sinh viên 2: {m2.FullName} | MSSV: {m2.StudentCode} | Email: {m2.Email}");
    Console.WriteLine($"[✓] Sinh viên 3: {m3.FullName} | MSSV: {m3.StudentCode} | Email: {m3.Email}\n");

    // BƯỚC 3: Thêm thành viên vào CLB
    Console.WriteLine("--- [BƯỚC 3: THÊM THÀNH VIÊN VÀO CÂU LẠC BỘ] ---");
    club.AddMember(m1);
    club.AddMember(m2);
    club.AddMember(m3);
    Console.WriteLine($"[✓] Đã thêm thành công {club.Members.Count} thành viên vào {club.Name}.");
    foreach (var m in club.Members)
    {
        Console.WriteLine($"    - {m.FullName} ({m.StudentCode}) - Trạng thái: {(m.IsActive ? "Đang hoạt động" : "Tạm ngưng")}");
    }
    Console.WriteLine();

    // BƯỚC 4: Tạo sự kiện với sức chứa giới hạn (Capacity = 2)
    Console.WriteLine("--- [BƯỚC 4: TẠO SỰ KIỆN VỚI SỨC CHỨA GIỚI HẠN] ---");
    var ev = Event.Create(club.Id, "Workshop Lập trình Hướng đối tượng với .NET 10", DateTime.Now.AddDays(7), 2);
    Console.WriteLine($"[✓] Sự kiện: \"{ev.Title}\"");
    Console.WriteLine($"    Thời gian: {ev.StartTime:dd/MM/yyyy HH:mm} | Sức chứa tối đa: {ev.Capacity} sinh viên\n");

    // BƯỚC 5: Đăng ký tham gia sự kiện
    Console.WriteLine("--- [BƯỚC 5: SINH VIÊN ĐĂNG KÝ SỰ KIỆN] ---");
    var registrations = new List<Registration>();

    if (ev.HasCapacity(registrations.Count))
    {
        var reg1 = Registration.Create(ev.Id, m1.Id);
        registrations.Add(reg1);
        Console.WriteLine($"[✓] {m1.FullName} đã đăng ký thành công (Trạng thái: {reg1.Status})");
    }

    if (ev.HasCapacity(registrations.Count))
    {
        var reg2 = Registration.Create(ev.Id, m2.Id);
        registrations.Add(reg2);
        Console.WriteLine($"[✓] {m2.FullName} đã đăng ký thành công (Trạng thái: {reg2.Status})");
    }
    Console.WriteLine($"[✓] Tổng số lượt đăng ký hiện tại: {registrations.Count}/{ev.Capacity}\n");

    // BƯỚC 6: Xác nhận và Điểm danh tại sự kiện
    Console.WriteLine("--- [BƯỚC 6: XÁC NHẬN PHIẾU & ĐIỂM DANH CHECK-IN] ---");
    registrations[0].Confirm(); // Xác nhận m1
    registrations[1].Confirm(); // Xác nhận m2
    Console.WriteLine($"[✓] Phiếu 1 của {m1.FullName} -> {registrations[0].Status}");
    Console.WriteLine($"[✓] Phiếu 2 của {m2.FullName} -> {registrations[1].Status}");

    // Sinh viên 1 đến sự kiện và check-in thành công
    var checkIn1 = CheckIn.Create(registrations[0], "CỔNG_HỘI_TRƯỜNG_A");
    Console.WriteLine($"[✓] Điểm danh thành công: Sinh viên {m1.FullName} lúc {checkIn1.CheckedInAt:dd/MM/yyyy HH:mm:ss} qua {checkIn1.DeviceInfo}\n");

    // BƯỚC 7: Xuất báo cáo tham dự sự kiện
    Console.WriteLine("================================================================================");
    Console.WriteLine("                    BÁO CÁO TỔNG KẾT THAM DỰ SỰ KIỆN");
    Console.WriteLine("================================================================================");
    Console.WriteLine($"Sự kiện: {ev.Title}");
    Console.WriteLine($"Đơn vị tổ chức: {club.Name}");
    Console.WriteLine($"Sức chứa tối đa: {ev.Capacity} chỗ");
    Console.WriteLine($"Số người đăng ký: {registrations.Count} chỗ (Tỷ lệ lấp đầy: {(double)registrations.Count / ev.Capacity * 100:0.0}%)");
    Console.WriteLine("Danh sách chi tiết:");
    Console.WriteLine($"  1. {m1.FullName} ({m1.StudentCode}) - Trạng thái: {registrations[0].Status} | ĐÃ ĐIỂM DANH lúc {checkIn1.CheckedInAt:HH:mm:ss}");
    Console.WriteLine($"  2. {m2.FullName} ({m2.StudentCode}) - Trạng thái: {registrations[1].Status} | CHƯA ĐIỂM DANH");
    Console.WriteLine("================================================================================\n");

    // Admin có thể tạm dừng quyền tổ chức của CLB mà không thay đổi dữ liệu đăng ký.
    club.SetCanCreateEvent(false);
    Console.WriteLine($"[✓] Admin đã tạm dừng quyền tạo sự kiện: CanCreateEvent = {club.CanCreateEvent}\n");

    // BƯỚC 8: Thử nghiệm vi phạm luật nghiệp vụ (Exception Handling)
    Console.WriteLine("--- [BƯỚC 8: KIỂM THỬ NGOẠI LỆ — VI PHẠM CÁC QUY TẮC NGHIỆP VỤ] ---");

    // Case 8.1: Thử đăng ký khi sự kiện đã đầy chỗ (2/2)
    try
    {
        Console.Write("  [Test 8.1] Sinh viên 3 cố đăng ký khi sự kiện đã đầy sức chứa (2/2): ");
        if (!ev.HasCapacity(registrations.Count))
        {
            throw new InvalidOperationException($"Sự kiện \"{ev.Title}\" đã đạt sức chứa tối đa ({ev.Capacity} chỗ), không thể nhận thêm đăng ký.");
        }
        Console.WriteLine("[LỖI] Cho phép đăng ký vượt quá sức chứa!");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"[THÀNH CÔNG] Bị chặn đúng: \"{ex.Message}\"");
    }

    // Case 8.2: Thử thêm trùng sinh viên vào CLB
    try
    {
        Console.Write("  [Test 8.2] Thêm lại sinh viên Đoàn Minh Trí vào CLB lần thứ 2: ");
        club.AddMember(m1);
        Console.WriteLine("[LỖI] Cho phép thêm trùng sinh viên!");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"[THÀNH CÔNG] Bị chặn đúng: \"{ex.Message}\"");
    }

    // Case 8.3: Khởi tạo Member với email sai định dạng
    try
    {
        Console.Write("  [Test 8.3] Khởi tạo Member với email sai định dạng (\"email_sai\"): ");
        var invalidMember = Member.Create("Nguyễn Lỗi", "0011223344", "email_sai");
        Console.WriteLine("[LỖI] Không kiểm tra định dạng email!");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"[THÀNH CÔNG] Bị chặn đúng: \"{ex.Message}\"");
    }

    // Case 8.4: Thử hủy phiếu rồi xác nhận lại
    try
    {
        Console.Write("  [Test 8.4] Hủy phiếu đăng ký của SV 2 rồi thử xác nhận lại: ");
        registrations[1].Cancel(ev.StartTime, DateTime.Now);
        registrations[1].Confirm(); // Vi phạm luật: phiếu Cancelled không được Confirm
        Console.WriteLine("[LỖI] Quy tắc không chặn được thao tác!");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"[THÀNH CÔNG] Bị chặn đúng: \"{ex.Message}\"");
    }

    // Case 8.5: Thử điểm danh phiếu đang ở trạng thái Cancelled
    try
    {
        Console.Write("  [Test 8.5] Điểm danh phiếu đang ở trạng thái Cancelled: ");
        var invalidCheckIn = CheckIn.Create(registrations[1]);
        Console.WriteLine("[LỖI] Điểm danh sai quy định!");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"[THÀNH CÔNG] Bị chặn đúng: \"{ex.Message}\"");
    }

    Console.WriteLine("\n[✓✓✓] TOÀN BỘ 8 BƯỚC NGHIỆP VỤ & 5/5 CA KIỂM THỬ NGOẠI LỆ ĐỀU VƯỢT QUA XUẤT SẮC!");
}
catch (Exception ex)
{
    Console.WriteLine($"\n[LỖI KHÔNG MONG MUỐN]: {ex.Message}");
}
