SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ahmed Yassin
-- Create date: 2026-05-30
-- Description:	User Stored Procedure to count employees working on a project
-- =============================================
IF OBJECT_ID('dbo.usp_GetProjectEmployeeCount', 'P') IS NOT NULL 
    DROP PROCEDURE dbo.usp_GetProjectEmployeeCount;
GO

CREATE PROCEDURE [dbo].[usp_GetProjectEmployeeCount]
    @Pnumber INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(Essn) FROM Works_On WHERE Pno = @Pnumber;
END
GO
