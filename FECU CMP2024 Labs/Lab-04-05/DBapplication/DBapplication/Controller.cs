using System;
using System.Collections.Generic;
using System.Data;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int CheckAdmin(string Name, string Password)
        {
            string query = "SELECT COUNT(AdminID) FROM Admin WHERE username = @username AND password = @password;";
            var parameters = new Dictionary<string, object>
            {
                { "@username", Name },
                { "@password", Password }
            };
            return (int)dbMan.ExecuteScalar(query, parameters);
        }

        public int InsertEmployee(string EFname, string EMinit, string ELname, long ESSN, string EAddress, string EBDate, string EGender, int EDeptNo, int ESalary, long? ESuperSSN)
        {
            string query = "INSERT INTO Employee (Fname, Minit, Lname, SSN, Bdate, Address, Sex, Dno, Salary, Super_SSN) " +
                           "VALUES (@Fname, @Minit, @Lname, @SSN, @Bdate, @Address, @Sex, @Dno, @Salary, @Super_SSN);";
            string minit = string.IsNullOrWhiteSpace(EMinit) ? " " : EMinit;
            var parameters = new Dictionary<string, object>
            {
                { "@Fname", EFname },
                { "@Minit", minit },
                { "@Lname", ELname },
                { "@SSN", ESSN },
                { "@Bdate", EBDate },
                { "@Address", EAddress },
                { "@Sex", EGender },
                { "@Dno", EDeptNo },
                { "@Salary", ESalary },
                { "@Super_SSN", ESuperSSN.HasValue ? (object)ESuperSSN.Value : DBNull.Value }
            };
            return dbMan.ExecuteNonQuery(query, parameters);
        }

        public int UpdateEmployee(Dictionary<string, object> changes, long SSN)
        {
            if (changes.Count == 0) return 0;

            var parameters = new Dictionary<string, object>(changes);

            if (parameters.ContainsKey("@Minit"))
            {
                var minitVal = parameters["@Minit"];
                if (minitVal == null || minitVal == DBNull.Value || string.IsNullOrWhiteSpace(minitVal.ToString()))
                {
                    parameters["@Minit"] = " ";
                }
            }

            var setClauses = new List<string>();
            foreach (var key in parameters.Keys)
            {
                // key is like "@Fname" — strip @ for column name, keep for parameter
                string columnName = key.TrimStart('@');
                setClauses.Add(columnName + " = " + key);
            }

            string query = "UPDATE Employee SET " + string.Join(", ", setClauses) + " WHERE SSN = @SSNCondition;";
            parameters["@SSNCondition"] = SSN;

            return dbMan.ExecuteNonQuery(query, parameters);
        }

        public int DeleteEmployee(long SSN)
        {
            string query = "usp_DeleteEmployee";
            var parameters = new Dictionary<string, object> { { "@SSN", SSN } };
            return dbMan.ExecuteNonQuery(query, parameters, true);
        }

        public DataTable SelectEmployee(long SSN)
        {
            string query = "SELECT * FROM Employee WHERE SSN = @SSN;";
            var parameters = new Dictionary<string, object> { { "@SSN", SSN } };
            return dbMan.ExecuteReader(query, parameters);
        }

        public DataTable SelectALLEmployees()
        {
            string query = "SELECT * FROM Employee;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectSupervisors()
        {
            string query = "SELECT Fname + ' ' + Lname AS DisplayName, SSN FROM Employee;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDepartmentNames()
        {
            string query = "SELECT Dname, Dnumber FROM Department;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDeptEmployee(int Dno)
        {
            string query = "SELECT * FROM Employee WHERE Dno = @Dno;";
            var parameters = new Dictionary<string, object> { { "@Dno", Dno } };
            return dbMan.ExecuteReader(query, parameters);
        }

        public DataTable SelectProjectNames()
        {
            string query = "SELECT Pname, Pnumber FROM Project;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmployeesByProject(int Pnumber)
        {
            string query = "SELECT E.* FROM Employee E JOIN Works_On W ON E.SSN = W.ESSN WHERE W.Pno = @Pnumber;";
            var parameters = new Dictionary<string, object> { { "@Pnumber", Pnumber } };
            return dbMan.ExecuteReader(query, parameters);
        }

        public int SelectProjEmployeeCount(int PrjNo)
        {
            string query = "SELECT COUNT(E.SSN) AS EmployeeCount FROM Employee E JOIN Works_On W ON E.SSN = W.ESSN WHERE W.Pno = @Pno;";
            var parameters = new Dictionary<string, object> { { "@Pno", PrjNo } };
            return (int)dbMan.ExecuteScalar(query, parameters);
        }

        public int DeleteProject(int Pnumber)
        {
            string query = @"
                SET XACT_ABORT ON;
                BEGIN TRANSACTION;
                SET NOCOUNT ON;
                DELETE FROM Works_On WHERE Pno = @Pno;
                SET NOCOUNT OFF;
                DELETE FROM Project WHERE Pnumber = @Pno;
                COMMIT TRANSACTION;";
            var parameters = new Dictionary<string, object> { { "@Pno", Pnumber } };
            return dbMan.ExecuteNonQuery(query, parameters);
        }

        public DataTable SearchEmployees(string keyword)
        {
            string query = "SELECT * FROM Employee WHERE Fname LIKE @keyword OR Lname LIKE @keyword OR CAST(SSN AS VARCHAR) LIKE @keyword;";
            var parameters = new Dictionary<string, object> { { "@keyword", "%" + keyword + "%" } };
            return dbMan.ExecuteReader(query, parameters);
        }

        public int InsertSupplier(string SNum, string SName, string City, int Status)
        {
            string query = "INSERT INTO Supplier (SNum, SName, City, Status) VALUES (@SNum, @SName, @City, @Status);";
            var parameters = new Dictionary<string, object>
            {
                { "@SNum", int.Parse(SNum) },
                { "@SName", SName },
                { "@City", City },
                { "@Status", Status }
            };
            return dbMan.ExecuteNonQuery(query, parameters);
        }

        public int DeleteSupplier(string SNum)
        {
            string query = "DELETE FROM Supplier WHERE SNum = @SNum;";
            var parameters = new Dictionary<string, object> { { "@SNum", int.Parse(SNum) } };
            return dbMan.ExecuteNonQuery(query, parameters);
        }

        public int UpdateSupplier(string SNum, string City)
        {
            string query = "UPDATE Supplier SET City = @City WHERE SNum = @SNum;";
            var parameters = new Dictionary<string, object>
            {
                { "@SNum", int.Parse(SNum) },
                { "@City", City }
            };
            return dbMan.ExecuteNonQuery(query, parameters);
        }

        public DataTable SelectAllSuppliers()
        {
            string query = "SELECT * FROM Supplier;";
            return dbMan.ExecuteReader(query);
        }

        public int CountSuppliers()
        {
            string query = "SELECT COUNT(SNum) FROM Supplier;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable SelectDepLoc()
        {
            string query = "SELECT DISTINCT Dlocation FROM Dept_Locations;";
            return dbMan.ExecuteReader(query);
        }

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
    }
}
