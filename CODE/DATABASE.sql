﻿
Create login admin with password='admin', CHECK_POLICY = OFF;


--DROP DATABASE RESTAURANT_MANAGEMENT;
CREATE DATABASE RESTAURANT_MANAGEMENT;
USE RESTAURANT_MANAGEMENT;

sp_changedbowner admin; 

/*DROP TABLE BILL_DETAIL;
DROP TABLE MENU_ITEM;
DROP TABLE DETAIL_CATEGORY;
DROP TABLE BILL;
DROP TABLE CUSTOMER;
DROP TABLE ASSIGN;
DROP TABLE USERS;
DROP TABLE TABLES;
DROP TABLE RESTAURANT_BRANCH;
DROP TABLE CATEGORY;
DROP TABLE ROLE; */

-- role table
create table ROLE(
	id int primary key,
	role_name nvarchar(30) not null,
	salary Money not null
);

-- branch table
CREATE TABLE RESTAURANT_BRANCH (
   id INT PRIMARY KEY,
   name NVARCHAR(255) not null,
   address NVARCHAR(255) not null,
   phone NVARCHAR (15) not null
);

-- users table
CREATE TABLE USERS (
    id INT PRIMARY KEY,
    role_id INT,
	cccd char(12) not null unique,
    name NVARCHAR(50) not null,
    dob DATE,
    gender CHAR(1),
    address NVARCHAR(255),
    phone NVARCHAR(15) not null,
    password nvarchar(20) not null check (len(password) between 6 and 16)
	FOREIGN KEY (role_id) REFERENCES ROLE(id) ON UPDATE CASCADE ON DELETE CASCADE,
);

