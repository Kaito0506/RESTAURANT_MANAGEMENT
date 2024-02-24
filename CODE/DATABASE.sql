DROP  LOGIN testLogin;
Create login admin with password='admin', CHECK_POLICY = OFF;
Create login testLogin with password='password', CHECK_POLICY = OFF;
-- DROP DATABASE RESTAURANT_MANAGEMENT;
CREATE DATABASE RESTAURANT_MANAGEMENT;
USE RESTAURANT_MANAGEMENT;

sp_changedbowner admin; 

DROP TABLE BILL_DETAIL;
DROP TABLE MENU_ITEM;
DROP TABLE DETAIL_CATEGORY;
DROP TABLE BILL;
DROP TABLE MANAGES_BRANCH;
DROP TABLE MANAGES_EMPLOYER;
DROP TABLE CUSTOMER;
DROP TABLE USERS;
DROP TABLE RESTAURANT_BRANCH;
DROP TABLE CATEGORY;
DROP TABLE ROLE;
DROP TABLE ADMIN;


create table ADMIN(
	ad_id int primary key,
	ad_name nvarchar(30) not null,
	ad_gender int not null,	
	ad_phone char(10) check (LEN(ad_phone) = 10),
	ad_password nvarchar(20) not null check (len(ad_password) between 6 and 16)
);


create table ROLE(
	ro_id int primary key,
	ro_name nvarchar(30) not null,
	ro_salary Money not null
);

create table CATEGORY(
	ca_id int primary key,
	ca_name nvarchar(50) not null,
	ca_desc nvarchar(50)
);

CREATE TABLE RESTAURANT_BRANCH (
   rb_id INT PRIMARY KEY,
   rb_name NVARCHAR(255),
   rb_address NVARCHAR(255),
   rb_phone NVARCHAR (15) not null
);

CREATE TABLE USERS (
    u_id INT PRIMARY KEY,
    ro_id INT,
	rb_id int,
	u_cccd char(12) not null unique,
    u_name NVARCHAR(50) not null,
    u_dob DATE,
    u_gender CHAR(1),
    u_address NVARCHAR(255),
    u_phone NVARCHAR(15) not null,
    u_password nvarchar(20) not null check (len(u_password) between 6 and 16)
	FOREIGN KEY (ro_id) REFERENCES ROLE(ro_id) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY (rb_id) REFERENCES RESTAURANT_BRANCH(rb_id) ON UPDATE CASCADE ON DELETE CASCADE
);


