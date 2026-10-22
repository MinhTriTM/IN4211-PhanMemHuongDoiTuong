# Chương 02 — SOLID, Design Patterns và Git

Starter này giữ `Ch02.Refactor/ClubManager.cs` làm baseline God class để phân tích. `Ch02.Refactor/Program.cs` là composition root của bản refactor; nó minh họa Factory, Decorator, Strategy và Observer với repository in-memory.

Từ thư mục này, chạy:

```powershell
dotnet build Ch02.Refactor.sln --no-restore
dotnet test Ch02.Refactor.sln --no-restore --no-build
dotnet run --project Ch02.Refactor/Ch02.Refactor.csproj --no-build
```

Kết quả thực thi đã ghi tại [docs/ket-qua-chay.txt](docs/ket-qua-chay.txt); phân tích SOLID ở [docs/solid-analysis.md](docs/solid-analysis.md).

## Quy trình Git & Pull Request

Bài tập được thực hiện trên nhánh `feature/solid-refactor` theo chuẩn Conventional Commits, rebase lên `origin/main` và mở Pull Request kèm các nhận xét review đánh giá chất lượng mã nguồn.
