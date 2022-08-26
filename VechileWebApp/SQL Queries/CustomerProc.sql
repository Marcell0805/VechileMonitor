USE [master]
GO
CREATE OR ALTER PROC ContractorInsert
(@contractorID INTEGER,
                            @contractorName    VARCHAR(50),
                            @email        varchar(80),
							@phoneNumber VARCHAR(20))
AS
    BEGIN
           INSERT INTO [dbo].[Contractor]
           ([ContractorID]
           ,[ContractorName]
           ,[Email]
           ,[PhoneNumber])
            VALUES     ( @contractorID,
                         @contractorName,
                         @email,
                         @phoneNumber)
        END;

