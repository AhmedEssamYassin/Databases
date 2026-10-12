SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ahmed Yassin
-- Create date: 2026-05-30
-- Description:	User Stored Procedure to safely delete a project and clean up works_on references
-- =============================================
IF OBJECT_ID('dbo.usp_DeleteProject', 'P') IS NOT NULL 
    DROP PROCEDURE dbo.usp_DeleteProject;
GO

CREATE PROCEDURE [dbo].[usp_DeleteProject]
    @Pnumber INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        DELETE FROM Works_On WHERE Pno = @Pnumber;
        DELETE FROM Project WHERE Pnumber = @Pnumber;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO
