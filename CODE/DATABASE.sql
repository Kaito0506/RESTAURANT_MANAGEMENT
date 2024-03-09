
Create login admin with password='admin', CHECK_POLICY = OFF;


--DROP DATABASE RESTAURANT_MANAGEMENT;
CREATE DATABASE RESTAURANT_MANAGEMENT;
	

sp_changedbowner admin; 

DROP TABLE BILL_DETAIL;
DROP TABLE MENU_ITEM;
DROP TABLE DETAIL_CATEGORY;
DROP TABLE BILL;
DROP TABLE ASSIGN;
DROP TABLE USERS;
DROP TABLE TABLES;
DROP TABLE RESTAURANT_BRANCH;
DROP TABLE CATEGORY;
DROP TABLE ROLE; 

-- role table
CREATE TABLE ROLE (
    id INT IDENTITY(0,1),
    role_name NVARCHAR(30) NOT NULL,
    salary MONEY NOT NULL,
	 PRIMARY KEY(id)
);

-- branch table
CREATE TABLE RESTAURANT_BRANCH (
   id INT PRIMARY KEY IDENTITY(1,1),
   name NVARCHAR(255) not null,
   address NVARCHAR(255) not null,
   phone NVARCHAR (15) not null
);

-- users table
CREATE TABLE USERS (
    id INT PRIMARY KEY IDENTITY(1,1),
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
    u_id INT ,
    branch_id INT,
    PRIMARY KEY (u_id, branch_id),
    UNIQUE (u_id), -- Ensures that a user can be assigned to only one branch
    FOREIGN KEY (u_id) REFERENCES USERS(id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (branch_id) REFERENCES RESTAURANT_BRANCH(id) ON UPDATE CASCADE ON DELETE CASCADE
);

-- category table
create table CATEGORY(
	id int primary key IDENTITY(1,1),
	name nvarchar(50) not null,
	describe nvarchar(50) default N'this is delicous'
);

-- category table
CREATE table DETAIL_CATEGORY(
	id int primary key IDENTITY(1,1), 
	name nvarchar (50) not null,
	describe nvarchar (50),
	category_id int ,
	foreign key (category_id) references CATEGORY(id)
);


-- tables table
CREATE TABLE TABLES(
	id int primary key IDENTITY(1,1),
	display_name nvarchar(10) not null,
	branch_id int,
	status int default 0, --0: empty; 1: full
	foreign key (branch_id) references RESTAURANT_BRANCH (id)  ON UPDATE CASCADE ON DELETE CASCADE)

-- menu item table-- id not change
CREATE table MENU_ITEM(
	 id int primary key,
	 price money not null,
	 name nvarchar (50) ,
	 describe nvarchar (255),
	 img nvarchar (255),
	 category_id int,
	 constraint fk1 foreign key (category_id) references DETAIL_CATEGORY(id) ON UPDATE CASCADE ON DELETE CASCADE,
);

-- bill table
CREATE TABLE BILL(
	id int primary key IDENTITY(1,1),  
	checkin_date date not null,   
	total money not null,
	table_id int , -- ì table_id ==0, take way bill
	status int not null, --o:not paid, 1: paid
	foreign key (table_id) references TABLES(id) on delete cascade on update cascade
);


--bill information
CREATE TABLE BILL_DETAIL(
	id int primary key IDENTITY(1,1), 
	bill_id int,
	item_id int,
	quantity int not null,
	foreign key (bill_id) references BILL(id) ON UPDATE CASCADE ON DELETE CASCADE,
	foreign key (item_id) references MENU_ITEM(id) ON UPDATE CASCADE ON DELETE CASCADE
);

------------------------------------------------------------
INSERT INTO ROLE (role_name, salary) VALUES
(N'Admin', 30000000),
(N'Quản lý', 20000000),
(N'Nhân viên', 10000000),
(N'Bếp trưởng', 15000000),
(N'Phụ bếp', 8000000),
(N'Phục vụ', 7000000);

------------------------------------------------------------
INSERT INTO CATEGORY (name, describe) VALUES
(N'Món khai vị', N'Những món ăn nhẹ để bắt đầu bữa ăn'),
(N'Món chính', N'Những món ăn chủ yếu để no bụng'),
(N'Món tráng miệng', N'Những món ăn ngọt để kết thúc bữa ăn'),
(N'Đồ uống', N'Những loại nước giải khát hoặc rượu');

------------------------------------------------------------
INSERT INTO RESTAURANT_BRANCH (name, address, phone) VALUES
(N'Nhà hàng A', N'123 Đường 30/4, Q. Ninh Kiều, TP. Cần Thơ', N'0123456789'),
(N'Nhà hàng B', N'456 Nguyễn Văn Cừ, Q. Bình Thủy, TP. Cần Thơ', N'0987654321'),
(N'Nhà hàng C', N'789 Lê Hồng Phong, Q. Cái Răng, TP. Cần Thơ', N'0123456789'),
(N'Nhà hàng D', N'147 Phan Đình Phùng, Q. O Môn, TP. Cần Thơ', N'0987654321'),
(N'Nhà hàng E', N'258A Nguyễn Văn Linh, Q. Ninh Kiều, TP. Cần Thơ', N'0123456789');

------------------------------------------------------------
INSERT INTO USERS (role_id, cccd, name, dob, gender, address, phone, password) VALUES
(1, N'123456789012', N'Nguyễn Văn A', '1990-01-01', N'M', N'123 Trần Hưng Đạo, Quận 1, TP. Hồ Chí Minh', N'0987654321', N'password123'),
(2, N'234567890123', N'Trần Thị B', '1991-02-02', N'F', N'456 Nguyễn Trãi, Quận 5, TP. Hồ Chí Minh', N'0912345678', N'pass456word'),
(3, N'345678901234', N'Lê Văn C', '1992-03-03', N'M', N'789 Lê Duẩn, Quận 3, TP. Hồ Chí Minh', N'0965432189', N'securepass'),
(4, N'456789012345', N'Phạm Thị D', '1993-04-04', N'F', N'147 Phan Đình Phùng, Quận Phú Nhuận, TP. Hồ Chí Minh', N'0934567890', N'admin@123'),
(5, N'567890123456', N'Đỗ Quang E', '1994-05-05', N'M', N'258 Nguyễn Văn Cừ, Quận 10, TP. Hồ Chí Minh', N'0978123456', N'userpass123'),
(0, N'9876543210', N'Hồ Minh Nhựt', '2002-06-05', N'M', N'632, tổ 7, khu vực/ấp Mỹ Khánh 2, Xã Mỹ Hòa', N'0783939975', N'admin123'),
(0, N'0123456789', N'La Thanh Trọng', '2002-04-09', N'M', N'21, Trần Hưng Đạo, khu vực/ấp 1, Phường An Cư', N'0901248021', N'admin456'),
(1, N'086202000614', N'Kaito', '2002-06-05', N'M', N'Vinh Long', N'0987654321', N'user123'),
(1, N'086202000615', N'Kaito2', '2002-06-05', N'M', N'Vinh Long', N'0123456789', N'user123'),
(0, N'0333144360', N'Diễm My', '2002-09-11', N'F', N'36/5a Khu vực Thạnh Mỹ, Phường Lê Bình, Quận Cái Răng, TP Cần Thơ', N'0333144360', N'mee123');

------------------------------------------------------------
INSERT INTO ASSIGN (u_id, branch_id) VALUES
(1,1),
(2,2),
(3,2),
(4,1),
(5,3),
(6,2),
(7,2),
(8,3),
(9,1),
(10,2);

------------------------------------------------------------------
delete from TABLES;
DECLARE @i INT = 1
WHILE @i <= 20
BEGIN 
    INSERT INTO TABLES (display_name, branch_id) 
    VALUES ('A' + CONVERT(VARCHAR(10), @i), 1),
			('B' + CONVERT(VARCHAR(10), @i), 2),
          ('C' + CONVERT(VARCHAR(10), @i),3);

    SET @i = @i + 1
END


--run 1 lne for 1 time, DONT UNCOMMENT 3 LINE in 1 time
------------------------------------------------------------
INSERT INTO DETAIL_CATEGORY (describe, name, category_id) VALUES
(N'Các loại bánh ngọt, bánh mặn', N'Món Bánh', 2),
(N'Các món hủ tiếu, bún....', N'Món nước', 2),
(N'Cơm các loại', N'Cơm', 2),
(N'Các loại thịt, hải sản', N'Đồ nướng', 2),
(N'Lẩu các loại', N'Lẩu', 2),
(N'Sữa chua', N'Sữa chua', 3),
(N'Trái cây theo mùa', N'Trái cây', 3),
(N'Pepsi, coca....', N'Nước uống có gas', 4),
(N'Trà sữa', N'Trà sữa', 4),
(N'Nước cam ép, ....', N'Nước trái cây', 4);

------------------------------------------------------------------------------------------------------------------------
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


------------------------------------------------------------------------------------------------------------------------
-- Insert sample data into BILL_DETAIL table
select * from tables;
DECLARE @today DATE = GETDATE();
INSERT INTO BILL (checkin_date, table_id, status, total) VALUES
('2024-02-01', 1, 0, 0),
('2024-02-01', 2, 1, 0),
('2024-02-02', 3, 0, 0),
('2024-02-03', 4, 1, 0),
('2024-02-04', 5, 0, 0),
('2024-02-05', 6, 1, 0),
('2024-02-06', 7, 0, 0),
(@today, 1, 1, 0), 
(@today, 2, 0, 0), 
(@today, 3, 1, 0), 
(@today, 4, 0, 0), 
(@today, 1, 1, 0), 
(@today, 2, 0, 0), 
(@today, 3, 1, 0), 
(@today, 4, 0, 0); 

-- set some bill unpaid to test function
UPDATE TABLES set status = 0;
DECLARE @count int = 1
while @count<=15
BEGIN
	UPDATE TABLES SET STATUS =1 where id=@count;
	SET @count = @count +2;
END
------------------------------------------------------------------------------------------------------------------------

INSERT INTO BILL_DETAIL (bill_id, item_id, quantity) 
VALUES
(1, 1, 2),  -- Bill 1 contains 2 Bánh mì pate
(1, 3, 1),  -- Bill 1 contains 1 Cơm gà xối mỡ
(2, 2, 3),  -- Bill 2 contains 3 Bún riêu
(2, 5, 2),  -- Bill 2 contains 2 Lẩu canh chua cá
(3, 7, 1),   -- Bill 3 contains 1 Trái cây hỗn hợp
(3, 9, 2),   -- Bill 3 contains 2 Trà sữa matcha
(4, 14, 3),  -- Bill 4 contains 3 Mực nước dừa xanh
(4, 17, 2),  -- Bill 4 contains 2 Trái cây tươi
(5, 3, 2),   -- Bill 5 contains 2 Cơm gà xối mỡ
(5, 6, 1),   -- Bill 5 contains 1 Sữa chua đào
(6, 11, 2),  -- Bill 6 contains 2 Phở bò
(6, 14, 1),  -- Bill 6 contains 1 Mực nước dừa xanh
(7, 19, 3),  -- Bill 7 contains 3 Trà sữa hòa quyện
(7, 20, 2),  -- Bill 7 contains 2 Nước lựu tươi
(8, 12, 2),  -- Bill 8 contains 2 Phở bò
(8, 17, 1),  -- Bill 8 contains 1 Trái cây tươi
(9, 8, 3),   -- Bill 9 contains 3 Pepsi
(9, 15, 2),  -- Bill 9 contains 2 Sữa chua dâu
(10, 4, 2),  -- Bill 10 contains 2 Sò điệp nướng mỡ hành
(10, 10, 1),  -- Bill 10 contains 1 Nước cam ép
(11, 6, 3),   -- Bill 11 contains 3 Sữa chua đào
(11, 13, 2),  -- Bill 11 contains 2 Cơm chiên hải sản
(12, 2, 2),   -- Bill 12 contains 2 Bún riêu
(12, 7, 1),   -- Bill 12 contains 1 Trái cây hỗn hợp
(13, 5, 1),   -- Bill 13 contains 1 Lẩu canh chua cá
(13, 9, 1),   -- Bill 13 contains 1 Trà sữa matcha
(14, 11, 3),  -- Bill 14 contains 3 Bánh tráng trộn
(14, 16, 2),  -- Bill 14 contains 2 Sữa chua dâu
(15, 14, 2),  -- Bill 15 contains 2 Mực nước dừa xanh
(15, 18, 1);  -- Bill 15 contains 1 Trà sữa hòa quyện

----------------------------------------------------------
--drop proc CalculateBillTotal;
CREATE PROC CalculateBillTotal 
	@b_id int
AS
BEGIN
	DECLARE @total int;

	SELECT @total = sum(quantity*price) from BILL_DETAIL as b join MENU_ITEM as m on b.item_id = m.id where bill_id=@b_id;
	
	Update BILL Set total=@total where id=@b_id;
END
GO

----------------------------------------------------------

-- UPDATE TOTAL FOR BILL
declare @c int = 1;
while @c<=15
begin 
	EXEC CalculateBillTotal @b_id=@c;
	set @c = @c +1;
end
------------------------------------------------------------------------------------------------------------------------

--drop proc getBranchID;
------------------------------------------------
---------------------------------------------------------------------------------
create proc getBranchID 
	@user_id int
AS
BEGIN
	select branch_id from ASSIGN where u_id=@user_id;
END

EXEC getBranchID @user_id=1;

---------------------------------------------------------------------------------
-- -----------procedure get table with branch id
create proc getTableWithBranch
	@branch_id int
AS
BEGIN
	Select * from TABLES where branch_id=@branch_id;
END
GO

EXEC getTableWithBranch @branch_id = 1;
------------------------------------------------------------------
---------------------------------------------------------------------------------
-- get branch name
CREATE PROCEDURE getBranchName
    @user_id INT
AS
BEGIN
    SELECT RESTAURANT_BRANCH.name  
    FROM ASSIGN
    JOIN RESTAURANT_BRANCH ON ASSIGN.branch_id = RESTAURANT_BRANCH.id
    WHERE ASSIGN.u_id = @user_id;
END
GO

EXEC getBranchName @user_id=8;


---------------------------------------------------------------------------------------------------------------------------
----proc PAY
CREATE PROC PAY
	@table_id int
AS
BEGIN
	DECLARE @bill_id int;
	IF (@table_id IS NOT NULL)
	BEGIN
		UPDATE TABLES SET status=0 WHERE id=@table_id;
		UPDATE BILL SET status=1 WHERE table_id=@table_id;
	END
	ELSE
	BEGIN
		SELECT @bill_id=id from	BILL where table_id is null and status=0;
		UPDATE BILL SET status=1 WHERE id = @bill_id;
	END
END
GO


--------------------------------------------------------------------------------------------------------------------------------------------------------------------
----------- pROC order
CREATE PROC ORDER_BILL
	@table_id int
AS
BEGIN
	INSERT INTO BILL(checkin_date, table_id, total, status) 
	VALUES(GETDATE(), @table_id, 0, 0);
	UPDATE TABLES SET status = 1 where id=@table_id;
END
GO

--------------------------------------------------------------------------------------------------------------------------------------------------------------------
----------- pROC add bill detail
CREATE PROC addBillDetail
	@bill_id int, @item_id int, @quantity int
AS
BEGIN
	DECLARE @isExist int;
	DECLARE @currentQuantity int;

	SELECT @isExist=id, @currentQuantity=quantity 
	FROM BILL_DETAIL 
	WHERE bill_id=@bill_id and item_id=@item_id;

	IF (@isExist > 0)
		BEGIN
			DECLARE @newQuantity int = @quantity + @currentQuantity;
			IF (@newQuantity > 0)
				BEGIN
						UPDATE BILL_DETAIL SET quantity=@newQuantity  where bill_id=@bill_id and item_id=@item_id;
				END
			ELSE
				BEGIN
						DELETE BILL_DETAIL where bill_id=@bill_id and item_id=@item_id;
				END
		END
		ELSE
			BEGIN
				INSERT INTO BILL_DETAIL(bill_id, item_id, quantity) VALUES (@bill_id, @item_id, @quantity);
			END
END
--------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROC getBillId
	@table_id int
AS
BEGIN
	if(@table_id is not null)
	BEGIN
		select * from BILL where status=0 and table_id=@table_id;
	END
	ELSE
	BEGIN
		select * from BILL where status=0 and table_id is null;
	END
END
--------------------------------------------------------------------------------------------------------------------------------------------------------------------
ALTER PROC changeTable
	@table1 int, @table2 int
AS BEGIN 
	DECLARE @bill1 int, @bill2 int;
	select @bill1 = id from BILL WHERE status=0 and table_id=@table1;
	select @bill2 = id from BILL WHERE status=0 and table_id=@table2;
	IF ( @bill1 is not null and @bill2 is null)
	BEGIN
		UPDATE BILL SET table_id=@table2 where id=@bill1;
		UPDATE TABLES SET status=1 WHERE id=@table2;
		UPDATE TABLES SET status=0 WHERE id=@table1;
	END
END
---------------------------RUN UNTIL THIS LINE BELOW ARE SELECT COMMANDS FOR TESTING------------------------------------------
--------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!--------------------
--------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!--------------------
--------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!--------------------------------

changeTable @table1=4, @table2=10;

SELECT id from	BILL where table_id is null and status=0;
EXEC ORDER_BILL @table_id=null;
select * from BILL
delete from bill where table_id IS NULL;
PAY @table_id=null;
select *from BILL;
delete from BILL;
getBillId @table_id=null;


update TABLES set status =0;
select * from BILL where status=0 and table_id is null;
EXEC addBillDetail @bill_id=57 , @item_id=5, @quantity=2;
CalculateBillTotal @b_id=57;



select * from bill where id =3;
select * from BILL_DETAIL where bill_id=3;
select *from MENU_ITEM;
select name, quantity, price from BILL_DETAIL as b join MENU_ITEM as m on b.item_id = m.id where bill_id=3;
select * from BILL_DETAIL as b join MENU_ITEM as m on b.id = m.id where bill_id=3;

SELECT sum(quantity*price) as total from BILL_DETAIL as b join MENU_ITEM as m on b.item_id = m.id where bill_id=7;
select * from BILL_DETAIL;
EXEC CalculateBillTotal @b_id=21;
---------------------------------------
select id 
from BILL 
where status=0 and table_id=1;
--------------------------------------------
select * from BILL_DETAIL where bill_id=1;
----------------------------------------------------------
select name, quantity, price from BILL_DETAIL as b join MENU_ITEM as m on b.id = m.id where bill_id=1;
------------------------
select sum(quantity*price) from BILL_DETAIL as b join MENU_ITEM as m on b.item_id = m.id where bill_id=1;
----------------------------------------------------------
select * from BILL where status=0 and table_id=1;
------------

select * from BILL where status=1;
select * from MENU_ITEM;
-- update BILL set status=0;
select * from TABLES;
select * from BILL;
SELECT * FROM MENU_ITEM WHERE id = 1;
SELECT * FROM CATEGORY c JOIN DETAIL_CATEGORY dc ON c.id = dc.category_id;
SELECT dc.id, dc.name as dc_name, dc.describe as dc_desc, dc.category_id, c.name as c_name, c.describe as c_desc FROM DETAIL_CATEGORY dc JOIN CATEGORY c on dc.category_id = c.id WHERE dc.category_id = 2;
SELECT * FROM DETAIL_CATEGORY;

----------------------------------------------------------
UPDATE TABLES
SET status = 1
FROM TABLES
JOIN BILL ON TABLES.id = BILL.table_id
WHERE BILL.status = 0;

select * from BILL where status=0 and table_id=8;
update BILL set status = 0;
---------------------------

select * from BILL where status=0 and table_id=11;
ORDER_BILL @table_id =11;


-------------------------------------
DELETE FROM BILL_DETAIL;
DELETE FROM MENU_ITEM;
DELETE FROM DETAIL_CATEGORY;
DELETE FROM BILL;
DELETE FROM USERS;
DELETE FROM RESTAURANT_BRANCH;
DELETE FROM CATEGORY;
DELETE FROM ROLE;
