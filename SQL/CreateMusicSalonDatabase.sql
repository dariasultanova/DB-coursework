USE master
Go
CREATE DATABASE MusicSalon ON
(Name=  MusicSalon, 
FileName='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ MusicSalon.mdf'
) 
LOG ON 
(Name=  MusicSalon_log, 
FileName='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ MusicSalon_log.ldf'
) 
Go
EXEC SP_HELPDB  MusicSalon
Go

ALTER DATABASE  MusicSalon SET AUTO_SHRINK ON
Go

ALTER DATABASE  MusicSalon
 MODIFY FILE (name= MusicSalon, maxsize=100MB)
 go
 EXEC SP_HELPDB  MusicSalon
 Go

 USE  MusicSalon 
 go

 CREATE TABLE InstrumentsCost
 (Title varchar(50) PRIMARY KEY,
  Cost int)
go

CREATE TABLE Instruments
(NumInst int IDENTITY (1,1) PRIMARY KEY,
 Title varchar(50) FOREIGN KEY REFERENCES InstrumentsCost,
 Ready bit)
go

 CREATE TABLE HallsCost
 (Title varchar(50) PRIMARY KEY,
  Cost int)
go

CREATE TABLE Halls
(NumHall int IDENTITY (1,1) PRIMARY KEY,
 Title varchar(50) FOREIGN KEY REFERENCES HallsCost,
 Ready bit)
go

 CREATE TABLE EquipmentCost
 (Title varchar(50) PRIMARY KEY,
  Cost int)
go

CREATE TABLE Equipment
(NumEq int IDENTITY (1,1) PRIMARY KEY,
 Title varchar(50) FOREIGN KEY REFERENCES EquipmentCost,
 Ready bit)
go

CREATE TABLE RepairCost
(NumEq int FOREIGN KEY REFERENCES Equipment,
 NumHall int FOREIGN KEY REFERENCES Halls,
 NumInst int FOREIGN KEY REFERENCES Instruments,
 constraint one_data
  check(NumEq is not null and NumHall is null and  NumInst is null or
        NumEq is  null and NumHall is not null and  NumInst is null or
		NumEq is  null and NumHall is null and  NumInst is not null ),
 Date_of_repair date,
 Cost int)
go

CREATE TABLE Jobs
(  Post varchar(50) PRIMARY KEY,
   Salary int,
   Pay int)
go

CREATE TABLE Staff
(Id int IDENTITY (1,1) PRIMARY KEY,
 FIO varchar(50),
 Post varchar(50) FOREIGN KEY REFERENCES Jobs,
 Mail varchar(50),
 Nickname varchar(20),
 Pswd varchar(10))
go


CREATE TABLE Clients
(Id int IDENTITY (1,1) PRIMARY KEY,
 FIO varchar(50),
 Mail varchar(50),
 Nickname varchar(20),
 Pswd varchar(10)
)

CREATE TABLE Contracts
(Number int IDENTITY (1,1) PRIMARY KEY,
 DateOfDeal date,
 TimeOfBegin time,
 TimeOfEnd time,
 Id int FOREIGN KEY REFERENCES Clients)

 CREATE TABLE Contents
 (NumEq int FOREIGN KEY REFERENCES Equipment,
 NumHall int FOREIGN KEY REFERENCES Halls,
 NumInst int FOREIGN KEY REFERENCES Instruments,
 Id int FOREIGN KEY REFERENCES Staff,
 constraint one_data_content
  check(NumEq is not null and NumHall is null and  NumInst is null and Id is null or
        NumEq is  null and NumHall is not null and  NumInst is null and Id is null or
		NumEq is  null and NumHall is null and  NumInst is not null and Id is null or
		NumEq is  null and NumHall is null and  NumInst is null and Id is not null),
    Number int FOREIGN KEY REFERENCES Contracts)


 CREATE TABLE Admins
(Id int IDENTITY (1,1) PRIMARY KEY,
 FIO varchar(50),
 Mail varchar(50),
 Nickname varchar(20),
 Pswd varchar(10)
)



