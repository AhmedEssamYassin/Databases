SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ahmed Yassin
-- Create date: 2026-05-30
-- Description:	Stored Procedure to select projects for a specific department location
-- =============================================
IF OBJECT_ID('dbo.selectProjectsofDeptLoc', 'P') IS NOT NULL 
    DROP PROCEDURE dbo.selectProjectsofDeptLoc;
GO

CREATE PROCEDURE [dbo].[selectProjectsofDeptLoc]
    @location VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT Pname, Dname 
    FROM Department D, Project P, Dept_Locations L
    WHERE P.Dnum = D.Dnumber AND L.Dnumber = D.Dnumber AND L.Dlocation = @location;
END
GO
