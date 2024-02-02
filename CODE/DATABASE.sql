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
	ro_salary Money not null);

create table CATEGORY(
	ca_id int primary key,
	ca_name varchar(50) not null,
	ca_desc varchar(50));



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


  CREATE table CATEGORY(
 ca_id int primary key ,
 ca_name varchar (50)
 );



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