CREATE TABLE MANAGES_EMPLOYER (
	ad_id INT, 
	u_id INT, 
	FOREIGN KEY (ad_id) REFERENCES ADMIN(ad_id) ON UPDATE CASCADE ON DELETE CASCADE, 
	FOREIGN KEY (u_id) REFERENCES USERS(u_Id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE MANAGES_BRANCH (
	ad_id INT, 
	rb_id INT, 
	FOREIGN KEY (ad_id) REFERENCES ADMIN(ad_id) ON UPDATE CASCADE ON DELETE CASCADE, 
	FOREIGN KEY (rb_id) REFERENCES RESTAURANT_BRANCH(rb_id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE CUSTOMER (
	cus_id INT PRIMARY KEY, 
	cus_name nvarchar (50),   
	cus_phone nvarchar (15) not null,  
	cus_point int,  
	cus_accumulated int
); 


CREATE TABLE BILL(
	bi_id int primary key ,  
	bi_date date not null,   
	bi_time time not null,   
	cus_ID int ,
	foreign key(cus_id ) references CUSTOMER(cus_id )
);


CREATE table DETAIL_CATEGORY(
	dc_id int primary key , 
	dc_name nvarchar (50),
	dc_desc nvarchar (50),
	ca_id int ,foreign key (ca_id) references CATEGORY(ca_id)
);


CREATE table MENU_ITEM(
	 mi_id int primary key ,
	 mi_price money ,
	 mi_name nvarchar (50) ,
	 mi_desc text,
	 dc_id int,
	 constraint fk1 foreign key (dc_id) references DETAIL_CATEGORY(dc_id) ON UPDATE CASCADE ON DELETE CASCADE,
);


CREATE TABLE BILL_DETAIL(
	bi_id int, 
	mi_id int,
	quantity int not null,
	primary key(bi_id, mi_id),
	foreign key (bi_id) references BILL(bi_id) ON UPDATE CASCADE ON DELETE CASCADE,
	foreign key (mi_id) references MENU_ITEM(mi_id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE TABLES(
	ta_id int,
	rb_id int,
	primary key(ta_id, rb_id),
	foreign key (rb_id) references RESTAURANT_BRANCH (rb_id)  ON UPDATE CASCADE ON DELETE CASCADE)



INSERT INTO ADMIN (ad_id, ad_name, ad_gender, ad_phone, ad_password)
VALUES
  (1, N'Hồ Minh Nhựt', 0, N'0783939975', N'admin123'),
  (2, N'La Thanh Trọng', 0, N'9876543210', N'admin456'); 


INSERT INTO ROLE (ro_id, ro_name, ro_salary) VALUES
(1, N'Quản lý', 20000000),
(2, N'Nhân viên', 10000000),
(3, N'Bếp trưởng', 15000000),
(4, N'Phụ bếp', 8000000),
(5, N'Phục vụ', 7000000);


INSERT INTO CATEGORY (ca_id, ca_name, ca_desc) VALUES
  (1, N'Món khai vị', N'Những món ăn nhẹ để bắt đầu bữa ăn'),
  (2, N'Món chính', N'Những món ăn chủ yếu để no bụng'),
  (3, N'Món tráng miệng', N'Những món ăn ngọt để kết thúc bữa ăn'),
  (4, N'Đồ uống', N'Những loại nước giải khát hoặc rượu');


INSERT INTO RESTAURANT_BRANCH (rb_id, rb_name, rb_address, rb_phone) VALUES
(1, N'Nhà hàng A', N'123 Đường 30/4, Q. Ninh Kiều, TP. Cần Thơ', N'0123456789'),
(2, N'Nhà hàng B', N'456 Nguyễn Văn Cừ, Q. Bình Thủy, TP. Cần Thơ', N'0987654321'),
(3, N'Nhà hàng C', N'789 Lê Hồng Phong, Q. Cái Răng, TP. Cần Thơ', N'0123456789'),
(4, N'Nhà hàng D', N'147 Phan Đình Phùng, Q. O Môn, TP. Cần Thơ', N'0987654321'),
(5, N'Nhà hàng E', N'258A Nguyễn Văn Linh, Q. Ninh Kiều, TP. Cần Thơ', N'0123456789');


INSERT INTO USERS (u_id, ro_id, rb_id, u_cccd, u_name, u_dob, u_gender, u_address, u_phone, u_password) VALUES
(1, 1, 1, N'123456789012', N'Nguyễn Văn A', '1990-01-01', N'M', N'123 Trần Hưng Đạo, Quận 1, TP. Hồ Chí Minh', N'0987654321', N'password123'),
(2, 2, 1, N'234567890123', N'Trần Thị B', '1991-02-02', N'F', N'456 Nguyễn Trãi, Quận 5, TP. Hồ Chí Minh', N'0912345678', N'pass456word'),
(3, 3, 1, N'345678901234', N'Lê Văn C', '1992-03-03', N'M', N'789 Lê Duẩn, Quận 3, TP. Hồ Chí Minh', N'0965432189', N'securepass'),
(4, 4, 1, N'456789012345', N'Phạm Thị D', '1993-04-04', N'F', N'147 Phan Đình Phùng, Quận Phú Nhuận, TP. Hồ Chí Minh', N'0934567890', N'admin@123'),
(5, 5, 1, N'567890123456', N'Đỗ Quang E', '1994-05-05', N'M', N'258 Nguyễn Văn Cừ, Quận 10, TP. Hồ Chí Minh', N'0978123456', N'userpass123');

-- CHỗ này hơi dư cần xem lại-----------------------------
/* INSERT INTO MANAGES_EMPLOYER (ad_id, u_id) VALUES
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

INSERT INTO MANAGES_BRANCH(ad_id, rb_id) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5); 
*/
-----------------------------------------------------

INSERT INTO CUSTOMER (cus_id, cus_name, cus_phone, cus_point, cus_accumulated) VALUES
(1, N'Hoàng Thị F', N'0987-123-456', 10, 100000),
(2, N'Nguyễn Văn G', N'0912-654-321', 20, 200000),
(3, N'Trần Thị H', N'0965-345-678', 30, 300000),
(4, N'Lê Văn I', N'0934-432-189', 40, 400000),
(5, N'Phạm Thị K', N'0978-567-890', 50, 500000);


INSERT INTO BILL (bi_id, bi_date, bi_time, cus_id) VALUES
(1, '2024-02-01', '12:00:00', 1),
(2, '2024-02-01', '12:30:00', 2),
(3, '2024-02-01', '13:00:00', 3),
(4, '2024-02-01', '13:30:00', 4),
(5, '2024-02-01', '14:00:00', 5);


INSERT INTO DETAIL_CATEGORY (dc_id, dc_desc, dc_name, ca_id) VALUES
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


INSERT INTO MENU_ITEM (mi_id, mi_price, mi_name, mi_desc, dc_id) VALUES
(1, 50000, N'Bánh mì pate', N'Bánh mì ăn kèm pate và rau sống', 1),
(2, 35000, N'Bún riêu', N'Bún nước dùng riêu cay nồng', 2),
(3, 60000, N'Cơm gà xối mỡ', N'Cơm gà ăn kèm xối mỡ thơm ngon', 3),
(4, 80000, N'Sò điệp nướng mỡ hành', N'Sò điệp nướng mỡ hành ngon tuyệt', 4),
(5, 50000, N'Lẩu canh chua cá', N'Lẩu canh chua cá hấp dẫn', 5),
(6, 15000, N'Sữa chua đào', N'Sữa chua ăn kèm đào tươi', 6),
(7, 25000, N'Trái cây hỗn hợp', N'Hỗn hợp trái cây tươi ngon', 7),
(8, 10000, N'Pepsi', N'Đồ uống có gas - Pepsi', 8),
(9, 20000, N'Trà sữa matcha', N'Trà sữa thơm ngon vị matcha', 9),
(10, 30000, N'Nước cam ép', N'Nước trái cây tươi ngon', 10),
(11, 45000, N'Bánh tráng trộn', N'Bánh tráng trộn ăn kèm gia vị', 1),
(12, 28000, N'Phở bò', N'Phở bò nấu chín với nước dùng đậm đà', 2),
(13, 55000, N'Cơm chiên hải sản', N'Cơm chiên hải sản hấp dẫn', 3),
(14, 75000, N'Mực nước dừa xanh', N'Mực nước dừa xanh nướng mỡ hành', 4),
(15, 48000, N'Lẩu thái', N'Lẩu thái nồng ấm', 5),
(16, 18000, N'Sữa chua dâu', N'Sữa chua ăn kèm dâu tươi', 6),
(17, 22000, N'Trái cây tươi', N'Hỗn hợp trái cây tươi ngon', 7),
(18, 12000, N'Coca Cola', N'Đồ uống có gas - Coca Cola', 8),
(19, 21000, N'Trà sữa hòa quyện', N'Trà sữa hòa quyện vị thơm', 9),
(20, 32000, N'Nước lựu tươi', N'Nước trái cây lựu tươi ngon', 10);


INSERT INTO BILL_DETAIL (bi_id, mi_id, quantity) VALUES
(1, 1, 2),
(1, 4, 1), 
(2, 2, 3),
(2, 5, 1), 
(3, 3, 2),
(3, 6, 1), 
(4, 7, 1), 
(4, 10, 2), 
(5, 8, 1), 
(5, 11, 2); 


DELETE FROM BILL_DETAIL;
DELETE FROM MENU_ITEM;
DELETE FROM DETAIL_CATEGORY;
DELETE FROM BILL;
DELETE FROM CUSTOMER;
DELETE FROM MANAGES_BRANCH;
DELETE FROM MANAGES_EMPLOYER;
DELETE FROM USERS;
DELETE FROM RESTAURANT_BRANCH;
DELETE FROM CATEGORY;
DELETE FROM ROLE;
DELETE FROM ADMIN;
