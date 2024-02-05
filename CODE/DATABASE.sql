CREATE DATABASE RESTAURANT_MANAGEMENT;
USE RESTAURANT_MANAGEMENT;

drop table ADMIN;
drop table ROLE;
drop table CATEGORY;
drop table RESTAURANT_BRANCH;
drop table USERS;
drop table MANAGES_EMPLOYER;
drop table MANAGES_BRANCH;
drop table USERS;
drop table BILL;
drop table DETAIL_CATEGORY;
drop table MENU_ITEM;
drop table BILL_DETAIL;





create table ADMIN(
	ad_id int primary key,
	ad_name varchar(30) not null,
	ad_gender int not null,	
	ad_phone char(10) check (LEN(ad_phone) = 10),
	ad_password varchar(20) not null check (len(ad_password) between 6 and 16)
);


create table ROLE(
	ro_id int primary key,
	ro_name varchar(30) not null,
	ro_salary Money not null
);

create table CATEGORY(
	ca_id int primary key,
	ca_name varchar(50) not null,
	ca_desc varchar(50)
);

CREATE TABLE RESTAURANT_BRANCH (
   rb_id INT PRIMARY KEY,
   rb_name VARCHAR(255),
   rb_address VARCHAR(255),
   rb_phone  VARCHAR (15) not null
);

CREATE TABLE USERS (
    u_id INT PRIMARY KEY,
    ro_id INT,
	rb_id int,
	u_cccd char(12) not null unique,
    u_name VARCHAR(50) not null,
    u_dob DATE,
    u_gender CHAR(1),
    u_address VARCHAR(255),
    u_phone VARCHAR(15) not null,
    u_password varchar(20) not null check (len(u_password) between 6 and 16)
	FOREIGN KEY (ro_id) REFERENCES ROLE(ro_id),
	FOREIGN KEY (rb_id) REFERENCES RESTAURANT_BRANCH(rb_id)
);
drop table USERS;

CREATE TABLE MANAGES_EMPLOYER (
	ad_id INT, 
	u_id INT, 
	FOREIGN KEY (ad_id) REFERENCES ADMIN(ad_id), 
	FOREIGN KEY (u_id) REFERENCES USERS(u_Id)
);

CREATE TABLE MANAGES_BRANCH (
	ad_id INT, 
	rb_id INT, 
	FOREIGN KEY (ad_id) REFERENCES ADMIN(ad_id), 
	FOREIGN KEY (rb_id) REFERENCES RESTAURANT_BRANCH(rb_id)
);

CREATE TABLE CUSTOMER (
	cus_id INT PRIMARY KEY, 
	cus_name varchar (50),   
	cus_phone varchar (15) not null,  
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
	dc_name varchar (50),
	ca_id int ,foreign key (ca_id) references CATEGORY(ca_id)

);
drop table DETAIL_CATEGORY;

CREATE table MENU_ITEM(
	 mi_id int primary key ,
	 mi_price money ,
	 mi_name varchar (50) ,
	 mi_desc text,
	 dc_id int,
	 constraint fk1 foreign key (dc_id) references DETAIL_CATEGORY(dc_id),
);




drop  table MENU_ITEM;

CREATE TABLE BILL_DETAIL(
	bi_id int, 
	mi_id int,
	quantity int not null,
	primary key(bi_id, mi_id),
	foreign key (bi_id) references BILL(bi_id),
	foreign key (mi_id) references MENU_ITEM(mi_id)
);

INSERT INTO ADMIN (ad_id, ad_name, ad_gender, ad_phone, ad_password)
VALUES 
    (1, 'Hồ Minh Nhựt', 0, '0783939975', 'admin123'), -- 0 represents male
    (2, 'La Thanh Trọng', 0, '9876543210', 'admin456'); -- 1 represents female
	--delete from admin where ad_id=2;


INSERT INTO ROLE (ro_id, ro_name, ro_salary) VALUES
(1, 'Quản lý', 20000000),
(2, 'Nhân viên', 10000000),
(3, 'Bếp trưởng', 15000000),
(4, 'Phụ bếp', 8000000),
(5, 'Phục vụ', 7000000);

INSERT INTO CATEGORY (ca_id, ca_name, ca_desc) VALUES
	(1, 'Món khai vị', 'Những món ăn nhẹ để bắt đầu bữa ăn'),
	(2, 'Món chính', 'Những món ăn chủ yếu để no bụng'),
	(3, 'Món tráng miệng', 'Những món ăn ngọt để kết thúc bữa ăn'),
	(4, 'Đồ uống', 'Những loại nước giải khát hoặc rượu');

INSERT INTO RESTAURANT_BRANCH (rb_id, rb_name, rb_address, rb_phone) VALUES
(1, 'Nhà hàng A', '123 Đường 30/4, Q. Ninh Kiều, TP. Cần Thơ', '0123456789'),
(2, 'Nhà hàng B', '456 Nguyễn Văn Cừ, Q. Bình Thủy, TP. Cần Thơ', '0987654321'),
(3, 'Nhà hàng C', '789 Lê Hồng Phong, Q. Cái Răng, TP. Cần Thơ', '0123456789'),
(4, 'Nhà hàng D', '147 Phan Đình Phùng, Q. O Môn, TP. Cần Thơ', '0987654321'),
(5, 'Nhà hàng E', '258A Nguyễn Văn Linh, Q. Ninh Kiều, TP. Cần Thơ', '0123456789');


