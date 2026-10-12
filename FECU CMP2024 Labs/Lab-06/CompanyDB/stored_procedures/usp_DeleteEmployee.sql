SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ahmed Yassin
-- Create date: 2026-05-30
-- Description:	User Stored Procedure to safely delete an employee and clean up references
-- =============================================
IF OBJECT_ID('dbo.usp_DeleteEmployee', 'P') IS NOT NULL 
    DROP PROCEDURE dbo.usp_DeleteEmployee;
GO

CREATE PROCEDURE [dbo].[usp_DeleteEmployee]
    @SSN BIGINT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        DELETE FROM Works_On WHERE Essn = @SSN;
        DELETE FROM Dependent WHERE Essn = @SSN;
        UPDATE Department SET Mgr_SSN = NULL WHERE Mgr_SSN = @SSN;
        UPDATE Employee SET Super_SSN = NULL WHERE Super_SSN = @SSN;
        DELETE FROM Employee WHERE SSN = @SSN;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO
