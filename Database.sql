USE master
IF EXISTS(select * from sys.databases where name='INFLOW')
	DROP DATABASE INFLOW
GO

CREATE DATABASE INFLOW
GO

USE INFLOW
GO

-- USER INFORMATION TABLE
CREATE TABLE UserInfo (
username varchar(50) NOT NULL PRIMARY KEY,
password varchar(50),
firstname varchar(50),
lastname varchar(50),
phone varchar(50),
email varchar(50) NOT NULL UNIQUE,
verified int NOT NULL DEFAULT(0)
)

-- VENDOR TABLE
CREATE TABLE Vendor (
vendorname varchar(100) NOT NULL PRIMARY KEY,
balance int,
vendorAddress varchar(200),
contactName varchar(100),
phone varchar(100),
fax varchar(100),
email varchar(100),
website varchar(100),
paymentmethod varchar(100),
tax int,
discount int
)

-- CUSTOMER TABLE
CREATE TABLE Customer (
customerid int NOT NULL PRIMARY KEY,
customername varchar(100) NOT NULL,
balance int,
customeraddress varchar(100),
contactname varchar(100),
phone varchar(100),
fax varchar(100),
email varchar(100),
website varchar(100),
paymentmethod varchar(100),
tax int,
discount int
)
GO

-- STORED PROC: ADD CUSTOMER --
CREATE PROC NewCustomer (
@customerid int, @customername varchar(100), @balance int, @customeraddress varchar(100),
@contactname varchar(100), @phone varchar(100), @fax varchar(100), @email varchar(100),
@website varchar(100), @paymentmethod varchar(100), @tax int, @discount int )
AS
BEGIN
INSERT INTO Customer VALUES (
@customerid, @customername, @balance, @customeraddress, @contactname, @phone,
@fax, @email, @website, @paymentmethod, @tax, @discount )
END
GO


------ STORE PROC: REGISTER NEW USER --------------
CREATE PROC RegisterUser (
@username_param varchar(50), @pass_param varchar(50), @firstname_param varchar(50), @lastname_param varchar(50),
@phone_param varchar(50), @email_param varchar(50) )
AS
BEGIN
INSERT INTO UserInfo values (
@username_param, @pass_param, @firstname_param, @lastname_param, @phone_param, @email_param, 0 )
END
GO


---------- STORE PROC: NEW VENDOR ------------
CREATE PROC NewVendor (
@vendorname varchar(100), @balance int, @vendorAddress varchar(200), @contactName varchar(100),
@phone varchar(100), @fax varchar(100), @email varchar(100), @website varchar(100),
@paymentmethod varchar(100), @tax int, @discount int )
AS
BEGIN
INSERT INTO Vendor VALUES (
@vendorname, @balance, @vendorAddress , @contactName, @phone, @fax, @email,
@website, @paymentmethod, @tax, @discount )
END
GO