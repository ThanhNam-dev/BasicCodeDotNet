# Dự án mẫu

## 1. Hoạt động trong dự án

### Sử dụng GitBash (GitSCM) hoặc Source Tree để Clone dự án về

1. Mở thư mục bạn muốn lưu code.

2. Sử dụng lệnh sau để lấy code về:

```
git clone https://github.com/ICTUDA/udastudents
```

3. Chạy code SQL bên trong:

4. Thay đổi code trong Appsetting.json bao gồm Server và Database (Nếu có sự thay đổi):

```
"ConnectionStrings": {
  "ConnectionString": "Server=.;Database=BaseCode;Trusted_Connection=True;TrustServerCertificate=True;"
},
```
### Hướng dẫn

1. Database First.

```
Scaffold-DbContext "Server=.;Database=BaseCode;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities
```
