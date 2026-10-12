# Lab 4 & 5 — Accessing SQL Server Database from C# Application

## Problem Context

You are tasked with assisting a company manager in utilizing an alternative system to execute basic operations on his employees, departments, and monitor his projects.

---

## Lab 4 — Assignment Requirements

Use file `CompanyDBLab_04_05.sql` of the DB folder to create and fill the company database. Create a simple Windows application that connects to the company database. The application should allow the user to:

1. **Insert** new employees.
2. **Update** the information of a certain employee.
3. **Get all employees** who work in a certain department.
4. **Get the number of employees** who work on a certain project.
5. **Delete** a project.

> **Note:** Your C# project must not contain any files from other labs or requirements files.

---

## Lab 4 — Tutorial Guide (Accessing DB from C# App – Part 1)

### Objectives

After this lab, the student should be able to use Visual Studio to:

- Create a simple Windows application using C#.
- Write scripts to create database, create tables, or fill tables data.
- Connect a C# application to a database.
- Execute simple SQL queries on the database by calling direct SQL statements in C# application.

### Lab Outline

#### I. Create a Windows Application

1. Open Visual Studio → File → New → Project → Visual C# → Windows Forms Application.
2. The application creates a default form. Add more forms via right-click on project → Add Windows Form.
3. Add GUI elements (Label, Textbox, Button) from the Toolbox.
4. Add event handlers by double-clicking buttons.
5. Run the application (`CTRL+F5`).

#### II. Create a Data Connection to SQL Server

**A. Make sure SQL Server is running:**
- Open "Local Services" and verify "SQL Server" is started.

**B. Make sure the database is created:**
1. Open SQL Server Management Studio and connect.
2. File → Open → Browse to the SQL script (`CompanyDBLab_04_05.sql`).
3. Execute the script — it creates the database, tables, and fills them with sample data.

**C. Create a database connection in Visual Studio:**
1. Server Explorer → right-click Data Connections → Add Connection.
2. Choose Microsoft SQL Server as the data source.
3. Select server name, authentication method, and the target database.

#### III. Get the Connection String

1. In Server Explorer, right-click the database connection → Properties.
2. Copy the **Connection String** property value.

The application uses three key classes from `System.Data.SqlClient`:
- `SqlConnection` — opens a connection to the database.
- `SqlCommand` — executes queries and stored procedures.
- `SqlDataReader` — reads result sets.

#### IV. Open the Connection (using App.config)

Connection strings should be read from a configuration file, not hardcoded. Add to `App.config`:

```xml
<configuration>
  <connectionStrings>
    <add name="MyConnectionString"
         connectionString="Data Source=.;Initial Catalog=CompanyDBLab_04_05;Integrated Security=True"/>
  </connectionStrings>
</configuration>
```

Read in C#:

```csharp
using System.Configuration;
string DB_Connection_String =
    ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
```

#### V. Insert Query Command

Use `SqlCommand.ExecuteNonQuery()` for INSERT/DELETE/UPDATE statements.

**Flow:** GUI takes input → Controller builds the query → DBManager executes it.

```csharp
// Controller.cs
public int InsertSupplier(string snum, string sname, string city, int status)
{
    string query = "INSERT INTO Supplier (SNum, SName, City, Status) VALUES (@SNum, @SName, @City, @Status);";
    var parameters = new Dictionary<string, object>
    {
        { "@SNum", int.Parse(snum) },
        { "@SName", sname },
        { "@City", city },
        { "@Status", status }
    };
    return dbMan.ExecuteNonQuery(query, parameters);
}
```

```csharp
// DBManager.cs
public int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
{
    SqlCommand myCommand = CreateCommand(query, parameters);
    return myCommand.ExecuteNonQuery();
}
```

#### VI. Delete Query Command

Same `ExecuteNonQuery()` pattern:

```csharp
public int DeleteSupplier(string snum)
{
    string query = "DELETE FROM Supplier WHERE SNum = @SNum;";
    var parameters = new Dictionary<string, object> { { "@SNum", int.Parse(snum) } };
    return dbMan.ExecuteNonQuery(query, parameters);
}
```

