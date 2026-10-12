SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ahmed Yassin
-- Create date: 2026-05-30
-- Description:	Stored Procedure to insert a new project record
-- =============================================
IF OBJECT_ID('dbo.insertProject', 'P') IS NOT NULL 
    DROP PROCEDURE dbo.insertProject;
GO

CREATE PROCEDURE [dbo].[insertProject]
    @Pname VARCHAR(50), 
    @Pnumber INT,
    @Plocation VARCHAR(50), 
    @Dnum INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Project (Pname, Pnumber, Plocation, Dnum)
    VALUES (@Pname, @Pnumber, @Plocation, @Dnum);
END
GO
