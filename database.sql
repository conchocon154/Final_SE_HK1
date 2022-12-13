CREATE DATABASE finalSE
GO

USE finalSE
GO

-- Create TABLE:
CREATE TABLE [User](
	[username] [varchar](20) NOT NULL,
	[password] [varchar](30) NOT NULL,
	[fullName] [varchar](50) NULL,
	[phone] [varchar] (15),
	[BDate] Date NULL,
	[Address] [varchar](30) NULL,
	[Gender] [char](1) NULL,
	PRIMARY KEY(username)
)

GO

INSERT INTO [User]  VALUES('admin','admin','Dang','012345678910','2002-01-01','Ho Chi Minh ', 'M')
INSERT INTO [User]  VALUES('user','user','Tan','1234567JQK','2001-01-01','Ho Chi Minh ', 'M')


CREATE TABLE [Product](
	[prodid] [varchar] (20) NOT NULL,
	[prodname] [varchar](50) NOT NULL,
	[quantity] int NOT NULL,
	[price] int NULL,
	PRIMARY KEY(prodid)
)

GO
-- INSERT DATA
INSERT INTO [Product]  VALUES('P01','Healthy Care Vitamin C','50','10')
INSERT INTO [Product]  VALUES('P02','Nature`s Way Complete Daily Multivitamin ','100','8')
INSERT INTO [Product]  VALUES('P03','Nat C','80','5')
INSERT INTO [Product]  VALUES('P04','Siro Brauer Immunity Support','30','15')
INSERT INTO [Product]  VALUES('P05','Orgain Organic Superfoods Immunity Up','67','20')
INSERT INTO [Product]  VALUES('P06','Puritan`s Pride','40','12')
INSERT INTO [Product]  VALUES('P07','Blackmores Bio C','84','13')
INSERT INTO [Product]  VALUES('P08','Vitamin C + Manuka honey ','20','9')
INSERT INTO [Product]  VALUES('P09','Fiber Well','77','25')
INSERT INTO [Product]  VALUES('P10','DHC Perfect Vegetable','99','23')

CREATE TABLE [GRN](
	[grnid] [varchar] (20) NOT NULL,
	[supplier] [varchar](50) NOT NULL,
	[receiver] [varchar](30) NOT NULL,
	[checker] [varchar](30) NOT NULL,
	[grndate] Date NULL,
	PRIMARY KEY(grnid)
)

GO

INSERT INTO [GRN]  VALUES('GR01','Vi', 'Trang', 'Trang','2022-01-01')
INSERT INTO [GRN]  VALUES('GR02','Dung', 'Chi', 'Mai','2022-01-01')
INSERT INTO [GRN]  VALUES('GR03','My', 'Anh', 'Trung','2022-01-01')

CREATE TABLE [GRNprod](
	[grnid] [varchar] (20) NOT NULL,
	[prodid] [varchar] (20) NOT NULL,
	[quantity] int NOT NULL,
	PRIMARY KEY(grnid, prodid)
)

GO

ALTER TABLE [GRNprod]
ADD CONSTRAINT FK_ProductGRNprod
FOREIGN KEY (prodid) REFERENCES Product(prodid); 

ALTER TABLE [GRNprod]
ADD CONSTRAINT FK_GRNtoGRNprod
FOREIGN KEY (grnid) REFERENCES GRN(grnid); 

GO

CREATE TABLE [Order](
	[oid] [varchar] (20) NOT NULL,
	[odate] Date NOT NULL,
	[delidate] Date,
	[paidmethod] [varchar] (30) NOT NULL,
	[agentname] [varchar] (30) NOT NULL,
	[agentphone] [varchar] (15) NOT NULL,
	[agentaddress] [varchar] (50) NOT NULL,
	[paymentstt] int  default '0',
	[orderstt] [varchar] (30) default 'Pending',
	[total] int,
	PRIMARY KEY(oid)
)

GO

CREATE TABLE [Orderprod](
	[oid] [varchar] (20) NOT NULL,
	[prodid] [varchar] (20) NOT NULL,
	[quantity] int NOT NULL,
	PRIMARY KEY(oid, prodid)
)

GO

ALTER TABLE [Orderprod]
ADD CONSTRAINT FK_ProductOrderprod
FOREIGN KEY (prodid) REFERENCES Product(prodid); 

ALTER TABLE [Orderprod]
ADD CONSTRAINT FK_OrdertoOrderprod
FOREIGN KEY (oid) REFERENCES [Order](oid);

GO


INSERT INTO [Order]  VALUES('Or01','2018-09-09','2021-09-10','Cash','Trung','0123456789','Mytho', '1', 'Pending')
INSERT INTO [Order]  VALUES('Or02','2022-12-09','','Momo','Tinh','1472347983','Longan', '0', 'Cancelled')
INSERT INTO [Order]  VALUES('Or03','2017-12-12','','InternetBanking','An','382374032','Hanoi', '1', 'Being Delivered')
INSERT INTO [Order]  VALUES('Or04','2023-12-24','2021-09-10','Cash','Chi','184728493','Hanoi', '0', 'Pending')


INSERT INTO [Orderprod]  VALUES('Or03','P01','10')
INSERT INTO [Orderprod]  VALUES('Or03','P02','5')
INSERT INTO [Orderprod]  VALUES('Or04','P03','6')
INSERT INTO [Orderprod]  VALUES('Or04','P01','11')
INSERT INTO [Orderprod]  VALUES('Or02','P04','8')
INSERT INTO [Orderprod]  VALUES('Or01','P05','3')
INSERT INTO [Orderprod]  VALUES('Or04','P06','9')
INSERT INTO [Orderprod]  VALUES('Or04','P07','2')
INSERT INTO [Orderprod]  VALUES('Or002','P08','13')
INSERT INTO [Orderprod]  VALUES('Or03','P09','11')