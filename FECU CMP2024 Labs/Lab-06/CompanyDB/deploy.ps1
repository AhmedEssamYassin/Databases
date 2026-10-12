param (
    [string]$ServerInstance = "."
)
$DatabaseName = "CompanyDBLab_06"

Write-Host "Starting Database Deployment..." -ForegroundColor Cyan

# Recreate database
Write-Host "Creating fresh database..." -ForegroundColor Yellow
sqlcmd -S $ServerInstance -b -Q "USE master; IF DB_ID('$DatabaseName') IS NOT NULL BEGIN ALTER DATABASE $DatabaseName SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE $DatabaseName; END; CREATE DATABASE $DatabaseName;"
if ($LASTEXITCODE -ne 0) {
    Write-Error "Failed to recreate database '$DatabaseName'."
    exit $LASTEXITCODE
}

function Execute-SqlFile($filePath) {
    Write-Host "Executing: $filePath" -ForegroundColor Gray
    sqlcmd -S $ServerInstance -d $DatabaseName -b -i $filePath
    if ($LASTEXITCODE -ne 0) {
        Write-Error "Failed to execute: $filePath"
        exit $LASTEXITCODE
    }
}

# Tables and constraints
Write-Host "Applying schemas..." -ForegroundColor Yellow
Execute-SqlFile (Join-Path $PSScriptRoot "schema\01_tables.sql")
Execute-SqlFile (Join-Path $PSScriptRoot "schema\02_constraints.sql")

# Stored procedures
Write-Host "Compiling stored procedures..." -ForegroundColor Yellow
Get-ChildItem (Join-Path $PSScriptRoot "stored_procedures\*.sql") | ForEach-Object {
    Execute-SqlFile $_.FullName
}

# Seed data
Write-Host "Seeding data..." -ForegroundColor Yellow
Execute-SqlFile (Join-Path $PSScriptRoot "seeds\01_base_seeding.sql")
Execute-SqlFile (Join-Path $PSScriptRoot "seeds\02_bulk_seeding.sql")

Write-Host "Deployment Completed Successfully!" -ForegroundColor Green
