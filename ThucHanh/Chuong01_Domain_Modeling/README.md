# EduHub - Chương 1: Domain Modeling

Thư mục này là bài làm Chương 1 cho bài toán EduHub, được triển khai hoàn chỉnh bằng C# .NET 10 trong `EduHub.Ch01_BaiLam`.

## Cách chạy

Mở PowerShell tại thư mục `Chuong01_Domain_Modeling`, sau đó chạy:

```powershell
dotnet build .\EduHub.Ch01_BaiLam\EduHub.Ch01_BaiLam.slnx
dotnet test .\EduHub.Ch01_BaiLam\EduHub.Ch01_BaiLam.slnx
dotnet run --project .\EduHub.Ch01_BaiLam\EduHub.Ch01_BaiLam.csproj
```

`EduHub.Ch01_BaiLam.csproj` là project C# thực thi duy nhất. Project trùng nguồn `EduHub.Ch01.csproj` đã được loại bỏ để tránh hai assembly cùng biên dịch `Program.cs` và các lớp Domain.

Tài liệu bài làm ở `EduHub.Ch01_BaiLam/docs/`; kết quả các lệnh đã chạy thật được lưu trong `docs/ket-qua-chay.txt`.

Năm lớp Domain C# đều đóng gói trạng thái bằng `get; private set;`, có constructor `private` và factory `Create(...)` để kiểm tra dữ liệu trước khi tạo đối tượng.
