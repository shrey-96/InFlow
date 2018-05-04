CREATE DATABASE INFLOW
GO

USE INFLOW
GO

CREATE TABLE UserInfo (
username varchar(50) NOT NULL PRIMARY KEY,
password varchar(50),
firstname varchar(50),
lastname varchar(50),
phone varchar(50),
email varchar(50) NOT NULL UNIQUE,
verified int NOT NULL DEFAULT(0)
)

GO

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