#### VII. Update Query Command

```csharp
public int UpdateSupplier(string snum, string city)
{
    string query = "UPDATE Supplier SET City = @City WHERE SNum = @SNum;";
    var parameters = new Dictionary<string, object>
    {
        { "@SNum", int.Parse(snum) },
        { "@City", city }
    };
    return dbMan.ExecuteNonQuery(query, parameters);
}
```

#### VIII. Select Query — Returns a Scalar

Use `SqlCommand.ExecuteScalar()` for queries that return a single value:

```csharp
// Controller.cs
public int CountSuppliers()
{
    string query = "SELECT COUNT(SNum) FROM Supplier;";
    return (int) dbMan.ExecuteScalar(query);
}
```

```csharp
// DBManager.cs
public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
{
    SqlCommand myCommand = CreateCommand(query, parameters);
    return myCommand.ExecuteScalar();
}
```

#### IX. Select Query — Returns a DataTable

Use `SqlCommand.ExecuteReader()` for queries that return rows:

```csharp
// Controller.cs
public DataTable SelectAllSuppliers()
{
    string query = "SELECT * FROM Supplier;";
    return dbMan.ExecuteReader(query);
}
```

```csharp
// DBManager.cs
public DataTable ExecuteReader(string query, Dictionary<string, object> parameters = null)
{
    SqlCommand myCommand = CreateCommand(query, parameters);
    SqlDataReader reader = myCommand.ExecuteReader();
    if (reader.HasRows)
    {
        DataTable dt = new DataTable();
        dt.Load(reader);
        reader.Close();
        return dt;
    }
    reader.Close();
    return null;
}
```

#### X. Close the Connection

```csharp
public void CloseConnection()
{
    myConnection.Close();
}
```

---

## Lab 5 — Tutorial Guide (Accessing DB from C# App – Part 2)

### Objectives

After this lab, the student should be able to:

- Create and fill a database using SQL statements.
- Connect a C# application to a database.
- Execute SQL queries on the database by calling direct SQL statements in C# application.

### Database Creation using SQL Statements

Script `CompanyDB.sql` does the following:

1. Creates a new DB called `CompanyLab2` (`CREATE DATABASE`).
2. Creates tables: Employee, Department, Dept_Locations, Project, Works_On (`CREATE TABLE`).
3. Creates primary and foreign keys for each table (`CREATE/ALTER TABLE`).
4. Fills tables with sample data (`INSERT INTO`).
5. Completes table filling (`UPDATE`).

### Application Architecture (Three-Tier)

The application consists of three modules:

```
GUI  →  Controller  →  DBManager
```

- **GUI** — the user interacts with the forms to specify functionality.
- **Controller** — controls program flow; the GUI calls the controller when a button is clicked.
- **DBManager** — handles all database operations; the controller calls this class for any DB action.

> Note: Controller and DBManager are user-defined classes, not library classes.

### Executing Complex Queries

Example: "Select project name and department name for all projects in departments located in a certain location" (location specified by user via a ComboBox).

Steps:

1. Add a button for the functionality in the main form.
2. Create a new Windows Form (`RetrieveProjects`) with a **ComboBox** and a **DataGridView**.
3. Populate the ComboBox from the `Dlocation` column in `Dept_Locations` using `DISTINCT`:

```csharp
// Controller.cs
public DataTable SelectDepLoc()
{
    string query = "SELECT DISTINCT Dlocation FROM Dept_Locations;";
    return dbMan.ExecuteReader(query);
}
```

4. Set the ComboBox datasource and `DisplayMember` in the form constructor.
5. On "Execute" button click, run the join query and bind results to the DataGridView:

```csharp
// Controller.cs
public DataTable SelectProject(string location)
{
    string query = @"SELECT Pname, Dname 
                     FROM Department D 
                     JOIN Project P ON P.Dnum = D.Dnumber 
                     JOIN Dept_Locations L ON L.Dnumber = D.Dnumber 
                     WHERE L.Dlocation = @location;";
    var parameters = new Dictionary<string, object>
    {
        { "@location", location }
    };
    return dbMan.ExecuteReader(query, parameters);
}
```
