# PhanMemHuongDoiTuong

Kho lưu trữ học phần **Phát triển phần mềm hướng đối tượng (IN4211)** — Khoa Công nghệ và Kỹ thuật, Trường Đại học Đồng Tháp.

* **Sinh viên thực hiện:** **Đoàn Minh Trí**
* **MSSV:** **0024417136**

Hệ sinh thái bài tập và đồ án xuyên suốt môn học: **EduHub** (Hệ thống quản lý Câu lạc bộ và Sự kiện Sinh viên) triển khai trên nền tảng **C# / .NET 10** (C# 13, Clean Architecture, SOLID, Design Patterns & xUnit Testing).

---

## 📂 Cấu trúc thư mục học phần

```text
PhanMemHuongDoiTuong/
├── GiaoTrinh/                         # Slide bài giảng và giáo trình lý thuyết
│   ├── IN4211-Ch01-Slide-Gioi-thieu-phan-mem-va-moi-truong.pdf
│   ├── IN4211_Chuong1_ToanBoNoiDung.md
│   ├── IN4211-ch02-solid-patterns-git.pdf
│   └── IN4211-ch03-clean-arch-api.pdf
├── ThucHanh/                          # Mã nguồn bài tập thực hành theo từng chương
│   ├── Chuong01_Domain_Modeling/      # Chương 1: Thiết kế Domain & Rich Domain Model
│   │   ├── starter/                   # Template khởi tạo (Ch01.Console)
│   │   ├── solution_mau/              # Mã nguồn chuẩn mẫu (EduHub.Ch01)
│   │   └── EduHub.Ch01_BaiLam/        # Bài làm thực hành hoàn chỉnh của sinh viên & xUnit Tests
│   └── Chuong02_SOLID_Patterns_Git/   # Chương 2: Nguyên lý SOLID, Design Patterns & Git
│       ├── starter/                   # Bài tập refactor (Ch02.Refactor & xUnit Tests)
│       └── solution/                  # Lời giải mẫu chuẩn (EduHub.Ch02 & Unit Tests)
├── baitap_ngay/                       # Bài tập tình huống, phân tích nghiệp vụ hàng ngày
│   ├── BaiTap_UserStory_EduHub.docx
│   └── BaiTap_Ch01_Domain_Modeling_EduHub.docx
├── BTL/                               # Bài tập lớn / Đồ án môn học chính thức (EduHub)
├── BTGK/                              # Đề cương và tài liệu ôn tập thi giữa kỳ
└── README.md
```

---

## 🚀 Hướng dẫn biên dịch và kiểm thử

### 1. Chương 1: Domain Modeling & Rich Domain Model
```bash
cd ThucHanh/Chuong01_Domain_Modeling
dotnet build ./EduHub.Ch01_BaiLam/EduHub.Ch01_BaiLam.slnx
dotnet test ./EduHub.Ch01_BaiLam/EduHub.Ch01_BaiLam.slnx
dotnet run --project ./EduHub.Ch01_BaiLam/EduHub.Ch01_BaiLam.csproj
```

### 2. Chương 2: SOLID & 4 Design Patterns
```bash
cd ThucHanh/Chuong02_SOLID_Patterns_Git/starter
dotnet build Ch02.Refactor.sln
dotnet test Ch02.Refactor.sln
dotnet run --project Ch02.Refactor/Ch02.Refactor.csproj
```
