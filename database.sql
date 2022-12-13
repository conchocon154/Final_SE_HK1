USE MASTER
GO

DROP DATABASE IF EXISTS DangTan
GO

CREATE DATABASE DangTan
GO

USE DangTan
GO

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

INSERT INTO [User]  VALUES('admin','admin','Dang','0123445','1955-01-09','HCM VN', 'M')
GO
INSERT INTO [User]  VALUES('user','user','Tan','0123445','1955-01-09','HCM VN', 'M')
GO

CREATE TABLE [Product](
	[prodid] [varchar] (20) NOT NULL,
	[prodname] [varchar](50) NOT NULL,
	[quantity] int NOT NULL,
	[price] int NULL,
	PRIMARY KEY(prodid)
)
GO

INSERT INTO [Product]  VALUES('P01','Healthy Care Vitamin C','50','10')
GO
INSERT INTO [Product]  VALUES('P02','Nature`s Way Complete Daily Multivitamin ','100','8')
GO
INSERT INTO [Product]  VALUES('P03','Nat C','80','5')
GO
INSERT INTO [Product]  VALUES('P04','Siro Brauer Immunity Support','30','15')
GO
INSERT INTO [Product]  VALUES('P05','Orgain Organic Superfoods Immunity Up','67','20')
GO
INSERT INTO [Product]  VALUES('P06','Puritan`s Pride','40','12')
GO
INSERT INTO [Product]  VALUES('P07','Blackmores Bio C','84','13')
GO
INSERT INTO [Product]  VALUES('P08','Vitamin C + Manuka honey ','20','9')
GO
INSERT INTO [Product]  VALUES('P09','Fiber Well','77','25')
GO
INSERT INTO [Product]  VALUES('P10','DHC Perfect Vegetable','99','23')
GO


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
GO
INSERT INTO [GRN]  VALUES('GR02','Dung', 'Chi', 'Mai','2022-01-01')
GO
INSERT INTO [GRN]  VALUES('GR03','My', 'Anh', 'Trung','2022-01-01')
GO

CREATE TABLE [GRNprod] (
	[grnid] [varchar] (20) NOT NULL,
	[prodid] [varchar] (20) NOT NULL,
	[quantity] int NOT NULL,
	PRIMARY KEY(grnid, prodid)
)
GO

INSERT INTO [GRNprod]  VALUES('GR02','P01', 10)
GO
INSERT INTO [GRNprod]  VALUES('GR02','P03', 15)
GO


CREATE TABLE [Order](
	[oid] [varchar] (20) NOT NULL,
	[odate] Date NOT NULL,
	[delidate] Date,
	[paidmethod] [varchar] (30) NOT NULL,
	[agentname] [varchar] (30) NOT NULL,
	[agentphone] [varchar] (15) NOT NULL,
	[agentaddress] [varchar] (50) NOT NULL,
	[paymentstt] int  default 0,
	[orderstt] [varchar] (30) default 'Pending',
	[total] int,
	PRIMARY KEY(oid)
)
GO

CREATE TABLE [Orderprod] (
	[oid] [varchar] (20) NOT NULL,
	[prodid] [varchar] (20) NOT NULL,
	[quantity] int NOT NULL,
	PRIMARY KEY(oid, prodid)
)
GO

INSERT INTO [Order] (oid, odate, delidate, paidmethod, agentname, agentphone, agentaddress, paymentstt, orderstt) VALUES
('Or01','2021-09-09','2021-09-10','Cash','Tung','0123456789','My Tho', 1, 'Pending')
GO
INSERT INTO [Order] (oid, odate, delidate, paidmethod, agentname, agentphone, agentaddress, paymentstt, orderstt) VALUES
('Or02','2021-12-09','2022-09-10','Momo','Tien','1472347983','HCM', 0, 'Cancelled')
GO
INSERT INTO [Order] (oid, odate, delidate, paidmethod, agentname, agentphone, agentaddress, paymentstt, orderstt) VALUES
('Or03','2021-12-12','2022-09-10','InternetBanking','Dung','382374032','Long An', 1, 'Being Delivered')
GO
INSERT INTO [Order] (oid, odate, delidate, paidmethod, agentname, agentphone, agentaddress, paymentstt, orderstt) VALUES
('Or04','2021-12-24','2022-09-10','Cash','Chi','184728493','Hanoi', 0, 'Pending')
GO


INSERT INTO [Orderprod]  VALUES('Or03','P01',10)
GO
INSERT INTO [Orderprod]  VALUES('Or03','P02',5)
GO
INSERT INTO [Orderprod]  VALUES('Or04','P03',6)
GO
INSERT INTO [Orderprod]  VALUES('Or04','P01',11)
GO
INSERT INTO [Orderprod]  VALUES('Or02','P04',8)
GO
INSERT INTO [Orderprod]  VALUES('Or01','P05',3)
GO
INSERT INTO [Orderprod]  VALUES('Or04','P06',9)
GO
INSERT INTO [Orderprod]  VALUES('Or04','P07',2)
GO
INSERT INTO [Orderprod]  VALUES('Or02','P08',13)
GO
INSERT INTO [Orderprod]  VALUES('Or03','P09',11)
GO

ALTER TABLE [GRNprod]
ADD CONSTRAINT FK_ProductGRNprod
FOREIGN KEY (prodid) REFERENCES Product(prodid)
GO

ALTER TABLE [GRNprod]
ADD CONSTRAINT FK_GRNtoGRNprod
FOREIGN KEY (grnid) REFERENCES GRN(grnid)
GO

ALTER TABLE [Orderprod]
ADD CONSTRAINT FK_ProductOrderprod
FOREIGN KEY (prodid) REFERENCES Product(prodid)
GO

ALTER TABLE [Orderprod]
ADD CONSTRAINT FK_OrdertoOrderprod
FOREIGN KEY (oid) REFERENCES [Order](oid)
GO