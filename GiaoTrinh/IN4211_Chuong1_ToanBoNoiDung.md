# IN4211 — Chương 1: Giới thiệu phần mềm và môi trường

> Nguồn: Slide 69 trang, Khoa Công nghệ và Kỹ thuật — Trường Đại học Đồng Tháp.
> Giảng viên: ThS. Nguyễn Tuấn Kiệt · Năm học 2026–2027.

## Mục lục theo trang

- [Trang 1: TRƯỜNG ĐẠI HỌC ĐỒNG THÁP](#trang-1)
- [Trang 2: Nội dung chương 1](#trang-2)
- [Trang 3: Học xong môn này bạn làm được gì? (1/2)](#trang-3)
- [Trang 4: Học xong môn này bạn làm được gì? (2/2)](#trang-4)
- [Trang 5: Lộ trình 15 tuần](#trang-5)
- [Trang 6: Cách lớp học vận hành](#trang-6)
- [Trang 7: Quy trình nộp slide thuyết trình](#trang-7)
- [Trang 8: Cách chấm điểm](#trang-8)
- [Trang 9: Quy định đối với sinh viên](#trang-9)
- [Trang 10: EduHub — dự án xuyên suốt học kỳ](#trang-10)
- [Trang 11: TRƯỜNG ĐẠI HỌC ĐỒNG THÁP](#trang-11)
- [Trang 12: 1.1         Tại sao chọn .NET 10?](#trang-12)
- [Trang 13: 1.2         Hệ sinh thái .NET 10](#trang-13)
- [Trang 14: 1.3         Tại sao chọn .NET 10? (tiếp)](#trang-14)
- [Trang 15: 1.4         Công cụ cần cài (1/2) — Viết code](#trang-15)
- [Trang 16: 1.5         Công cụ cần cài (2/2) — Dùng ở các chương sau](#trang-16)
- [Trang 17: 1.6         Cài và kiểm tra](#trang-17)
- [Trang 18: 1.7         Hello World — chạy chương trình đầu tiên](#trang-18)
- [Trang 19: 1.8         Nội dung Program.cs](#trang-19)
- [Trang 20: 1.9         Cấu trúc project .NET](#trang-20)
- [Trang 21: TRƯỜNG ĐẠI HỌC ĐỒNG THÁP](#trang-21)
- [Trang 22: 2.1         4 trụ cột của OOP](#trang-22)
- [Trang 23: 2.2          Kế thừa & đa hình](#trang-23)
- [Trang 24: 2.3          Data bag — cách làm sai](#trang-24)
- [Trang 25: 2.4          Encapsulation — cách làm đúng](#trang-25)
- [Trang 26: 2.5          Interface = “hợp đồng”](#trang-26)
- [Trang 27: 2.6          Interface hay Abstract class?](#trang-27)
- [Trang 28: TRƯỜNG ĐẠI HỌC ĐỒNG THÁP](#trang-28)
- [Trang 29: 3.1         Bài toán EduHub](#trang-29)
- [Trang 30: 3.2          Bức tranh tổng thể](#trang-30)
- [Trang 31: 3.3          User Story là gì?](#trang-31)
- [Trang 32: 3.4          User Story — Sinh viên](#trang-32)
- [Trang 33: 3.5          User Story — Ban CLB & Admin](#trang-33)
- [Trang 34: 3.6          3 vai trò (actor) của EduHub](#trang-34)
- [Trang 35: TRƯỜNG ĐẠI HỌC ĐỒNG THÁP](#trang-35)
- [Trang 36: 4.1         Từ User Story tìm ra Entity](#trang-36)
- [Trang 37: 4.2          Từ yêu cầu đến code — 6 bước](#trang-37)
- [Trang 38: 4.3          5 Entity — thuộc tính & hành vi (1)](#trang-38)
- [Trang 39: 4.4          5 Entity — thuộc tính & hành vi (2)](#trang-39)
- [Trang 40: 4.5          Sơ đồ lớp sơ bộ (class diagram)](#trang-40)
- [Trang 41: 4.6          Quan hệ và khoá ngoại (FK)](#trang-41)
- [Trang 42: 4.7          Code Member — thuộc tính & constructor](#trang-42)
- [Trang 43: 4.8          Vì sao constructor (hàm khởi tạo) là private?](#trang-43)
- [Trang 44: 4.9          Code Member — factory Create()](#trang-44)
- [Trang 45: 4.10         Code Club — AddMember()](#trang-45)
- [Trang 46: 4.11         Code Event — Create() & HasCapacity()](#trang-46)
- [Trang 47: 4.12         Code Registration — Confirm()](#trang-47)
- [Trang 48: 4.13         Code CheckIn — Create()](#trang-48)
- [Trang 49: 4.14         Vòng đời của Registration](#trang-49)
- [Trang 50: 4.15         Console demo — 7 bước](#trang-50)
- [Trang 51: TRƯỜNG ĐẠI HỌC ĐỒNG THÁP](#trang-51)
- [Trang 52: 5.1         Git và GitHub: bốn khu vực của một repo](#trang-52)
- [Trang 53: 5.2            Quy trình làm việc với repo](#trang-53)
- [Trang 54: 5.3          Các lệnh Git cơ bản](#trang-54)
- [Trang 55: 5.4          Branch — nhánh làm việc riêng](#trang-55)
- [Trang 56: 5.5          Pull Request — đề nghị gộp code](#trang-56)
- [Trang 57: 5.6          Quy ước commit message](#trang-57)
- [Trang 58: 5.7          Commit message tốt và chưa tốt](#trang-58)
- [Trang 59: 5.8          Thực hành: Pull Request đầu tiên](#trang-59)
- [Trang 60: TRƯỜNG ĐẠI HỌC ĐỒNG THÁP](#trang-60)
- [Trang 61: Bài tập Ch01 — 100 điểm](#trang-61)
- [Trang 62: Yêu cầu từng nhiệm vụ](#trang-62)
- [Trang 63: Cách nộp bài](#trang-63)
- [Trang 64: Lỗi thường gặp](#trang-64)
- [Trang 65: Demo (1/2) — Chạy đáp án mẫu](#trang-65)
- [Trang 66: Demo (2/2) — Quy tắc nghiệp vụ](#trang-66)
- [Trang 67: Tổng kết Chương 1](#trang-67)
- [Trang 68: Câu hỏi tự kiểm tra](#trang-68)
- [Trang 69: Chuẩn bị cho Chương 2 (tuần 3–4)](#trang-69)

---

<a id="trang-1"></a>
## Trang 1/69

```text
TRƯỜNG ĐẠI HỌC ĐỒNG THÁP
             Khoa Công nghệ và Kỹ thuật




 IN4211 · CHƯƠNG 1
                                                              Giao diện


Giới thiệu phần mềm                                    Nghiệp vụ (Domain)
& môi trường
Phát triển phần mềm hướng đối tượng                               Dữ liệu


Giảng viên    ThS. Nguyễn Tuấn Kiệt
Năm học       2026–2027
                                                   class Club {
 C#   .NET      OOP    Git
                                                   string Name;
                                                   void Join(Student s);
                                                   }


  0836 980 284        nguyentuankiet@dthu.edu.vn
```

---

<a id="trang-2"></a>
## Trang 2/69

```text
Nội dung chương 1




🧰 1.1 — .NET 10 ecosystem, công cụ phát triển, cài môi trường
🏛️ 1.2 — Ôn tập OOP cơ bản: class, inheritance, polymorphism, interface
🎓 1.3 — Giới thiệu domain bài toán EduHub
🗂️ 1.4 — Tư duy mô hình hoá lớp (class diagram sơ bộ)
🌿 1.5 — Git và GitHub cơ bản · quy ước commit message
📝 Bài tập Ch01 — Phân tích yêu cầu và Domain Modeling EduHub

IN4211 — Phát triển phần mềm hướng đối tượng             ThS. Nguyễn Tuấn Kiệt   2 / 69
```

---

<a id="trang-3"></a>
## Trang 3/69

```text
Học xong môn này bạn làm được gì? (1/2)



CLO = chuẩn đầu ra: việc bạn làm được khi học xong. Môn có 7 CLO:
    CLO1 — Thiết kế và xây phần mềm theo Clean Architecture (4 lớp) trên .NET 10;
    áp dụng SOLID và chọn đúng Design Pattern
    CLO2 — Xây REST API an toàn (JWT, Argon2id), dùng ORM (EF Core, Dapper)
    với PostgreSQL; quản lý code bằng Git/GitHub theo quy trình nhóm
    CLO3 — Viết unit test (xUnit, Moq, coverage ≥ 50%), đóng gói bằng Docker,
    thiết lập CI/CD cơ bản với GitHub Actions
    CLO4 — Vận dụng kiến thức để xây một ứng dụng web quản lý hoàn chỉnh
    (EduHub): từ phân tích yêu cầu, thiết kế đến triển khai



IN4211 — Phát triển phần mềm hướng đối tượng                   ThS. Nguyễn Tuấn Kiệt   3 / 69
```

---

<a id="trang-4"></a>
## Trang 4/69

```text
Học xong môn này bạn làm được gì? (2/2)



    CLO5 — Làm việc nhóm theo quy trình Agile; trình bày kết quả kỹ thuật rõ ràng
    và nhận phản hồi mang tính xây dựng
    CLO6 — Thực hiện nghiêm nội quy lớp học và quy định của học phần; tham dự
    đủ buổi (vắng không quá 20% số tiết)
    CLO7 — Tự tìm hiểu, tự nghiên cứu, tiếp cận công nghệ mới từ nhiều nguồn để
    tạo ra sản phẩm theo yêu cầu

   Chương 1 góp phần vào CLO1, CLO4 và CLO5: mô hình hoá EduHub bằng
   class, làm quen Git/GitHub và nộp bài bằng Pull Request.




IN4211 — Phát triển phần mềm hướng đối tượng                   ThS. Nguyễn Tuấn Kiệt   4 / 69
```

---

<a id="trang-5"></a>
## Trang 5/69

```text
Lộ trình 15 tuần



  TUẦN                       PHẦN              NỘI DUNG


  1–2                        Chương 1          Giới thiệu, OOP, .NET 10, Git, Domain Modeling
  3–4                        Chương 2          SOLID, Design Patterns, unit test, Git nâng cao
  5–6                        Chương 3          Clean Architecture, DI, REST API, Swagger
  6–11                       Chương 4          EF Core, PostgreSQL, Dapper, CRUD đầy đủ
  11–13                      Chương 5          JWT, Argon2id, phân quyền, OWASP, QR
  13–15                      Chương 6          Kiểm thử, Docker, GitHub Actions, demo EduHub
  4, 9, 12, 14               SV thuyết trình   DDD · Microservices · OAuth2/OIDC · DevOps




IN4211 — Phát triển phần mềm hướng đối tượng                                ThS. Nguyễn Tuấn Kiệt   5 / 69
```

---

<a id="trang-6"></a>
## Trang 6/69

```text
Cách lớp học vận hành




           📖
      Đọc trước
                                               💻
                                           Thực hành
                                                                            🎤
                                                                        Trình bày
                                                                                                   🧑‍🏫
                                                                                            GV tổng kết
          tài liệu                             tại lớp                 và phản biện         chốt kiến thức




                                                         lặp lại mỗi tuần

    Chương 1–2: giảng viên giới thiệu tổng quan và khởi động dự án EduHub
    Từ Chương 3: sinh viên tự nghiên cứu, nhóm 2–3 SV thuyết trình; giảng viên
    phản biện và chuẩn hoá kiến thức


IN4211 — Phát triển phần mềm hướng đối tượng                                          ThS. Nguyễn Tuấn Kiệt   6 / 69
```

---

<a id="trang-7"></a>
## Trang 7/69

```text
Quy trình nộp slide thuyết trình


           Nộp slide trước 23:59 của ngày cách buổi thuyết trình 4 ngày: push lên
   1       nhánh của nhóm, tạo Pull Request về main , tag giảng viên

  2        Giảng viên phản hồi trên Pull Request trong vòng 24 giờ


  3        Nhóm chỉnh sửa, push commit mới trước buổi học tối thiểu 2 giờ

           Thuyết trình và phản biện tại lớp; slide cuối được link vào issue
  4        tương ứng

   Nộp trễ: không có phản hồi trước và bị trừ 30% điểm thuyết trình. Không có
   commit chỉnh sửa: mất 10% điểm phần phản hồi.


IN4211 — Phát triển phần mềm hướng đối tượng                      ThS. Nguyễn Tuấn Kiệt   7 / 69
```

---

<a id="trang-8"></a>
## Trang 8/69

```text
Cách chấm điểm



  MÃ                THÀNH PHẦN                                   TỶ TRỌNG


  HĐ1.1             Chuyên cần (điểm danh)                       20% của HĐ1

  HĐ1.2             Thuyết trình nhóm                            40% của HĐ1

  HĐ1.3             Bài tập chương (nộp Pull Request)            40% của HĐ1

  HĐ2.1             Bài tập lớn: demo, báo cáo, commit history   50% tổng điểm


   HĐ1 (đánh giá thường xuyên) = 50% tổng điểm · HĐ2.1 = 50%. Chương 1 có
   bài tập chấm theo HĐ1.3.



IN4211 — Phát triển phần mềm hướng đối tượng                     ThS. Nguyễn Tuấn Kiệt   8 / 69
```

---

<a id="trang-9"></a>
## Trang 9/69

```text
Quy định đối với sinh viên




    Tham dự đủ từ 80% số tiết; vào lớp trễ 15 phút tính là vắng buổi đó
    Không làm việc riêng, không dùng điện thoại trong giờ học
    Tài khoản trực tuyến định danh bằng MSSV, họ tên thật, avatar thật
    Thuyết trình theo nhóm 2–3 SV; chủ đề và thứ tự bốc thăm ở buổi đầu, ghi vào
    Google Sheets và commit vào repo của lớp trong 24 giờ
    Bài tập lớn: mỗi tính năng một commit, message theo Conventional Commits;
    Pull Request phải có mô tả (what, why, how to test)




IN4211 — Phát triển phần mềm hướng đối tượng                     ThS. Nguyễn Tuấn Kiệt   9 / 69
```

---

<a id="trang-10"></a>
## Trang 10/69

```text
EduHub — dự án xuyên suốt học kỳ


EduHub = hệ thống quản lý câu lạc bộ (CLB) và sự kiện sinh viên. Mỗi
chương thêm một phần mới vào cùng dự án.


                                                                                                     Ch06
                                                                                 Ch05            Test, Docker,
                                                                  Ch04        JWT, bảo mật,         CI/CD

  Chương này
                                                  Ch03            EF Core,     QR check-in

                             Ch02              Kiến trúc sạch,   PostgreSQL

      Ch01                   SOLID,               REST API

   Mô hình hoá               Pattern
    bài toán




IN4211 — Phát triển phần mềm hướng đối tượng                                          ThS. Nguyễn Tuấn Kiệt   10 / 69
```

---

<a id="trang-11"></a>
## Trang 11/69

```text
TRƯỜNG ĐẠI HỌC ĐỒNG THÁP
                                                                             IN4211 · Chương 1
Khoa Công nghệ và Kỹ thuật




                             PHẦN 1




     1
                             1.1 · .NET 10 ecosystem,
                             công cụ và cài môi trường
                               .NET 10 là gì, vì sao chọn
                               Hệ sinh thái .NET 10

    PHẦN 1 / 6
                               VS Code, JetBrains Rider và công cụ cần cài
                               Cài, kiểm tra và chạy chương trình đầu tiên
```

---

<a id="trang-12"></a>
## Trang 12/69

```text
1.1         Tại sao chọn .NET 10?



                                                         💻   Windows


      Code C#                                    ⚙️      🐧   Linux
       của bạn
                                               .NET 10   🍎   macOS

                                                         🐳   Docker, đám mây

🌍 Viết một lần, chạy trên mọi hệ điều hành
🧰 Làm được web, API, mobile, desktop
IN4211 — Phát triển phần mềm hướng đối tượng                  ThS. Nguyễn Tuấn Kiệt   12 / 69
```

---

<a id="trang-13"></a>
## Trang 13/69

```text
1.2         Hệ sinh thái .NET 10



                   Ứng dụng của bạn: web, API, console, desktop, mobile

                     ASP.NET Core                                           EF Core · Dapper
             xây web và REST API (Ch03)                                 làm việc với database (Ch04)

                                  Thư viện chuẩn (BCL) + Runtime (CLR)
                        chạy chương trình, quản lý bộ nhớ, cung cấp sẵn List, File, Task…

           Ngôn ngữ C#                         .NET SDK + dotnet CLI                            NuGet
         bạn viết code ở đây                         build, run, test              kho thư viện của cộng đồng

                             Hình 1.1. Các thành phần chính của hệ sinh thái .NET 10 (tự vẽ).



IN4211 — Phát triển phần mềm hướng đối tượng                                              ThS. Nguyễn Tuấn Kiệt   13 / 69
```

---

<a id="trang-14"></a>
## Trang 14/69

```text
1.3         Tại sao chọn .NET 10? (tiếp)




🚀 Chạy nhanh — luôn nằm nhóm đầu các bảng so tốc độ web
🏢 Nhiều nơi dùng — Microsoft, FPT Software, VPBank Tech
🎓 LTS = bản được Microsoft hỗ trợ lâu dài. .NET 10 được cập nhật
đến 11/2028
📅 Học một lần, dùng đến khi tốt nghiệp


IN4211 — Phát triển phần mềm hướng đối tượng            ThS. Nguyễn Tuấn Kiệt   14 / 69
```

---

<a id="trang-15"></a>
## Trang 15/69

```text
1.4         Công cụ cần cài (1/2) — Viết code



                .NET 10 SDK                      Visual Studio Code
                Bộ công cụ viết & chạy C#        Trình soạn code nhẹ, miễn phí. Cài
                (bắt buộc)                       thêm tiện ích “C# Dev Kit”
                dotnet.microsoft.com/download    code.visualstudio.com/download



                JetBrains Rider
                                                 Git
                IDE cho .NET, chạy cả
                                                 Lưu lịch sử thay đổi của code
                Windows/macOS/Linux. Sinh viên
                                                 (học ở mục 1.5)
                dùng miễn phí
                                                 git-scm.com/downloads
                jetbrains.com/rider/download




Chỉ cần chọn một trong ba: VS Code, Visual Studio hoặc Rider.
IN4211 — Phát triển phần mềm hướng đối tượng                  ThS. Nguyễn Tuấn Kiệt   15 / 69
```

---

<a id="trang-16"></a>
## Trang 16/69

```text
1.5         Công cụ cần cài (2/2) — Dùng ở các chương sau


                PostgreSQL                        Postman
                Cơ sở dữ liệu dùng từ Chương 4.   Gọi thử API: gửi yêu cầu (request),
                Bộ cài kèm pgAdmin                xem kết quả trả về (response)
                postgresql.org/download           postman.com/downloads



                Docker Desktop                    Tài khoản GitHub
                Chạy PostgreSQL & app trong
                                                  Lưu code trên mạng, làm việc
                “container” — hộp đóng gói sẵn
                                                  nhóm, nộp bài bằng Pull Request
                (Chương 6)
                                                  github.com/signup
                docker.com/get-started



Chương 1–2 chưa cần các công cụ này — cài trước Chương 3 (Postman) và
Chương 4 (PostgreSQL).
IN4211 — Phát triển phần mềm hướng đối tượng                    ThS. Nguyễn Tuấn Kiệt   16 / 69
```

---

<a id="trang-17"></a>
## Trang 17/69

```text
1.6         Cài và kiểm tra




  winget install Microsoft.DotNet.SDK.10   # cài .NET (Windows)
  dotnet --version                         # kiểm tra .NET
  git --version                            # kiểm tra Git
  git config --global user.name "Tên bạn" # tên hiện trong lịch sử Git
  git config --global user.email "email@truong.edu.vn" # email của bạn


    Tài khoản GitHub: dùng MSSV, họ tên thật và ảnh thật (quy định của lớp)
    Tạo repo (kho chứa code) eduhub để làm bài tập chương




IN4211 — Phát triển phần mềm hướng đối tượng                     ThS. Nguyễn Tuấn Kiệt   17 / 69
```

---

<a id="trang-18"></a>
## Trang 18/69

```text
1.7         Hello World — chạy chương trình đầu tiên




    1      Tạo thư mục                         2   Tạo project      3   Chạy thử

    mkdir EduHub                               dotnet new console   cd EduHub.Console
    cd EduHub                                  -n EduHub.Console    dotnet run



Console app = chương trình chạy trong cửa sổ dòng lệnh. mkdir = tạo thư
mục, cd = đi vào thư mục.



IN4211 — Phát triển phần mềm hướng đối tượng                            ThS. Nguyễn Tuấn Kiệt   18 / 69
```

---

<a id="trang-19"></a>
## Trang 19/69

```text
1.8         Nội dung Program.cs




  // EduHub.Console/Program.cs
  Console.WriteLine("Chào mừng đến với EduHub!");   // in ra màn hình
  Console.WriteLine($"Hôm nay: {DateTime.Now:dd/MM/yyyy}");


  $ dotnet run
  Chào mừng đến với EduHub!
  Hôm nay: 05/10/2026


   ACTIVE RECALL          Lệnh dotnet new console tạo ra những file nào?




IN4211 — Phát triển phần mềm hướng đối tượng                           ThS. Nguyễn Tuấn Kiệt   19 / 69
```

---

<a id="trang-20"></a>
## Trang 20/69

```text
1.9         Cấu trúc project .NET



  EduHub/
  ├── EduHub.sln                               ← gom nhiều project
  ├── EduHub.Console/
  │   ├── EduHub.Console.csproj                ← mô tả project
  │   ├── Program.cs                           ← điểm bắt đầu chạy
  │   └── obj/                                 ← file tạm (đừng commit)
  └── EduHub.Domain/
      ├── EduHub.Domain.csproj                 ← thư viện chứa các class của bài toán
      └── Entities/Member.cs


Ba file chính: .sln (gom nhiều project), .csproj (khai báo .NET và thư viện),
Program.cs (điểm bắt đầu chạy).


IN4211 — Phát triển phần mềm hướng đối tượng                                 ThS. Nguyễn Tuấn Kiệt   20 / 69
```

---

<a id="trang-21"></a>
## Trang 21/69

```text
TRƯỜNG ĐẠI HỌC ĐỒNG THÁP
                                                                         IN4211 · Chương 1
Khoa Công nghệ và Kỹ thuật




  2
                             PHẦN 2


                             1.2 · Ôn tập OOP cơ bản
                               4 trụ cột của OOP
                               Class, kế thừa (inheritance) và đa hình
                               (polymorphism)
                               Encapsulation — cách sai và cách đúng
    PHẦN 2 / 6
                               Interface hay Abstract class
```

---

<a id="trang-22"></a>
## Trang 22/69

```text
2.1         4 trụ cột của OOP




   🔒          Encapsulation (Đóng gói)
              Giấu dữ liệu trong class,
              chỉ mở cửa qua method.
                                               🧩   Abstraction (Trừu tượng)
                                                   Chỉ nói “làm gì”, giấu
                                                   “làm như thế nào”.

              Như máy ATM: chỉ bấm nút             Như lái xe: không cần hiểu động cơ




   🧬          Inheritance (Kế thừa)
              Class con dùng lại của cha,
              rồi thêm cái mới.
                                               🎭   Polymorphism (Đa hình)
                                                   Cùng một lệnh, mỗi loại
                                                   làm theo cách riêng.

              Như con thừa hưởng cha mẹ            Như “kêu”: chó sủa, mèo meo




IN4211 — Phát triển phần mềm hướng đối tượng                      ThS. Nguyễn Tuấn Kiệt   22 / 69
```

---

<a id="trang-23"></a>
## Trang 23/69

```text
2.2          Kế thừa & đa hình




                                                         Event
                                                Title, Date, GetLocation()




            OfflineEvent (trực tiếp)                                              OnlineEvent
          GetLocation() ➜ “Phòng A101”                                       GetLocation() ➜ link họp


 Cùng gọi GetLocation() , mỗi loại event trả kết quả riêng.



 IN4211 — Phát triển phần mềm hướng đối tượng                                           ThS. Nguyễn Tuấn Kiệt   23 / 69
```

---

<a id="trang-24"></a>
## Trang 24/69

```text
2.3          Data bag — cách làm sai




    public class Member
    {
        public string Email { get; set; }                   // ai cũng sửa được
    }

    member.Email = "abc";                       // email sai mà vẫn nhận
    club.Members.Add(member);                   // thêm thẳng, bỏ qua luật chố ng trùng
    member.Status = "???";                      // gõ bậy gì cũng nhận


 Mọi luật nghiệp vụ đều bị qua mặt.



 IN4211 — Phát triển phần mềm hướng đối tượng                              ThS. Nguyễn Tuấn Kiệt   24 / 69
```

---

<a id="trang-25"></a>
## Trang 25/69

```text
2.4          Encapsulation — cách làm đúng




    public string Email { get; private set; }

    public static Member Create(/* ... */)
    {
        if (!email.Contains('@'))
            throw new ArgumentException("Email sai");
        // ...
    }

    public IReadOnlyList<Member> Members => _members;   // chỉ xem
    public void AddMember(Member m) { … }               // chặn trùng




 IN4211 — Phát triển phần mềm hướng đối tượng                       ThS. Nguyễn Tuấn Kiệt   25 / 69
```

---

<a id="trang-26"></a>
## Trang 26/69

```text
2.5          Interface = “hợp đồng”



                                                                     SqlEventRepository
                                                                     lưu vào database (SQL)
                                                    «interface»

          🧑‍💻                                   IEventRepository
                                                  GetById(id)
      Code gọi
                                                   Add(event)
                                                                   InMemoryEventRepository
                                                                        lưu trong bộ nhớ



 Chỉ nói làm được gì. Như ổ cắm: thiết bị nào đúng chuẩn cũng cắm được.
 Mũi tên đứt = “làm theo hợp đồng”.


 IN4211 — Phát triển phần mềm hướng đối tượng                            ThS. Nguyễn Tuấn Kiệt   26 / 69
```

---

<a id="trang-27"></a>
## Trang 27/69

```text
2.6          Interface hay Abstract class?




   🔌 Interface                                  🏗️ Abstract class
           Hợp đồng: làm được gì                   Chia sẻ code dùng chung
           Không có code làm sẵn                   Có method viết sẵn và method
           Một class làm theo được                 để trống cho class con tự viết
           nhiều interface                         Mỗi class chỉ kế thừa một
           Dễ thay bằng bản giả (mock) để          class cha
           chạy thử                                Quan hệ “là một loại” (is-a)




 IN4211 — Phát triển phần mềm hướng đối tượng                       ThS. Nguyễn Tuấn Kiệt   27 / 69
```

---

<a id="trang-28"></a>
## Trang 28/69

```text
TRƯỜNG ĐẠI HỌC ĐỒNG THÁP
                                                                   IN4211 · Chương 1
Khoa Công nghệ và Kỹ thuật




  3
                             PHẦN 3


                             1.3 · Giới thiệu domain bài
                             toán EduHub
                               Bài toán và bức tranh tổng thể
                               User Story và tiêu chí nghiệm thu
    PHẦN 3 / 6
                               Ba vai trò (actor) của EduHub
```

---

<a id="trang-29"></a>
## Trang 29/69

```text
3.1         Bài toán EduHub




EduHub giúp sinh viên tham gia CLB và dự sự kiện. Mỗi đối tượng chính của
bài toán gọi là entity:

    Sinh viên (Member) xem và tham gia Club
    Mỗi Club tổ chức nhiều Event: workshop, seminar, hackathon
    Đăng ký dự sự kiện → tạo Registration (phiếu đăng ký)
    Ngày diễn ra: ban tổ chức ghi CheckIn (điểm danh)




IN4211 — Phát triển phần mềm hướng đối tượng                ThS. Nguyễn Tuấn Kiệt   29 / 69
```

---

<a id="trang-30"></a>
## Trang 30/69

```text
3.2          Bức tranh tổng thể




        👤
     Member
                                      🏛️
                                      Club
                                                          📅
                                                          Event
                                                                              📋
                                                                          Registration
                                                                                                      ✅
                                                                                                    CheckIn
     thành viên                   câu lạc bộ              sự kiện         phiếu đăng ký            điểm danh


                    tham gia                    tổ chức             đăng ký          điểm danh

 Chương 1: chỉ viết class OOP, chưa có database, chưa có API.

 Mỗi hình vuông sẽ thành một class C#. Cả bộ class này gọi là domain
 model (mô hình của bài toán).


 IN4211 — Phát triển phần mềm hướng đối tượng                                         ThS. Nguyễn Tuấn Kiệt   30 / 69
```

---

<a id="trang-31"></a>
## Trang 31/69

```text
3.3          User Story là gì?




        User Story (câu chuyện người dùng) = một yêu cầu viết bằng câu đơn giản
                    “Là [vai trò], tôi muốn [việc cần làm], để [lợi ích].”


        Tiêu chí nghiệm thu (acceptance criteria) = điều kiện để biết đã làm xong

      Given (cho trước)                          When (khi)           Then (thì)
        tình huống bắt đầu                      người dùng làm gì   kết quả mong đợi




 IN4211 — Phát triển phần mềm hướng đối tượng                        ThS. Nguyễn Tuấn Kiệt   31 / 69
```

---

<a id="trang-32"></a>
## Trang 32/69

```text
3.4          User Story — Sinh viên



    US-01 · Sinh viên: tham gia một CLB
    ① Chưa là thành viên ➜ tham gia ➜ có tên trong club.Members
    ② Đã là thành viên ➜ tham gia lại ➜ bị từ chối (không trùng)
    US-02 · Sinh viên: đăng ký một sự kiện
    ① Còn chỗ ➜ đăng ký ➜ tạo Registration (Pending = chờ xác nhận)
    ② Hết chỗ (đủ Capacity = sức chứa) ➜ đăng ký ➜ báo hết chỗ

    US-03 · Sinh viên: check-in (điểm danh) tại sự kiện
    ① Phiếu Confirmed ➜ check-in ➜ tạo CheckIn
    ② Phiếu Pending / Cancelled ➜ check-in ➜ bị từ chối


 IN4211 — Phát triển phần mềm hướng đối tượng                  ThS. Nguyễn Tuấn Kiệt   32 / 69
```

---

<a id="trang-33"></a>
## Trang 33/69

```text
3.5          User Story — Ban CLB & Admin



    US-04 · Ban CLB: tạo sự kiện
    ① Capacity > 0 , có tiêu đề ➜ tạo ➜ gắn đúng ClubId
    ② Tiêu đề trống hoặc capacity ≤ 0 ➜ tạo ➜ báo lỗi
    US-05 · Ban CLB: xem báo cáo tham dự
    ① Thấy số người đăng ký / sức chứa và số người đã check-in
    ② Liệt kê từng người: đã / chưa check-in

    US-06 · Admin: ngừng một thành viên
    ① Thành viên đang hoạt động (Active) ➜ ngừng ➜ IsActive() = false
    ② Lịch sử đăng ký của người đó vẫn được giữ


 IN4211 — Phát triển phần mềm hướng đối tượng                    ThS. Nguyễn Tuấn Kiệt   33 / 69
```

---

<a id="trang-34"></a>
## Trang 34/69

```text
3.6          3 vai trò (actor) của EduHub




                    🎓
              Sinh viên
                                                         🧑‍💼
                                                     Ban CLB
                                                                                  🛠️
                                                                               Admin
           US-01 → US-03                           US-04 → US-05                 US-06
   tham gia CLB, đăng ký, check-in              tạo sự kiện, xem báo cáo   quản lý thành viên



    Bài tập: tự viết ít nhất 5 story, đủ 3 vai trò. Đừng chép story mẫu!




 IN4211 — Phát triển phần mềm hướng đối tượng                                ThS. Nguyễn Tuấn Kiệt   34 / 69
```

---

<a id="trang-35"></a>
## Trang 35/69

```text
TRƯỜNG ĐẠI HỌC ĐỒNG THÁP
                                                                 IN4211 · Chương 1
Khoa Công nghệ và Kỹ thuật




 4
                             PHẦN 4


                             1.4 · Tư duy mô hình hoá lớp
                               Từ User Story tìm ra class
                               Sơ đồ lớp (class diagram) sơ bộ
                               Quan hệ và khoá ngoại
    PHẦN 4 / 6
                               Từ sơ đồ đến code C#
```

---

<a id="trang-36"></a>
## Trang 36/69

```text
4.1         Từ User Story tìm ra Entity



 Danh từ trong các story:

      Sinh viên                       CLB       sự kiện      phiếu đăng ký         điểm danh




      Member                         Club       Event         Registration           CheckIn

 Mỗi danh từ chính thành một entity (class).


                          Tiêu đề và sức chứa cũng là danh từ trong story. Vì sao chúng
   ACTIVE RECALL
                          không thành entity riêng?



IN4211 — Phát triển phần mềm hướng đối tượng                             ThS. Nguyễn Tuấn Kiệt   36 / 69
```

---

<a id="trang-37"></a>
## Trang 37/69

```text
4.2          Từ yêu cầu đến code — 6 bước




            Đọc yêu cầu                             Viết User Story          Tìm Entity
     1                                          2                        3
            bài toán EduHub                         ai cần làm gì            gạch chân danh từ




            Vẽ sơ đồ lớp                            Viết class C#            Chạy demo
     4                                          5                        6
            class diagram sơ bộ                     viết class bằng C#       chạy thử 7 bước




 IN4211 — Phát triển phần mềm hướng đối tượng                                ThS. Nguyễn Tuấn Kiệt   37 / 69
```

---

<a id="trang-38"></a>
## Trang 38/69

```text
4.3          5 Entity — thuộc tính & hành vi (1)



    👤 Member — thành viên
    Thuộc tính: Id, Name, Email, StudentCode, JoinedAt, Status
    Hành vi (method): Create() , IsActive() , Deactivate()

    🏛️ Club — câu lạc bộ
    Thuộc tính: Id, Name, Description, CreatedAt, Members
    Hành vi (method): AddMember() (chặn trùng), MemberCount()

    📅 Event — sự kiện
    Thuộc tính: Id, ClubId (khoá ngoại), Title, Date, Capacity, IsOnline
    Hành vi (method): HasCapacity() — còn chỗ không?


 IN4211 — Phát triển phần mềm hướng đối tượng                   ThS. Nguyễn Tuấn Kiệt   38 / 69
```

---

<a id="trang-39"></a>
## Trang 39/69

```text
4.4          5 Entity — thuộc tính & hành vi (2)



    📋 Registration — phiếu đăng ký
    Thuộc tính: Id, MemberId, EventId, RegisteredAt, Status
    Hành vi (method): Confirm() , Cancel() — đổi trạng thái theo vòng đời

    ✅ CheckIn — điểm danh
    Thuộc tính: Id, RegistrationId, CheckedInAt, Method
    Hành vi (method): Create() (chỉ khi Confirmed), Summary()

    Quy ước: private set (chỉ class tự sửa) · constructor private (không cho new
    từ ngoài) · tạo qua Create()



 IN4211 — Phát triển phần mềm hướng đối tượng                   ThS. Nguyễn Tuấn Kiệt   39 / 69
```

---

<a id="trang-40"></a>
## Trang 40/69

```text
4.5          Sơ đồ lớp sơ bộ (class diagram)


                 Club                                          Event                     Cách đọc bội số
   Id, Name, Description
                                          1     * Id, ClubId, Title, Date                1 = đúng một
   CreatedAt, Members                              Capacity, IsOnline                    * = nhiều
                                                                                         0..1 = không hoặc một
   AddMember(), MemberCount()                      HasCapacity()

                       *                                            1

                       *                                            *
              Member                                      Registration                           CheckIn
   Id, Name, Email, StudentCode
                                          1     * Id, MemberId, EventId        1 0..1
                                                                                         Id, RegistrationId
   JoinedAt, Status                                RegisteredAt, Status                  CheckedInAt, Method

   IsActive(), Deactivate()                        Confirm(), Cancel()                   Summary()


                                         Hình 1.2. Sơ đồ lớp sơ bộ của EduHub (tự vẽ).



 IN4211 — Phát triển phần mềm hướng đối tượng                                                ThS. Nguyễn Tuấn Kiệt   40 / 69
```

---

<a id="trang-41"></a>
## Trang 41/69

```text
4.6          Quan hệ và khoá ngoại (FK)


   QUAN HỆ                                      LOẠI       KHOÁ NGOẠI (FK)


   Member — Club                                *—*        bảng trung gian ClubMember (làm ở Ch04)

   Club — Event                                 1—*        Event.ClubId

   Member — Registration                        1—*        Registration.MemberId

   Event — Registration                         1—*        Registration.EventId

   Registration — CheckIn                       1 — 0..1   CheckIn.RegistrationId


 Khoá chính (PK) = mã riêng của mỗi entity: Id kiểu Guid (chuỗi mã ngẫu
 nhiên, không trùng).

 IN4211 — Phát triển phần mềm hướng đối tượng                                       ThS. Nguyễn Tuấn Kiệt   41 / 69
```

---

<a id="trang-42"></a>
## Trang 42/69

```text
4.7          Code Member — thuộc tính & constructor



   public class Member
   {
       public Guid Id { get; private set; }
       public string Name { get; private set; }
       public string Email { get; private set; }
       public string StudentCode { get; private set; } // mã số sinh viên
       public DateTime JoinedAt { get; private set; }
       public MemberStatus Status { get; private set; }
   }


 Mỗi dòng là một thuộc tính (property). private set = chỉ trong class mới
 được sửa giá trị.


 IN4211 — Phát triển phần mềm hướng đối tượng                  ThS. Nguyễn Tuấn Kiệt   42 / 69
```

---

<a id="trang-43"></a>
## Trang 43/69

```text
4.8          Vì sao constructor (hàm khởi tạo) là private?




       new Member(...)
                                                bị chặn
                                                                        🔒 constructor private

    Member.Create(...)                               kiểm tra dữ liệu            Member hợp lệ          ✅

 Chỉ có một cửa vào: Create() . Nó kiểm tra trước khi tạo, nên Member sai
 dữ liệu không thể xuất hiện.



 IN4211 — Phát triển phần mềm hướng đối tượng                                  ThS. Nguyễn Tuấn Kiệt   43 / 69
```

---

<a id="trang-44"></a>
## Trang 44/69

```text
4.9          Code Member — factory Create()


   public static Member Create(
       string name, string email, string studentCode)
   {
       if (string.IsNullOrWhiteSpace(name))   // tên không được trố ng
           throw new ArgumentException("Tên trống");
       if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
           throw new ArgumentException("Email sai");
       // ... kiểm tra mã số sinh viên tương tự ...
       return new Member(name.Trim(),
           email.Trim().ToLowerInvariant(), studentCode.Trim());
   }


 Factory = hàm “nhà máy”: kiểm tra rồi mới tạo object (đối tượng). throw =
 báo lỗi và dừng.

 IN4211 — Phát triển phần mềm hướng đối tượng                       ThS. Nguyễn Tuấn Kiệt   44 / 69
```

---

<a id="trang-45"></a>
## Trang 45/69

```text
4.10         Code Club — AddMember()



   public void AddMember(Member member)
   {
       ArgumentNullException.ThrowIfNull(member);    // không được null
       if (_members.Any(m => m.Id == member.Id))     // trùng Id?
              throw new InvalidOperationException(
                  $"{member} đã là thành viên");
          _members.Add(member);
   }

   public int MemberCount() => _members.Count;


 Muốn thêm thành viên phải đi qua AddMember() .


 IN4211 — Phát triển phần mềm hướng đối tượng                   ThS. Nguyễn Tuấn Kiệt   45 / 69
```

---

<a id="trang-46"></a>
## Trang 46/69

```text
4.11         Code Event — Create() & HasCapacity()



   public static Event Create(Guid clubId, string title,
       DateTime date, int capacity, bool isOnline = false)
   {
       if (string.IsNullOrWhiteSpace(title))   // tiêu đề không được trố ng
           throw new ArgumentException("Tiêu đề trống");
       if (capacity <= 0)   // sức chứa phải lớn hơn 0
           throw new ArgumentOutOfRangeException(nameof(capacity));
       return new Event(clubId, title.Trim(), date, capacity, isOnline);
   }

   public bool HasCapacity(int registeredCount) =>
       registeredCount < Capacity;    // còn chỗ nế u chưa đủ




 IN4211 — Phát triển phần mềm hướng đối tượng                       ThS. Nguyễn Tuấn Kiệt   46 / 69
```

---

<a id="trang-47"></a>
## Trang 47/69

```text
4.12         Code Registration — Confirm()




   public void Confirm()
   {
       if (Status != RegistrationStatus.Pending)
           throw new InvalidOperationException(
               $"Không thể xác nhận ({Status})");
       Status = RegistrationStatus.Confirmed;
   }

   public void Cancel() { … }                   // cho phép khi Pending hoặc Confirmed


 Chỉ phiếu Pending mới được xác nhận.



 IN4211 — Phát triển phần mềm hướng đối tượng                                   ThS. Nguyễn Tuấn Kiệt   47 / 69
```

---

<a id="trang-48"></a>
## Trang 48/69

```text
4.13         Code CheckIn — Create()



   public static CheckIn Create(
       Registration registration,
       string method = CheckInMethod.Manual)
   {
       ArgumentNullException.ThrowIfNull(registration);
       if (registration.Status != RegistrationStatus.Confirmed)
           throw new InvalidOperationException(
               "Chỉ phiếu Confirmed mới check-in");
       return new CheckIn(registration.Id, method);
   }


 Chưa xác nhận thì chưa được check-in.


 IN4211 — Phát triển phần mềm hướng đối tượng                     ThS. Nguyễn Tuấn Kiệt   48 / 69
```

---

<a id="trang-49"></a>
## Trang 49/69

```text
4.14         Vòng đời của Registration




       Pending                   Confirm()          Confirmed       CheckIn.Create()
                                                                                            CheckIn            ✅
      chờ xác nhận                                   đã xác nhận                             đã điểm danh



      Cancel()                                           Cancel()


                                       Cancelled
                                       trạng thái cuối




 IN4211 — Phát triển phần mềm hướng đối tượng                                          ThS. Nguyễn Tuấn Kiệt   49 / 69
```

---

<a id="trang-50"></a>
## Trang 50/69

```text
4.15         Console demo — 7 bước




                                                Thêm 3           Tạo                Đăng ký
     1    Tạo CLB                       2                    3                4
                                                thành viên       sự kiện            (Pending)




          Xác nhận                              Check-in         Báo cáo
    5                                   6                    7
          (Confirmed)                           qua QR           tham dự




 IN4211 — Phát triển phần mềm hướng đối tượng                              ThS. Nguyễn Tuấn Kiệt   50 / 69
```

---

<a id="trang-51"></a>
## Trang 51/69

```text
TRƯỜNG ĐẠI HỌC ĐỒNG THÁP
                                                                         IN4211 · Chương 1
Khoa Công nghệ và Kỹ thuật




  5
                             PHẦN 5


                             1.5 · Git và GitHub cơ bản
                               Git và GitHub: bốn khu vực của một repo
                               Clone, branch, commit, push
                               Pull Request
    PHẦN 5 / 6
                               Quy ước commit message (Conventional Commits)
```

---

<a id="trang-52"></a>
## Trang 52/69

```text
5.1         Git và GitHub: bốn khu vực của một repo




    Thư mục              git add          Vùng chờ git commit Kho cục bộ git push                     GitHub
      làm việc                             (staging)                (local repo)                     (remote)
    bạn sửa file                        chọn file sẽ lưu            lịch sử commit                 kho trên mạng




                                   git clone (lần đầu) · git pull (cập nhật về máy)

                                Hình 1.3. Luồng đi của code từ máy bạn lên GitHub (tự vẽ).

Git lưu lịch sử thay đổi trên máy bạn. GitHub là nơi lưu repo trên mạng để
làm việc nhóm và nộp bài.

IN4211 — Phát triển phần mềm hướng đối tượng                                             ThS. Nguyễn Tuấn Kiệt   52 / 69
```

---

<a id="trang-53"></a>
## Trang 53/69

```text
5.2            Quy trình làm việc với repo




           1                      2                   3                 4                 5                      6

       Clone                Tạo nhánh             Commit              Push          Pull Request              Merge
     git clone            git switch -c          git commit         git push         trên GitHub           sau review




                                         Hình 1.4. Sáu bước từ clone đến merge (tự vẽ).


    ACTIVE RECALL          Vì sao làm việc trên nhánh riêng thay vì sửa thẳng main ?




 IN4211 — Phát triển phần mềm hướng đối tượng                                                 ThS. Nguyễn Tuấn Kiệt   53 / 69
```

---

<a id="trang-54"></a>
## Trang 54/69

```text
5.3          Các lệnh Git cơ bản



   # 1. Lấ y repo về máy (làm một lần)
   git clone https://github.com/<tài-khoản>/eduhub.git
   # 2. Tạo nhánh riêng cho bài tập
   git switch -c ch01/DH24001
   # 3. Sửa code, chọn file rồi lưu thành commit
   git add .
   git commit -m "feat(domain): add Member entity"
   # 4. Đẩy nhánh lên GitHub
   git push -u origin ch01/DH24001


 Kiểm tra: git status (đang thay đổi gì), git log (lịch sử).


 IN4211 — Phát triển phần mềm hướng đối tượng              ThS. Nguyễn Tuấn Kiệt   54 / 69
```

---

<a id="trang-55"></a>
## Trang 55/69

```text
5.4          Branch — nhánh làm việc riêng




 main

                                                                                                              merge
                                                                                               Pull Request


                                                nhánh ch01/DH24001 (commit 1, 2, 3)

                                  Hình 1.5. Nhánh tách từ main rồi gộp lại bằng PR (tự vẽ).

      main luôn là bản ổn định; mỗi bài tập hoặc tính năng làm trên một nhánh riêng
     Gộp nhánh về main bằng Pull Request, không sửa thẳng vào main



 IN4211 — Phát triển phần mềm hướng đối tượng                                                 ThS. Nguyễn Tuấn Kiệt   55 / 69
```

---

<a id="trang-56"></a>
## Trang 56/69

```text
5.5          Pull Request — đề nghị gộp code



    Pull request #1                                                                                            Open

    feat(domain): add EduHub domain classes
    ch01/DH24001 ➜ main

       Mô tả (description)                                                             Reviewers
       What: thêm 5 class domain của EduHub                                            Giảng viên
       Why: hoàn thành bài tập Ch01 (HĐ1.3)                                            Commits
       How to test: chạy dotnet run, xem báo cáo                                       3 commit

                                  Hình 1.6. Minh hoạ trang Pull Request trên GitHub (tự vẽ).

 PR cho giảng viên đọc và góp ý trước khi gộp vào main . Mô tả nêu what,
 why, how to test.

 IN4211 — Phát triển phần mềm hướng đối tượng                                                  ThS. Nguyễn Tuấn Kiệt   56 / 69
```

---

<a id="trang-57"></a>
## Trang 57/69

```text
5.6          Quy ước commit message



   type(scope): subject        # Conventional Commits
   feat(domain): add Member.Create with validation

   TYPE                     DÙNG KHI

   feat                     thêm tính năng mới
   fix                      sửa lỗi
   docs                     chỉ sửa tài liệu (README, sơ đồ)
   refactor                 sắp xếp lại code, không đổi hành vi
   test · chore             thêm test · việc vặt (cấu hình, đổi tên file)

 Subject viết ngắn, thể mệnh lệnh, bằng tiếng Anh.

 IN4211 — Phát triển phần mềm hướng đối tượng                               ThS. Nguyễn Tuấn Kiệt   57 / 69
```

---

<a id="trang-58"></a>
## Trang 58/69

```text
5.7          Commit message tốt và chưa tốt




    ❌ update , fix bug , final final            ➜   ✅ fix(club): reject duplicates
    ❌ Một commit chứa cả bài, nộp               ➜
                                                    ✅ Mỗi tính năng một commit,
    phút chót                                       commit dần

    ❌ Pull Request không có mô tả               ➜   ✅ Mô tả đủ what, why, how to test


 IN4211 — Phát triển phần mềm hướng đối tượng                        ThS. Nguyễn Tuấn Kiệt   58 / 69
```

---

<a id="trang-59"></a>
## Trang 59/69

```text
5.8          Thực hành: Pull Request đầu tiên




    1       Tạo repo eduhub trên GitHub và clone về máy


   2        Tạo nhánh ch01/<MSSV>


   3        Thêm README.md giới thiệu bản thân, commit theo quy ước


   4        Push nhánh lên GitHub


   5        Mở Pull Request về main , tag giảng viên



 IN4211 — Phát triển phần mềm hướng đối tượng                 ThS. Nguyễn Tuấn Kiệt   59 / 69
```

---

<a id="trang-60"></a>
## Trang 60/69

```text
TRƯỜNG ĐẠI HỌC ĐỒNG THÁP
                                                                       IN4211 · Chương 1
Khoa Công nghệ và Kỹ thuật




                             PHẦN 6


                             Bài tập & tổng kết
                               Bài tập Ch01 — Phân tích yêu cầu và Domain
                               Modeling EduHub
                               Cách nộp bài và lỗi thường gặp
                               Demo đáp án mẫu
    PHẦN 6 / 6
                               Tổng kết và câu hỏi tự kiểm tra
```

---

<a id="trang-61"></a>
## Trang 61/69

```text
Bài tập Ch01 — 100 điểm




            1                           2           3               4                       5
    User Stories                  Sơ đồ lớp    Domain classes   Console demo           Git và PR
       20 điểm                      15 điểm       35 điểm         20 điểm               10 điểm



Bài tập Ch01 — Phân tích yêu cầu và Domain Modeling EduHub. Chấm
theo HĐ1.3 (bài tập chương), liên quan CLO1, CLO4 và CLO5.




IN4211 — Phát triển phần mềm hướng đối tượng                                ThS. Nguyễn Tuấn Kiệt   61 / 69
```

---

<a id="trang-62"></a>
## Trang 62/69

```text
Yêu cầu từng nhiệm vụ



    1 · User Stories — ít nhất 5 story, mỗi story có ít nhất 2 tiêu chí nghiệm thu, đủ 3
    vai trò
    2 · Sơ đồ lớp — 5 class với thuộc tính, quan hệ và khoá ngoại; vẽ bằng Mermaid
    hoặc draw.io
    3 · Domain classes — private set , constructor private, Create() , có kiểm
    tra dữ liệu
    4 · Console demo — Program.cs chạy đủ luồng nghiệp vụ và in báo cáo
    tham dự
    5 · Git và PR — ít nhất 3 commit theo Conventional Commits, Pull Request
    có mô tả



IN4211 — Phát triển phần mềm hướng đối tượng                        ThS. Nguyễn Tuấn Kiệt   62 / 69
```

---

<a id="trang-63"></a>
## Trang 63/69

```text
Cách nộp bài




🌿 Làm trên nhánh riêng ch01/<MSSV> của repo eduhub
📝 Ít nhất 3 commit, message theo Conventional Commits
📬 Mở Pull Request về main , tag giảng viên, mô tả đủ what, why, how
to test
▶️ dotnet run chạy không lỗi; README có ảnh chụp kết quả
   Đề và rubric chi tiết: 02_Projects/ch01/ · Bài tập là thành quả cá nhân.




IN4211 — Phát triển phần mềm hướng đối tượng                    ThS. Nguyễn Tuấn Kiệt   63 / 69
```

---

<a id="trang-64"></a>
## Trang 64/69

```text
Lỗi thường gặp




   ❌ Mọi thuộc tính để public set              ➜   ✅ private set + method hành vi
   ❌ Thiếu khoá ngoại ( Event không            ➜
                                                   ✅ Vẽ sơ đồ lớp trước; phía “nhiều”
   có ClubId )                                     giữ FK

   ❌ List<Member> public, ai cũng              ➜   ✅ IReadOnlyList + AddMember()
   thêm/xoá được

   ❌ Chuỗi "Pending" rải khắp nơi              ➜   ✅ Dùng hằng số hoặc enum

IN4211 — Phát triển phần mềm hướng đối tượng                         ThS. Nguyễn Tuấn Kiệt   64 / 69
```

---

<a id="trang-65"></a>
## Trang 65/69

```text
Demo (1/2) — Chạy đáp án mẫu


  # Mở thư mục đáp án
  cd 02_Projects/ch01/solution/EduHub.Ch01
  # Chạy chương trình
  dotnet run


    Code nằm trong Domain/ : 5 file, mỗi file một entity
     Program.cs chạy 7 bước như slide trước, thêm bước 8: thử vi phạm luật
    nghiệp vụ

              Vì sao tạo đối tượng bằng Club.Create(...) mà không dùng new
   HỎI SV
              Club() ?


IN4211 — Phát triển phần mềm hướng đối tượng                    ThS. Nguyễn Tuấn Kiệt   65 / 69
```

---

<a id="trang-66"></a>
## Trang 66/69

```text
Demo (2/2) — Quy tắc nghiệp vụ



  // Phiế u đã huỷ thì không thể xác nhận lại
  registrations[1].Cancel();
  try { registrations[1].Confirm(); }      // thử xác nhận lại
  catch (InvalidOperationException ex)     // bị báo lỗi thì vào đây
  {
      Console.WriteLine(ex.Message);          // in lời báo lỗi
  }


  Không thể xác nhận phiếu đang ở trạng thái Cancelled.


   HỎI SV     Quy tắc này nên nằm ở Registration hay ở Program.cs ? Vì sao?


IN4211 — Phát triển phần mềm hướng đối tượng                     ThS. Nguyễn Tuấn Kiệt   66 / 69
```

---

<a id="trang-67"></a>
## Trang 67/69

```text
Tổng kết Chương 1




    .NET 10 LTS + VS Code / Rider: cài và chạy được chương trình đầu tiên
    OOP: đóng gói, kế thừa, đa hình, interface; học cách áp dụng, không học thuộc
    EduHub: User Story ➜ class ➜ sơ đồ lớp ➜ code C# ( Create() , private set )
    Git/GitHub: clone, branch, commit, push, Pull Request; commit theo
    Conventional Commits




IN4211 — Phát triển phần mềm hướng đối tượng                   ThS. Nguyễn Tuấn Kiệt   67 / 69
```

---

<a id="trang-68"></a>
## Trang 68/69

```text
Câu hỏi tự kiểm tra



  ✔ CHECKPOINT — CHƯƠNG 1

 1. Lệnh nào tạo project console mới và lệnh nào chạy nó?

2. Vẽ lại sơ đồ lớp của EduHub từ trí nhớ: 5 class và quan hệ.

3. Viết class Member có 4 thuộc tính. Kiểm tra Email đặt ở đâu?

4. Nêu thứ tự các bước từ clone đến Pull Request.

5. Viết commit message đúng quy ước khi thêm HasCapacity() .



IN4211 — Phát triển phần mềm hướng đối tượng             ThS. Nguyễn Tuấn Kiệt   68 / 69
```

---

<a id="trang-69"></a>
## Trang 69/69

```text
Chuẩn bị cho Chương 2 (tuần 3–4)




🧱 Chương 2: 5 nguyên lý SOLID, các Design Pattern (Factory, Decorator,
Strategy, Observer), unit test đầu tiên
🌿 Git nâng cao: rebase, xử lý conflict, code review trên Pull Request
📖 Đọc tài liệu [5] Design Patterns (GoF) và [6] GitHub Skills
💻 Hoàn thiện bài tập Ch01 và nộp Pull Request đúng hạn


IN4211 — Phát triển phần mềm hướng đối tượng              ThS. Nguyễn Tuấn Kiệt   69 / 69
```

---
