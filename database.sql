CREATE DATABASE finalSE
GO

USE finalSE
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

CREATE TABLE [Product](
	[prodid] [varchar] (20) NOT NULL,
	[prodname] [varchar](50) NOT NULL,
	[quantity] int NOT NULL,
	[price] int NULL,
	PRIMARY KEY(prodid)
)

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