CREATE TABLE ASSIGN (
    u_id INT,
    branch_id INT,
    PRIMARY KEY (u_id, branch_id),
    UNIQUE (u_id), -- Ensures that a user can be assigned to only one branch
    FOREIGN KEY (u_id) REFERENCES USERS(id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (branch_id) REFERENCES RESTAURANT_BRANCH(id) ON UPDATE CASCADE ON DELETE CASCADE
);

-- category table
create table CATEGORY(
	id int primary key,
	name nvarchar(50) not null,
	describe nvarchar(50) default N'this is delicous'
);

-- category table
CREATE table DETAIL_CATEGORY(
	id int primary key , 
	name nvarchar (50) not null,
	describe nvarchar (50),
	category_id int ,
	foreign key (category_id) references CATEGORY(id)
);

-- customer table
CREATE TABLE CUSTOMER (
	id INT PRIMARY KEY, 
	name nvarchar (50),   
	phone nvarchar (15) not null,  
	point int,  
	accumulated int
); 

-- tables table
CREATE TABLE TABLES(
	id int primary key,
	display_name nvarchar(10) not null,
	branch_id int,
	status int default 0, --0: empty; 1: full
	foreign key (branch_id) references RESTAURANT_BRANCH (id)  ON UPDATE CASCADE ON DELETE CASCADE)

-- menu item table
CREATE table MENU_ITEM(
	 id int primary key ,
	 price money not null,
	 name nvarchar (50) ,
	 describe nvarchar (255),
	 img nvarchar (255),
	 UNIQUE (img),
	 category_id int,
	 constraint fk1 foreign key (category_id) references DETAIL_CATEGORY(id) ON UPDATE CASCADE ON DELETE CASCADE,
);


-- bill table
CREATE TABLE BILL(
	id int primary key ,  
	checkin_date date not null,   
	total money not null,
	table_id int not null,
	status int not null, --o:not paid, 1: paid
	customer_id int ,
	foreign key(customer_id ) references CUSTOMER(id),
	foreign key (table_id) references TABLES(id)
);


--bill information
CREATE TABLE BILL_DETAIL(
	id int primary key, 
	bill_id int,
	item_id int,
	quantity int not null,
	foreign key (bill_id) references BILL(id) ON UPDATE CASCADE ON DELETE CASCADE,
	foreign key (item_id) references MENU_ITEM(id) ON UPDATE CASCADE ON DELETE CASCADE

);

INSERT INTO ROLE (id, role_name, salary) VALUES
(0, N'Admin', 30000000),
(1, N'Quản lý', 20000000),
(2, N'Nhân viên', 10000000),
(3, N'Bếp trưởng', 15000000),
(4, N'Phụ bếp', 8000000),
(5, N'Phục vụ', 7000000);


INSERT INTO CATEGORY (id, name, describe) VALUES
  (1, N'Món khai vị', N'Những món ăn nhẹ để bắt đầu bữa ăn'),
  (2, N'Món chính', N'Những món ăn chủ yếu để no bụng'),
  (3, N'Món tráng miệng', N'Những món ăn ngọt để kết thúc bữa ăn'),
  (4, N'Đồ uống', N'Những loại nước giải khát hoặc rượu');


INSERT INTO RESTAURANT_BRANCH (id, name, address, phone) VALUES
(1, N'Nhà hàng A', N'123 Đường 30/4, Q. Ninh Kiều, TP. Cần Thơ', N'0123456789'),
(2, N'Nhà hàng B', N'456 Nguyễn Văn Cừ, Q. Bình Thủy, TP. Cần Thơ', N'0987654321'),
(3, N'Nhà hàng C', N'789 Lê Hồng Phong, Q. Cái Răng, TP. Cần Thơ', N'0123456789'),
(4, N'Nhà hàng D', N'147 Phan Đình Phùng, Q. O Môn, TP. Cần Thơ', N'0987654321'),
(5, N'Nhà hàng E', N'258A Nguyễn Văn Linh, Q. Ninh Kiều, TP. Cần Thơ', N'0123456789');


INSERT INTO USERS (id, role_id, cccd, name, dob, gender, address, phone, password) VALUES
(1, 1, N'123456789012', N'Nguyễn Văn A', '1990-01-01', N'M', N'123 Trần Hưng Đạo, Quận 1, TP. Hồ Chí Minh', N'0987654321', N'password123'),
(2, 2, N'234567890123', N'Trần Thị B', '1991-02-02', N'F', N'456 Nguyễn Trãi, Quận 5, TP. Hồ Chí Minh', N'0912345678', N'pass456word'),
(3, 3, N'345678901234', N'Lê Văn C', '1992-03-03', N'M', N'789 Lê Duẩn, Quận 3, TP. Hồ Chí Minh', N'0965432189', N'securepass'),
(4, 4, N'456789012345', N'Phạm Thị D', '1993-04-04', N'F', N'147 Phan Đình Phùng, Quận Phú Nhuận, TP. Hồ Chí Minh', N'0934567890', N'admin@123'),
(5, 5, N'567890123456', N'Đỗ Quang E', '1994-05-05', N'M', N'258 Nguyễn Văn Cừ, Quận 10, TP. Hồ Chí Minh', N'0978123456', N'userpass123'),
(6, 0, N'9876543210', N'Hồ Minh Nhựt', '2002-06-05', N'M', N'632, tổ 7, khu vực/ấp Mỹ Khánh 2, Xã Mỹ Hòa', N'0783939975', N'admin123'),
(7, 0, N'0123456789', N'La Thanh Trọng', '2002-04-09', N'M', N'21, Trần Hưng Đạo, khu vực/ấp 1, Phường An Cư', N'0901248021', N'admin456');




INSERT INTO ASSIGN (u_id, branch_id) VALUES
(1,1),
(2,2),
(3,2),
(4,1),
(5,3);
select branch_id from assgin where u_id=@u_id
select branch_id from ASSIGN where u_id=1;
-- get branch id proc 
drop proc getBranchID;
create proc getBranchID 
	@user_id int
AS
BEGIN
	select branch_id from ASSIGN where u_id=@user_id;
END

EXEC getBranchID @user_id=1;


-- procedure get table with branch id
create proc getTableWithBranch
	@branch_id int
AS
BEGIN
	Select * from TABLES where branch_id=@branch_id;
END
GO
EXEC getTableWithBranch @branch_id = 1;

INSERT INTO CUSTOMER (id, name, phone, point, accumulated) VALUES
(1, N'Hoàng Thị F', N'0987-123-456', 10, 100000),
(2, N'Nguyễn Văn G', N'0912-654-321', 20, 200000),
(3, N'Trần Thị H', N'0965-345-678', 30, 300000),
(4, N'Lê Văn I', N'0934-432-189', 40, 400000),
(5, N'Phạm Thị K', N'0978-567-890', 50, 500000);


INSERT INTO TABLES(id, display_name, branch_id) VALUES
(1,'A1', 1),
(2,'A2', 1),
(3,'A3', 1),
(4,'A4', 1),
(5,'A5', 1),
(6,'A6', 1),
(7,'A7', 1),
(8,'A8', 1),
(9,'A9', 1),
(10,'A10', 1);
Update TABLES set status=1 where id =17;
declare @i int =1
while @i<=10
begin 
	insert into TABLES(id, display_name, branch_id) values (@i+20, 'C'+CAST( @i as char), 3);
	set @i = @i+1
end
INSERT INTO TABLES(id, display_name, branch_id) VALUES
(31,'D1', 3),
(32,'D2', 3);
select * from TABLES;



INSERT INTO BILL (id, checkin_date, table_id, status, total, customer_id) VALUES
(1, '2024-02-01', 1, 0, 500000, 1),
(2, '2024-02-01',  2, 1, 800000, 2);


INSERT INTO DETAIL_CATEGORY (id, describe, name, category_id) VALUES
(1, N'Các loại bánh ngọt, bánh mặn', N'Món Bánh', 2),
(2, N'Các món hủ tiếu, bún....', N'Món nước', 2),
(3, N'Cơm các loại', N'Cơm', 2),
(4, N'Các loại thịt, hải sản', N'Đồ nướng', 2),
(5, N'Lẩu các loại', N'Lẩu', 2),
(6, N'Sữa chua', N'Sữa chua', 3),
(7, N'Trái cây theo mùa', N'Trái cây', 3),
(8, N'Pepsi, coca....', N'Nước uống có gas', 4),
(9, N'Trà sữa', N'Trà sữa', 4),
(10, N'Nước cam ép, ....', N'Nước trái cây', 4);


INSERT INTO MENU_ITEM (id, price, name, describe, category_id, img) VALUES
(1, 50000, N'Bánh mì pate', N'Bánh mì ăn kèm pate và rau sống', 1, 'food.png'),
(2, 35000, N'Bún riêu', N'Bún nước dùng riêu cay nồng', 2, 'food1.png'),
(3, 60000, N'Cơm gà xối mỡ', N'Cơm gà ăn kèm xối mỡ thơm ngon', 3, 'food2.png'),
(4, 80000, N'Sò điệp nướng mỡ hành', N'Sò điệp nướng mỡ hành ngon tuyệt', 4, 'food3.png'),
(5, 50000, N'Lẩu canh chua cá', N'Lẩu canh chua cá hấp dẫn', 5, 'food4.png'),
(6, 15000, N'Sữa chua đào', N'Sữa chua ăn kèm đào tươi', 6, 'food5.png'),
(7, 25000, N'Trái cây hỗn hợp', N'Hỗn hợp trái cây tươi ngon', 7, 'food6.png'),
(8, 10000, N'Pepsi', N'Đồ uống có gas - Pepsi', 8, 'food7.png'),
(9, 20000, N'Trà sữa matcha', N'Trà sữa thơm ngon vị matcha', 9, 'food8.png'),
(10, 30000, N'Nước cam ép', N'Nước trái cây tươi ngon', 10, 'food9.png'),
(11, 45000, N'Bánh tráng trộn', N'Bánh tráng trộn ăn kèm gia vị', 1, 'food10.png'),
(12, 28000, N'Phở bò', N'Phở bò nấu chín với nước dùng đậm đà', 2, 'food11.png'),
(13, 55000, N'Cơm chiên hải sản', N'Cơm chiên hải sản hấp dẫn', 3, 'food12.png'),
(14, 75000, N'Mực nước dừa xanh', N'Mực nước dừa xanh nướng mỡ hành', 4, 'food13.png'),
(15, 48000, N'Lẩu thái', N'Lẩu thái nồng ấm', 5, 'food14.png'),
(16, 18000, N'Sữa chua dâu', N'Sữa chua ăn kèm dâu tươi', 6, 'food15.png'),
(17, 22000, N'Trái cây tươi', N'Hỗn hợp trái cây tươi ngon', 7, 'food16.png'),
(18, 12000, N'Coca Cola', N'Đồ uống có gas - Coca Cola', 8, 'food17.png'),
(19, 21000, N'Trà sữa hòa quyện', N'Trà sữa hòa quyện vị thơm', 9, 'food18.png'),
(20, 32000, N'Nước lựu tươi', N'Nước trái cây lựu tươi ngon', 10, 'food19.png');


-- Insert sample data into BILL_DETAIL table
INSERT INTO BILL_DETAIL (id, bill_id, item_id, quantity)
VALUES
(1, 1, 1, 2),  -- Bill 1 contains 2 Bánh mì pate
(2, 1, 3, 1),  -- Bill 1 contains 1 Cơm gà xối mỡ
(3, 2, 2, 3),  -- Bill 2 contains 3 Bún riêu
(4, 2, 5, 2);  -- Bill 2 contains 2 Lẩu canh chua cá
 

DELETE FROM BILL_DETAIL;
DELETE FROM MENU_ITEM;
DELETE FROM DETAIL_CATEGORY;
DELETE FROM BILL;
DELETE FROM CUSTOMER;
DELETE FROM USERS;
DELETE FROM RESTAURANT_BRANCH;
DELETE FROM CATEGORY;
DELETE FROM ROLE;
