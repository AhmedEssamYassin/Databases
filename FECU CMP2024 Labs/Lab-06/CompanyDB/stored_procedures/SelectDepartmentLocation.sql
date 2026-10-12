SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ahmed Yassin
-- Create date: 2026-05-30
-- Description:	Stored Procedure to select distinct department locations
-- =============================================
IF OBJECT_ID('dbo.SelectDepartmentLocation', 'P') IS NOT NULL 
    DROP PROCEDURE dbo.SelectDepartmentLocation;
GO

CREATE PROCEDURE [dbo].[SelectDepartmentLocation]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT DISTINCT Dlocation FROM Dept_Locations;
END
GO
