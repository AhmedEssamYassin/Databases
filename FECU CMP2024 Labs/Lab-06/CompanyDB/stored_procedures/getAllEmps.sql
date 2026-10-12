SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ahmed Yassin
-- Create date: 2026-05-30
-- Description:	Stored Procedure to retrieve all employee records
-- =============================================
IF OBJECT_ID('dbo.getAllEmps', 'P') IS NOT NULL 
    DROP PROCEDURE dbo.getAllEmps;
GO

CREATE PROCEDURE [dbo].[getAllEmps]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Employee;
END
GO
