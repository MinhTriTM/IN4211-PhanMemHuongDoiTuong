# Ch01 — Đáp án mẫu (dành cho giảng viên)

Bài tập Ch01 — Phân tích yêu cầu và Domain Modeling EduHub (HĐ1.3; CLO1, CLO4, CLO5).
Domain EduHub gồm 5 entity: `Member`, `Club`, `Event`, `Registration`, `CheckIn`.

```bash
cd EduHub.Ch01
dotnet build
dotnet run
```

Chương trình chạy 8 bước: tạo CLB, thêm 3 thành viên, tạo sự kiện, đăng ký, xác nhận, check-in, báo cáo tham dự,
rồi kiểm tra quy tắc nghiệp vụ (phiếu Cancelled không thể Confirm).

Tài liệu mẫu cho nhiệm vụ 1 và 2 nằm ở `EduHub.Ch01/docs/` (User Stories, sơ đồ lớp Mermaid).
