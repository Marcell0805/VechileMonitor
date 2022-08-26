USE [master]
GO
CREATE OR ALTER PROC ContractorSummary
(@contractorID INTEGER)
AS
    BEGIN
           SELECT c.ContractorID,c.ContractorName,count(v.RegisterNo)as 'NoOfVechiles',sum(v.VechileWeight) as 'TotalTons'
			FROM Contractor c
			left join Vechile v
				on c.ContractorID=v.ContractorID
				group by c.ContractorID,c.ContractorName;
        END;


