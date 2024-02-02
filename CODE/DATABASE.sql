CREATE DATABASE RESTAURANT_MANAGEMENT;
USE RESTAURANT_MANAGEMENT;

create table ADMIN(
	ad_id int primary key,
	ad_name varchar(30) not null,
	ad_gender int not null,
	ad_phone char(10) check (LEN(ad_phone) = 10),	
);
drop table ADMIN;

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
	dc_desc text ,   
	dc_name varchar (50),
	ca_id int ,foreign key (ca_id) references CATEGORY(ca_id)

);
drop table DETAIL_CATEGORY;

CREATE table MENU_ITEM(
	 mi_id int primary key ,
	 mi_price money ,
	 mi_name varchar (50) ,
	 dc_id int,
	 rb_id int,
	 foreign key (rb_id) references RESTAURANT_BRANCH(rb_id),
	 foreign key (dc_id) references DETAIL_CATEGORY(dc_id),
);

CREATE TABLE BILL_DETAIL(
	bi_id int, 
	mi_id int,
	quantity int not null,
	primary key(bi_id, mi_id),
	foreign key (bi_id) references BILL(bi_id),
	foreign key (mi_id) references MENU_ITEM(mi_id)
);

INSERT INTO ADMIN (ad_id, ad_name, ad_gender, ad_phone) VALUES
(1, 'Nguyễn Văn A', 1, '0987654321'),
(2, 'Trần Thị B', 0, '0912345678'),
(3, 'Lê Văn C', 1, '0965432189'),
(4, 'Phạm Thị D', 0, '0934567890'),
(5, 'Đỗ Quang E', 1, '0978123456');

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
(1, 'Nhà hàng A', '123 Trần Hưng Đạo, Quận 1, TP. Hồ Chí Minh', '02812345678'),
(2, 'Nhà hàng B', '456 Nguyễn Trãi, Quận 5, TP. Hồ Chí Minh', '02887654321'),
(3, 'Nhà hàng C', '789 Lê Duẩn, Quận 3, TP. Hồ Chí Minh', '02813572468'),
(4, 'Nhà hàng D', '147 Phan Đình Phùng, Quận Phú Nhuận, TP. Hồ Chí Minh', '02824681357'),
(5, 'Nhà hàng E', '258 Nguyễn Văn Cừ, Quận 10, TP. Hồ Chí Minh', '02836981472');

INSERT INTO USERS (u_id, ro_id, rb_id, u_cccd, u_name, u_dob, u_gender, u_address, u_phone) VALUES
(1, 1, 1, '123456789012', 'Nguyễn Văn A', '1990-01-01', 'M', '123 Trần Hưng Đạo, Quận 1, TP. Hồ Chí Minh', '0987654321'),
(2, 2, 1, '234567890123', 'Trần Thị B', '1991-02-02', 'F', '456 Nguyễn Trãi, Quận 5, TP. Hồ Chí Minh', '0912345678'),
(3, 3, 1, '345678901234', 'Lê Văn C', '1992-03-03', 'M', '789 Lê Duẩn, Quận 3, TP. Hồ Chí Minh', '0965432189'),
(4, 4, 1, '456789012345', 'Phạm Thị D', '1993-04-04', 'F', '147 Phan Đình Phùng, Quận Phú Nhuận, TP. Hồ Chí Minh', '0934567890'),
(5, 5, 1, '567890123456', 'Đỗ Quang E', '1994-05-05', 'M', '258 Nguyễn Văn Cừ, Quận 10, TP. Hồ Chí Minh', '0978123456');

INSERT INTO MANAGES_EMPLOYER (ad_id, u_id) VALUES
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
(1, 'Gỏi cuốn tôm thịt', 'Gỏi cuốn', 1),
(2, 'Chả giò rế', 'Chả giò', 1),
(3, 'Bánh xèo miền Trung', 'Bánh xèo', 1),
(4, 'Bún bò Huế', 'Bún bò', 2),
(5, 'Phở bò tái', 'Phở bò', 2),
(6, 'Cơm tấm sườn ốp la', 'Cơm tấm', 2),
(7, 'Chè thái', 'Chè', 3),
(8, 'Kem flan', 'Kem', 3),
(9, 'Bánh flan', 'Bánh', 3),
(10, 'Nước cam ép', 'Nước cam', 4),
(11, 'Nước chanh dây', 'Nước chanh', 4),
(12, 'Bia Hà Nội', 'Bia', 4);

INSERT INTO MENU_ITEM (mi_id, mi_price, mi_name, dc_id, rb_id) VALUES
(1, 20000, 'Gỏi cuốn tôm thịt', 1, 1),
(2, 25000, 'Chả giò rế', 2, 1),
(3, 30000, 'Bánh xèo miền Trung', 3, 1),
(4, 40000, 'Bún bò Huế', 4, 1),
(5, 35000, 'Phở bò tái', 5, 1),
(6, 50000, 'Cơm tấm sườn',6,1),
(7, 45000, 'Cơm tấm bì chả', 6, 1),
(8, 30000, 'Chè thái', 7, 1),
(9, 25000, 'Kem flan', 8, 1),
(10, 20000, 'Bánh flan', 9, 1),
(11, 15000, 'Nước cam ép', 10, 1),
(12, 10000, 'Nước chanh dây', 11, 1),
(13, 20000, 'Bia Hà Nội', 12, 1);

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