SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ahmed Yassin
-- Create date: 2026-05-30
-- Description:	Stored Procedure to select department names and numbers
-- =============================================
IF OBJECT_ID('dbo.selectDepartmentNum', 'P') IS NOT NULL 
    DROP PROCEDURE dbo.selectDepartmentNum;
GO

CREATE PROCEDURE [dbo].[selectDepartmentNum]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT Dname, Dnumber FROM Department;
END
GO
