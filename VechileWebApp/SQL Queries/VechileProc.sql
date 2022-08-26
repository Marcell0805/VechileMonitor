USE [master]
GO
CREATE OR ALTER PROC VechileData (@registerNo  INTEGER,
                            @type    VARCHAR(10),
                            @model     VARCHAR(10),
                            @weight        DECIMAL(10, 2),
							@StatementType NVARCHAR(20) = '')
AS
  BEGIN
      IF @StatementType = 'Insert'
        BEGIN
           INSERT INTO [dbo].[Vechile]
           ([RegisterNo]
           ,[VechileType]
           ,[Model]
           ,[Weight])
            VALUES     ( @registerNo,
                         @type,
                         @model,
                         @weight)
        END

      IF @StatementType = 'Select'
        BEGIN
            SELECT *
            FROM   [dbo].[Vechile]
        END

      IF @StatementType = 'Update'
        BEGIN
            UPDATE [dbo].[Vechile]
		   SET [RegisterNo] = @registerNo
			  ,[VechileType] = @type
			  ,[Model] = @model
			  ,[Weight] =@weight
            WHERE  registerNo = @registerNo
        END
      ELSE IF @StatementType = 'Delete'
        BEGIN
            DELETE FROM [dbo].[Vechile]
            WHERE  [RegisterNo] =  @registerNo
        END
  END