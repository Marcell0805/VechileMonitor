--Table creation Scripts
PRINT 'Creating Contractor table';
CREATE TABLE Contractor(
    ContractorID int not null,
    ContractorName varchar(80),
    Email varchar(80),
    PhoneNumber varchar(20),
	PRIMARY KEY (ContractorID)
);
------------------------------------
PRINT 'Creating Vechile table';
	Create TABLE Vechile(
    RegisterNo int not null,
    VechileType varchar(80),
    Model varchar(80),
    VechileWeight decimal,
	ContractorID int,
	PRIMARY KEY (RegisterNo),
	CONSTRAINT FK_Contractor FOREIGN KEY (ContractorID)
    REFERENCES Contractor(ContractorID)
);
------------------------------------
--Inserting Test Data
INSERT INTO [dbo].[Contractor]
           ([ContractorID]
           ,[ContractorName]
           ,[Email]
           ,[PhoneNumber])
     VALUES
           (1
           ,'John'
           ,'JohnTest@gmail.com'
           ,'0124568845');

		   INSERT INTO [dbo].[Contractor]
           ([ContractorID]
           ,[ContractorName]
           ,[Email]
           ,[PhoneNumber])
     VALUES
           (2
           ,'Jack'
           ,'JAckTest@gmail.com'
           ,'0128568845');
--Truck Data
USE [master]
GO

INSERT INTO [dbo].[Vechile]
           ([RegisterNo]
           ,[VechileType]
           ,[Model]
           ,[VechileWeight]
           ,[ContractorID])
     VALUES
           (1
           ,'Truck'
           ,'SingleLoad'
           ,5
           ,1);

INSERT INTO [dbo].[Vechile]
           ([RegisterNo]
           ,[VechileType]
           ,[Model]
           ,[VechileWeight]
           ,[ContractorID])
     VALUES
           (2
           ,'Truck'
           ,'DoubleTrailer'
           ,15
           ,1);

/*
Drop Table Vechile

Drop Table Contractor

ALTER TABLE Vechile
DROP CONSTRAINT RegisterNo;

ALTER TABLE Contractor
DROP CONSTRAINT ContractorID;

ALTER TABLE Vechile
DROP CONSTRAINT FK_Contractor;
*/