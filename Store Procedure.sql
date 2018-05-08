USE INFLOW 
GO

------ STORE PROC: REGISTER NEW USER --------------

CREATE PROC RegisterUser (
@username_param varchar(50),
@pass_param varchar(50),
@firstname_param varchar(50),
@lastname_param varchar(50),
@phone_param varchar(50),
@email_param varchar(50)
)
AS
BEGIN
INSERT INTO UserInfo values (
@username_param, 
@pass_param,
@firstname_param, 
@lastname_param, 
@phone_param,
@email_param,
0 )
END
GO
---------- STORE PROC: NEW VENDOR ------------

CREATE PROC NewVendor (
@vendorname varchar(100),
@balance int,
@vendorAddress varchar(200),
@contactName varchar(100),
@phone varchar(100),
@fax varchar(100),
@email varchar(100),
@website varchar(100),
@paymentmethod varchar(100),
@tax int,
@discount int
)
AS
BEGIN
INSERT INTO Vendor VALUES (
@vendorname,
@balance,
@vendorAddress ,
@contactName,
@phone,
@fax,
@email,
@website,
@paymentmethod,
@tax,
@discount
)
END