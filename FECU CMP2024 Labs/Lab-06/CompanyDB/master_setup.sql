USE master;
GO

IF DB_ID('CompanyDBLab_06') IS NOT NULL 
BEGIN
    ALTER DATABASE CompanyDBLab_06 SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE CompanyDBLab_06;
END
GO

CREATE DATABASE CompanyDBLab_06;
GO

USE CompanyDBLab_06;
GO

-- Schema
:r .\schema\01_tables.sql
:r .\schema\02_constraints.sql

-- Stored Procedures
:r .\stored_procedures\getAllEmps.sql
:r .\stored_procedures\SelectDepartmentLocation.sql
:r .\stored_procedures\insertProject.sql
:r .\stored_procedures\selectDepartmentNum.sql
:r .\stored_procedures\selectProjectsofDeptLoc.sql
:r .\stored_procedures\usp_SearchEmployees.sql
:r .\stored_procedures\usp_GetProjectEmployeeCount.sql
:r .\stored_procedures\usp_DeleteProject.sql
:r .\stored_procedures\usp_DeleteEmployee.sql

-- Seed Data
:r .\seeds\01_base_seeding.sql
:r .\seeds\02_bulk_seeding.sql

PRINT 'Database setup completed successfully.';
GO
