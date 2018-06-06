go
CREATE DATABASE QLDH2
GO
USE QLDH2


GO
CREATE TABLE Customer
(
id CHAR(10) PRIMARY KEY,
name NVARCHAR(50),
address_ship NVARCHAR(50),
phone CHAR(11)


)




GO
CREATE TABLE Bill
(
id CHAR(10) PRIMARY KEY,
id_Cus CHAR(10) REFERENCES dbo.Customer(id),
date DATETIME,
total FLOAT,
trangthai BIT

)
GO
CREATE TABLE Color
(
id CHAR(10) PRIMARY KEY,
name NVARCHAR(10)

)
GO
CREATE TABLE Brand
(
id CHAR(10) PRIMARY KEY,
 name NVARCHAR(20)
)
GO
CREATE TABLE stype
(
	id CHAR(10) primary key,
	name CHAR(20)
)
GO
CREATE TABLE Direction
 (
 id CHAR(10) PRIMARY KEY,
name NVARCHAR(50),
address_ship NVARCHAR(50),
phone CHAR(11),
identification CHAR(11),
email VARCHAR(20),
bith DATETIME,
sex nchar(3) )


GO
INSERT dbo.Direction VALUES  ( 'QL001' , N'BÙI KHẮC TUẤN' ,N'NGHỆ AN' ,'0123456789' ,'12354656754' ,'TUAN@GMAIL.COM' ,'3-20-1996','Nam')
INSERT dbo.Direction VALUES  ( 'QL002' , N'LÊ THỊ HUYỀN' ,N'NGHỆ AN' ,'0123423789' ,'15324656754' ,'HUYEN@GMAIL.COM' ,'3-20-1996','Nữ')
INSERT dbo.Direction VALUES  ( 'QL003' , N'BÙI ĐĂNG CƯỜNG' ,N'BẮC GIANG' ,'0167456789' ,'89854656754' ,'CUONG@GMAIL.COM' ,'3-20-1996','Nam')
INSERT dbo.Direction VALUES  ( 'QL004' , N'VŨ NGỌC HÀ' ,N'HÀ NAM' ,'0187456789' ,'87654656754' ,'HA@GMAIL.COM' ,'3-20-1996','Nữ')
INSERT dbo.Direction VALUES  ( 'QL005' , N'ĐẶNG VĂN HÙNG' ,N'THÁI BÌNH' ,'0123123789' ,'12354321344' ,'HUNG@GMAIL.COM' ,'3-20-1996','Nam')

go
CREATE TABLE Product
(
id CHAR(10) PRIMARY KEY,
id_brand CHAR(10) REFERENCES dbo.Brand(id),
id_color CHAR(10) REFERENCES dbo.Color(id),
id_stype CHAR(10) REFERENCES dbo.Stype(id),
image VARCHAR(20),
info NVARCHAR(50),
price FLOAT,
name NVARCHAR(20),
id_Direction CHAR(10) REFERENCES  dbo.Direction(id)
)



GO
CREATE TABLE Bill_Details
(
id int PRIMARY KEY IDENTITY,
id_Product CHAR(10) REFERENCES dbo.Product(id),
id_bill CHAR(10),
price FLOAT,
quantity int

)
go
CREATE TABLE GroupUser
 (
	Id VARCHAR(10) PRIMARY KEY,
	name VARCHAR(10)
 )

 go
 CREATE TABLE UserLogin
(
account VARCHAR(50) PRIMARY KEY,
groupId VARCHAR(10) REFERENCES dbo.GroupUser(Id),
password VARCHAR(50),
id_direction  CHAR(10) REFERENCES dbo.Direction(id)

)

--Thêm dữ liệu bảng Stype--
GO
INSERT dbo.Stype VALUES ( '001','MEN' )
INSERT dbo.Stype VALUES ( '002','WOMEN' )
INSERT dbo.Stype VALUES ( '003','KIDS' )
INSERT dbo.Stype VALUES ( '004','PAIR' )

--THêm dữ liệu bảng Thương hiệu--
GO
INSERT dbo.Brand VALUES  ( 'NG001',N'CASINO')
INSERT dbo.Brand VALUES  ( 'NG002',N'CITIZEN')
INSERT dbo.Brand VALUES  ( 'NG003',N'OP')
INSERT dbo.Brand VALUES  ( 'NG004',N'DOXA')
INSERT dbo.Brand VALUES  ( 'NG005',N'TISSOT')

--thêm dữ liệu bảng Color--
GO
INSERT dbo.Color VALUES  ( 'STT001',N'RED')
INSERT dbo.Color VALUES  ( 'STT002',N'BLACK')
INSERT dbo.Color VALUES  ( 'STT003',N'BLUE')
INSERT dbo.Color VALUES  ( 'STT004',N'YELLOW')
  
--Dữ liệu bảng Images



--Dữ liệu bảng hóa đơn--



GO
INSERT dbo.Product VALUES  ( 'SP001' ,'NG001' ,'STT002' ,'001' ,'p-1.png' , N'Nhập Châu Âu' , 100.0 , N'MOVADO' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP002' ,'NG003' ,'STT001' ,'003' ,'p-2.png' , N'Nhập từ Ấn Độ' , 200.0 , N'GSHOCK' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP003' ,'NG001' ,'STT003' ,'003' ,'p-3.png' , N'Nhập từ Thụy Sĩ' , 300.0  , N'ORIEN' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP004' ,'NG002' ,'STT001' ,'001' ,'p-4.png' , N'Trong nước' , 150.0 , N'QUEEN' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP005' ,'NG003' ,'STT004' ,'004' ,'p-5.png' , N'Trung Quốc' , 170.0  , N'XIAO' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP006' ,'NG001' ,'STT002' ,'001' ,'p-1.png' , N'Nhập Châu Âu' , 100.0  , N'MOVADO' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP007' ,'NG003' ,'STT001' ,'003' ,'p-2.png' , N'Nhập từ Ấn Độ' , 200.0 , N'GSHOCK' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP008' ,'NG001' ,'STT003' ,'003' ,'p-3.png' , N'Nhập từ Thụy Sĩ' ,  250.0 , N'ORIEN' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP009' ,'NG002' ,'STT001' ,'001' ,'p-4.png' , N'Trong nước'  , 120.0 , N'QUEEN' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP010' ,'NG003' ,'STT004' ,'004' ,'p-5.png' , N'Trung Quốc' ,  150.0 , N'XIAO' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP011' ,'NG001' ,'STT002' ,'001' ,'p-1.png' , N'Nhập Châu Âu' , 99.0 , N'MOVADO' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP012' ,'NG003' ,'STT001' ,'003' ,'p-2.png' , N'Nhập từ Ấn Độ' , 99.0 , N'GSHOCK' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP013' ,'NG001' ,'STT003' ,'003' ,'p-3.png' , N'Nhập từ Thụy Sĩ'  , 250.0 , N'ORIEN','QL001')
INSERT dbo.Product VALUES  ( 'SP014' ,'NG002' ,'STT001' ,'001' ,'p-4.png' , N'Trong nước'  , 120.0 , N'QUEEN' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP015' ,'NG003' ,'STT004' ,'004' ,'p-5.png' , N'Trung Quốc' , 150.0 , N'XIAO' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP016' ,'NG001' ,'STT002' ,'001' ,'p-1.png' , N'Nhập Châu Âu' , 99.0 , N'MOVADO' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP017' ,'NG003' ,'STT001' ,'003' ,'p-2.png' , N'Nhập từ Ấn Độ' , 99.0 , N'GSHOCK' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP018' ,'NG001' ,'STT003' ,'003' ,'p-3.png' , N'Nhập từ Thụy Sĩ' , 250.0 , N'ORIEN' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP019' ,'NG002' ,'STT001' ,'001' ,'p-4.png' , N'Trong nước' , 120.0 , N'QUEEN' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP020' ,'NG003' ,'STT004' ,'004' ,'p-5.png' , N'Trung Quốc' ,  150.0 , N'XIAO' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP021' ,'NG001' ,'STT002' ,'001' ,'p-1.png' , N'Nhập Châu Âu' , 99.0 , N'MOVADO' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP022' ,'NG003' ,'STT001' ,'003' ,'p-2.png' , N'Nhập từ Ấn Độ' , 99.0 , N'GSHOCK' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP023' ,'NG001' ,'STT003' ,'003' ,'p-3.png' , N'Nhập từ Thụy Sĩ'  , 250.0 , N'ORIEN' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP024' ,'NG002' ,'STT001' ,'001' ,'p-4.png' , N'Trong nước'  , 120.0 , N'QUEEN' ,'QL001')
INSERT dbo.Product VALUES  ( 'SP025' ,'NG003' ,'STT004' ,'004' ,'p-5.png' , N'Trung Quốc'  , 150.0 , N'XIAO' ,'QL001')
					
----Dữ liệu bảng chi tiết hóa đơn--








go
INSERT dbo.GroupUser VALUES  ( 'ADMIN',  'ADMIN'  )
INSERT dbo.GroupUser VALUES  ( 'MOD',  'MOD'  )
INSERT dbo.GroupUser VALUES  ( 'MEMBER',  'MEMBER'  )
INSERT dbo.GroupUser VALUES  ( 'MEMBER2',  'MEMBER'  )

GO
INSERT dbo.UserLogin VALUES  ( 'admin' , 'ADMIN','admin','QL001' )
INSERT dbo.UserLogin VALUES  ( 'mod' , 'MOD' ,'mod','QL002' )
INSERT dbo.UserLogin VALUES  ( 'member' , 'MEMBER','member','QL003')







GO
SELECT sp.id N'Mã SP',sp.name N'Tên',br.name N'Thương hiệu',cl.name N'Màu sắc',st.name N'Thể loại',sp.image N'Hình ảnh',sp.price N'Giá',sp.info N'Thông tin', di.name N'Người nhập' FROM dbo.Product sp, dbo.Brand br,dbo.Color cl,dbo.stype st,dbo.Direction di
WHERE sp.id_brand=br.id AND sp.id_color =cl.id AND sp.id_stype=st.id AND sp.id_Direction=di.id

INSERT dbo.Product VALUES  ( '' ,  '' ,  '' , '' , '' , N'' ,  0.0 ,  N'' ,   '' )
DELETE dbo.Product WHERE id=''

UPDATE dbo.Product SET id_brand='',id_color='',id_stype='',image='',info='',price='',name='',id_Direction='' WHERE id=

GO
go
SELECT b.id N'Mã HD',cus.name N'Người mua',cus.address_ship N'Địa điểm',cus.phone N'Phone',B.date N'Ngày mua',B.total N'Tổng tiền' FROM dbo.Bill B, dbo.Customer cus WHERE b.id_Cus=cus.id  
GO
SELECT id_Product N'Mã sản phẩm',quantity N'Số lượng' FROM dbo.Bill_Details WHERE id_bill= ''
INSERT dbo.Customer VALUES  ( '' ,  N'' , N'' ,  '' )

INSERT dbo.Bill_Details ( id_Product ,id_bill ,     quantity )VALUES  ( '' ,  '' ,  0  )

INSERT dbo.Bill( id, date, trangthai )VALUES  ( '001',    '4-29-2018',   0 )
DELETE dbo.Bill_Details WHERE id_Product='' AND id_bill=''
DELETE dbo.Customer WHERE id=''

UPDATE dbo.Customer SET name='',address_ship='',phone='' WHERE id=''
DELETE dbo.Customer WHERE id=''

GO
CREATE PROC search_sp( @s NVARCHAR(20) )
AS
BEGIN
IF(@s in (SELECT name FROM dbo.Product))
BEGIN
SELECT P.id,P.name,B.name,C.name,S.name,P.image,P.info,P.price FROM dbo.Product AS P, dbo.Brand AS B, dbo.Color AS C, dbo.stype AS S
WHERE B.id = P.id_brand AND C.id = P.id_color AND S.id = P.id_stype AND P.name=@s
END

IF(@s in (SELECT name FROM dbo.Color))
BEGIN
SELECT P.id,P.name,B.name,C.name,S.name,P.image,P.info,P.price FROM dbo.Product AS P, dbo.Brand AS B, dbo.Color AS C, dbo.stype AS S
WHERE B.id = P.id_brand AND C.id = P.id_color AND S.id = P.id_stype AND C.name = @s
END

IF(@s in (SELECT name FROM dbo.Brand))
BEGIN
SELECT P.id,P.name,B.name,C.name,S.name,P.image,P.info,P.price FROM dbo.Product AS P, dbo.Brand AS B, dbo.Color AS C, dbo.stype AS S
WHERE B.id = P.id_brand AND C.id = P.id_color AND S.id = P.id_stype AND B.name = @s
END

DECLARE @a CHAR(10)
SET @a='B%'
IF((SELECT name FROM dbo.stype) LIKE @a)
BEGIN
SELECT P.id,P.name,B.name,C.name,S.name,P.image,P.info,P.price FROM dbo.Product AS P, dbo.Brand AS B, dbo.Color AS C, dbo.stype AS S
WHERE B.id = P.id_brand AND C.id = P.id_color AND S.id = P.id_stype AND S.name LIKE @a
END


END

--dbo.search_sp_s @s = N'M'

--GO
--ALTER PROC dbo.search_sp_s(@s NVARCHAR(20))
--AS
--BEGIN

--SELECT * FROM dbo.Product P,dbo.Brand B,dbo.Color C,dbo.stype S WHERE  B.id = P.id_brand AND C.id = P.id_color AND S.id = P.id_stype AND (B.name LIKE N'%' OR  S.name LIKE N'%' OR C.name LIKE N'%')

--END
--SELECT  P.id N'Mã SP',P.name N'Tên',B.name N'Thương hiệu',C.name N'Màu sắc',S.name N'Thể loại',P.image N'Hình ảnh',P.price N'Giá',P.info N'Thông tin', di.name N'Người nhập' FROM dbo.Product P,dbo.Brand B,dbo.Color C,dbo.stype S,dbo.Direction di WHERE   B.id = P.id_brand AND C.id = P.id_color AND S.id = P.id_stype AND (B.name LIKE N'%' OR  S.name LIKE N'" + name + "%' OR C.name LIKE N'" + name + "%')AND sp.id_Direction = di.id


--SELECT * FROM dbo.Color WHERE name LIKE '%B%' 


--SELECT MONTH(date) N'Tháng',COUNT(total) N'Tổng tiền' FROM dbo.Bill 
--GROUP BY MONTH(date)


/* Thủ tục sửa nv*/ 
-- thêm nhân viên
go
create proc ThemNV
(
	@MaNV char(10),
	@TenNV nvarchar(50),
	@DiaChi nvarchar(50),
	@SDT char(11),
	@CMTND char(11),
	@GT nchar(3),
	@NgaySinh datetime
)
as
begin
insert into dbo.direction(id, name, address_ship ,phone ,identification,bith ,sex )
values (@MaNV,@TenNV, @DiaChi, @SDT, @CMTND, @NgaySinh, @GT)

end

go
/* thủ tục xóa 1 nv*/
create proc XoaNV
( 
     @MaNV char(10) 
) 
AS
begin
delete from Direction
		where ID = @MaNV
end
go


/* Thủ tục sửa nv*/ 
CREATE PROC  SuaNV
( 
     @MaNV char(10),
	@TenNV nvarchar(50),
	@DiaChi nvarchar(50),
	@SDT char(11),
	@CMTND char(11),
	@GT nchar(3),
	@NgaySinh datetime
     ) 
