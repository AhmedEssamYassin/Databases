SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ahmed Yassin
-- Create date: 2026-05-30
-- Description:	User Stored Procedure to search employees by Fname, Lname, or exact SSN
-- =============================================
IF OBJECT_ID('dbo.usp_SearchEmployees', 'P') IS NOT NULL 
    DROP PROCEDURE dbo.usp_SearchEmployees;
GO

CREATE PROCEDURE [dbo].[usp_SearchEmployees]
    @SearchVal VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Employee 
    WHERE Fname LIKE '%' + @SearchVal + '%' 
       OR Lname LIKE '%' + @SearchVal + '%' 
       OR CAST(SSN AS VARCHAR(50)) = @SearchVal;
END
GO
