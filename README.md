# Introduction

Simplify Restaurant Management App Using Winform.

## Contribution
- [Hồ Minh Nhựt](https://github.com/Kaito0506)
- [Diễm Mee](https://github.com/minhify)
- [Lê Minh Mẫn](https://github.com/LeMinhMan2809)
- [Nguyễn Duy Khang](https://github.com/Gilliash)
- [La Thanh Trọng](https://github.com/LaThanhTrong)

# Setup .env file
Create .env file in CODE/RESTAURANT_MANAGEMENT
```bash
HOST=<Server name>
DATABASE=<Database name>
USER=root
PASSWORD=root
```

# Having trouble with Database Connection
- Make sure that 4 properties in .env file is correct.
- Make sure that owner is correct (sp_changedbowner root;)
- Go to Server properties -> Security -> Select SQL Server and Windows Authentication mode -> Restart SQL Server Services.