AS 
UPDATE Direction
SET id=  @MaNV,
	Name = @TenNV,
	address_ship = @DiaChi,
	phone = @SDT,
	identification = @CMTND,
	sex = @GT,
	bith = @NgaySinh
 WHERE ID= @MaNV
 go
 GO
 INSERT dbo.Bill
         ( id, id_Cus, date, total, trangthai )
 VALUES  ( 'hd01', -- id - char(10)
           NULL, -- id_Cus - char(10)
           '2/3/2018', -- date - datetime
           2000.0, -- total - float
           NULL  -- trangthai - bit
           )
 INSERT dbo.Bill
         ( id, id_Cus, date, total, trangthai )
 VALUES  ( 'hd02', -- id - char(10)
           NULL, -- id_Cus - char(10)
           '2/2/2018', -- date - datetime
           4000.0, -- total - float
           NULL  -- trangthai - bit
           )
 INSERT dbo.Bill
         ( id, id_Cus, date, total, trangthai )
 VALUES  ( 'hd03', -- id - char(10)
           NULL, -- id_Cus - char(10)
           '3/2/2018', -- date - datetime
           3000.0, -- total - float
           NULL  -- trangthai - bit
           )
 INSERT dbo.Bill
         ( id, id_Cus, date, total, trangthai )
 VALUES  ( 'hd04', -- id - char(10)
           NULL, -- id_Cus - char(10)
           '3/3/2018', -- date - datetime
           5000.0, -- total - float
           NULL  -- trangthai - bit
           )
 INSERT dbo.Bill
         ( id, id_Cus, date, total, trangthai )
 VALUES  ( 'hd14', -- id - char(10)
           NULL, -- id_Cus - char(10)
           '4/2/2018', -- date - datetime
           4000.0, -- total - float
           NULL  -- trangthai - bit
           )
 INSERT dbo.Bill
         ( id, id_Cus, date, total, trangthai )
 VALUES  ( 'hd05', -- id - char(10)
           NULL, -- id_Cus - char(10)
           '5/2/2018', -- date - datetime
           4000.0, -- total - float
           NULL  -- trangthai - bit
           )
 INSERT dbo.Bill
         ( id, id_Cus, date, total, trangthai )
 VALUES  ( 'hd06', -- id - char(10)
           NULL, -- id_Cus - char(10)
           '6/3/2018', -- date - datetime
           3000.0, -- total - float
           NULL  -- trangthai - bit
           )

 INSERT dbo.Bill
         ( id, id_Cus, date, total, trangthai )
 VALUES  ( 'hd07', -- id - char(10)
           NULL, -- id_Cus - char(10)
           '7/4/2018', -- date - datetime
           2000.0, -- total - float
           NULL  -- trangthai - bit
           )

 INSERT dbo.Bill
         ( id, id_Cus, date, total, trangthai )
 VALUES  ( 'hd08', -- id - char(10)
           NULL, -- id_Cus - char(10)
           '8/5/2018', -- date - datetime
           4000.0, -- total - float
           NULL  -- trangthai - bit
           )

 INSERT dbo.Bill
         ( id, id_Cus, date, total, trangthai )
 VALUES  ( 'hd09', -- id - char(10)
           NULL, -- id_Cus - char(10)
           '9/6/2018', -- date - datetime
           12000.0, -- total - float
           NULL  -- trangthai - bit
           )

 INSERT dbo.Bill
         ( id, id_Cus, date, total, trangthai )
 VALUES  ( 'hd10', -- id - char(10)
           NULL, -- id_Cus - char(10)
           '10/7/2018', -- date - datetime
           2000.0, -- total - float
           NULL  -- trangthai - bit
           )

 INSERT dbo.Bill
         ( id, id_Cus, date, total, trangthai )
 VALUES  ( 'hd11', -- id - char(10)
           NULL, -- id_Cus - char(10)
           '11/8/2018', -- date - datetime
           4000.0, -- total - float
           NULL  -- trangthai - bit
           )

 INSERT dbo.Bill
         ( id, id_Cus, date, total, trangthai )
 VALUES  ( 'hd12', -- id - char(10)
           NULL, -- id_Cus - char(10)
           '12/9/2018', -- date - datetime
           3000.0, -- total - float
           NULL  -- trangthai - bit
           )
 INSERT dbo.Bill
         ( id, id_Cus, date, total, trangthai )
 VALUES  ( 'hd13', -- id - char(10)
           NULL, -- id_Cus - char(10)
           '1/9/2018', -- date - datetime
           3000.0, -- total - float
           NULL  -- trangthai - bit
           )

		   
GO
CREATE VIEW thongke
AS
SELECT MONTH(date) AS MONTH,sum(total) AS PRICE FROM dbo.Bill	
GROUP BY ( MONTH(date)) 
GO
--SELECT PRICE FROM dbo.thongke
--GO
--SELECT total FROM dbo.bill
--GO

CREATE PROC thongke_thang(@thang CHAR(10))
AS
BEGIN
SELECT x.name N'Tên sản phẩm', SUM(X.quantity) N'Tổng số lương',sum (x.price) N'Tổng tiền' FROM 
 (SELECT p.name name, BD.quantity quantity,BD.price price 
 FROM dbo.Bill_Details BD,dbo.Product P
  WHERE id_bill IN(SELECT id FROM dbo.Bill WHERE MONTH(date)=@thang) 
  AND BD.id_Product=p.id) AS X
GROUP BY X.name 
END