INSERT INTO USERS (u_id, ro_id, rb_id, u_cccd, u_name, u_dob, u_gender, u_address, u_phone, u_password) VALUES
(1, 1, 1, '123456789012', 'Nguyễn Văn A', '1990-01-01', 'M', '123 Trần Hưng Đạo, Quận 1, TP. Hồ Chí Minh', '0987654321', 'password123'),
(2, 2, 1, '234567890123', 'Trần Thị B', '1991-02-02', 'F', '456 Nguyễn Trãi, Quận 5, TP. Hồ Chí Minh', '0912345678', 'pass456word'),
(3, 3, 1, '345678901234', 'Lê Văn C', '1992-03-03', 'M', '789 Lê Duẩn, Quận 3, TP. Hồ Chí Minh', '0965432189', 'securepass'),
(4, 4, 1, '456789012345', 'Phạm Thị D', '1993-04-04', 'F', '147 Phan Đình Phùng, Quận Phú Nhuận, TP. Hồ Chí Minh', '0934567890', 'admin@123'),
(5, 5, 1, '567890123456', 'Đỗ Quang E', '1994-05-05', 'M', '258 Nguyễn Văn Cừ, Quận 10, TP. Hồ Chí Minh', '0978123456', 'userpass123');

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
(1, 'Hoàng Thị F', '0987-123-456', 10, 100000),
(2, 'Nguyễn Văn G', '0912-654-321', 20, 200000),
(3, 'Trần Thị H', '0965-345-678', 30, 300000),
(4, 'Lê Văn I', '0934-432-189', 40, 400000),
(5, 'Phạm Thị K', '0978-567-890', 50, 500000);

INSERT INTO BILL (bi_id, bi_date, bi_time, cus_id) VALUES
(1, '2024-02-01', '12:00:00', 1),
(2, '2024-02-01', '12:30:00', 2),
(3, '2024-02-01', '13:00:00', 3),
(4, '2024-02-01', '13:30:00', 4),
(5, '2024-02-01', '14:00:00', 5);

INSERT INTO DETAIL_CATEGORY (dc_id, dc_desc, dc_name, ca_id) VALUES
(1, 'Các loại bánh ngọt, bánh mặn', 'Món Bánh', 2),
(2, 'Các món hủ tiếu, bún....', 'Món nước', 2),
(3, 'Cơm các loại', 'Cơm', 2),
(4, 'Các loại thịt, hải sản', 'Đồ nướng', 2),
(5, 'Lẩu các loại', 'Lẩu', 2),
(6, 'Sữa chua', 'Sữa chua', 3),
(7, 'Trái cây theo mùa', 'Trái cây', 3),
(8, 'Pepsi, coca....', 'Nước uống có gas', 4),
(9, 'Trà sữa', 'Trà sữa', 4),
(10, 'Nước cam ép, ....', 'Nước trái cây', 4);


INSERT INTO MENU_ITEM (mi_id, mi_price, mi_name, mi_desc, dc_id) VALUES
(1, 50000, 'Bánh mì pate', 'Bánh mì ăn kèm pate và rau sống', 1),
(2, 35000, 'Bún riêu', 'Bún nước dùng riêu cay nồng', 2),
(3, 60000, 'Cơm gà xối mỡ', 'Cơm gà ăn kèm xối mỡ thơm ngon', 3),
(4, 80000, 'Sò điệp nướng mỡ hành', 'Sò điệp nướng mỡ hành ngon tuyệt', 4),
(5, 50000, 'Lẩu canh chua cá', 'Lẩu canh chua cá hấp dẫn', 5),
(6, 15000, 'Sữa chua đào', 'Sữa chua ăn kèm đào tươi', 6),
(7, 25000, 'Trái cây hỗn hợp', 'Hỗn hợp trái cây tươi ngon', 7),
(8, 10000, 'Pepsi', 'Đồ uống có gas - Pepsi', 8),
(9, 20000, 'Trà sữa matcha', 'Trà sữa thơm ngon vị matcha', 9),
(10, 30000, 'Nước cam ép', 'Nước trái cây tươi ngon', 10);
INSERT INTO MENU_ITEM (mi_id, mi_price, mi_name, mi_desc, dc_id) VALUES
(11, 45000, 'Bánh tráng trộn', 'Bánh tráng trộn ăn kèm gia vị', 1),
(12, 28000, 'Phở bò', 'Phở bò nấu chín với nước dùng đậm đà', 2),
(13, 55000, 'Cơm chiên hải sản', 'Cơm chiên hải sản hấp dẫn', 3),
(14, 75000, 'Mực nước dừa xanh', 'Mực nước dừa xanh nướng mỡ hành', 4),
(15, 48000, 'Lẩu thái', 'Lẩu thái nồng ấm', 5),
(16, 18000, 'Sữa chua dâu', 'Sữa chua ăn kèm dâu tươi', 6),
(17, 22000, 'Trái cây tươi', 'Hỗn hợp trái cây tươi ngon', 7),
(18, 12000, 'Coca Cola', 'Đồ uống có gas - Coca Cola', 8),
(19, 21000, 'Trà sữa hòa quyện', 'Trà sữa hòa quyện vị thơm', 9),
(20, 32000, 'Nước lựu tươi', 'Nước trái cây lựu tươi ngon', 10);

select * from menu_item;


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

commit;