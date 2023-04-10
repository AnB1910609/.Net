Create Database PetShop
Use PetShop

Create Table EmployeeTbl(
	EmpNum int Primary Key not null,
	EmpName nvarchar(50) Not Null,
	EmpAdd nvarchar(50) Not Null,
	EmpDOB date not null,
	EmpPhone nvarchar(50) not null,
	EmpPass nvarchar(20) not null
)

Create Table CustomerTbl(
	CustId int Primary Key not null,
	CustName nvarchar(50) Not Null,
	CustAdd nvarchar(100) Not Null,
	CustPhone nvarchar(50) not null,
)

Create Table ProductTbl(
	PrId int Primary Key not null,
	PrName nvarchar(50) Not Null,
	PrCat nvarchar(20) Not Null,
	PrQty int not null,
	PrPrice int not null
)

drop table 

Create Table BillTbl(
	BNum int Primary Key not null,
	BDate date Not Null,
	CustId int Not Null,
	CustName nvarchar(50) Not Null,
	EmpName nvarchar(50) Not Null,
	Amt int not null
)
select * from BillTbl;
select * from canbo;

INSERT INTO ChucVu (MaCV, TenCV) VALUES (1, 'Hieu truog');
INSERT INTO ChucVu (MaCV, TenCV) VALUES (2, 'Hieu pho');
INSERT INTO ChucVu (MaCV, TenCV) VALUES (3, 'Co van hoc tap');


DELETE FROM BillTbl
WHERE BNum = '3';

DELETE FROM CanBo
WHERE MaCB = '2';