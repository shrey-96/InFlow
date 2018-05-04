CREATE DATABASE INFLOW
GO

USE INFLOW
GO

CREATE TABLE UserInfo (
username varchar(50),
pass varchar(50),
firstname varchar(50),
lastname varchar(50),
phone varchar(50),
email varchar(50),
verfied int NOT NULL DEFAULT(0)
)

