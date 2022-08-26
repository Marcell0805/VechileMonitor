USE [master]
GO
CREATE OR ALTER PROC ContractorFetch
AS
    BEGIN
           SELECT *
			FROM Contractor c
			order by c.ContractorName;
        END;


