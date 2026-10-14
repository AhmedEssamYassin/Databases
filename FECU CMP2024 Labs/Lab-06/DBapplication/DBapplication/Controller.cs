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
            object result = dbMan.ExecuteScalar(query, parameters);
            return result == null ? 0 : Convert.ToInt32(result);
        }

        public int InsertEmployee(string EFname, string EMinit, string ELname, long ESSN, string EAddress, string EBDate, string EGender, int EDeptNo, decimal ESalary, long? ESuperSSN)
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
            string query = "getAllEmps";
            return dbMan.ExecuteReader(query, null, true);
        }

        public DataTable SelectSupervisors()
        {
            string query = "SELECT Fname + ' ' + Lname AS DisplayName, SSN FROM Employee;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDepartmentNames()
        {
            string query = "selectDepartmentNum";
            return dbMan.ExecuteReader(query, null, true);
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
            string query = "usp_GetProjectEmployeeCount";
            var parameters = new Dictionary<string, object> { { "@Pnumber", PrjNo } };
            object result = dbMan.ExecuteScalar(query, parameters, true);
            return result == null ? -1 : Convert.ToInt32(result);
        }

        public int DeleteProject(int Pnumber)
        {
            string query = "usp_DeleteProject";
            var parameters = new Dictionary<string, object> { { "@Pnumber", Pnumber } };
            return dbMan.ExecuteNonQuery(query, parameters, true);
        }

        public int InsertProject(string Pname, int Pnumber, string Plocation, int Dnum)
        {
            string query = "insertProject";
            var parameters = new Dictionary<string, object>
            {
                { "@Pname", Pname },
                { "@Pnumber", Pnumber },
                { "@Plocation", Plocation },
                { "@Dnum", Dnum }
            };
            return dbMan.ExecuteNonQuery(query, parameters, true);
        }

        public DataTable SearchEmployees(string keyword)
        {
            string query = "usp_SearchEmployees";
            var parameters = new Dictionary<string, object> { { "@SearchVal", keyword } };
            return dbMan.ExecuteReader(query, parameters, true);
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
            object result = dbMan.ExecuteScalar(query);
            return result == null ? -1 : Convert.ToInt32(result);
        }

        public DataTable SelectDepLoc()
        {
            string query = "SelectDepartmentLocation";
            return dbMan.ExecuteReader(query, null, true);
        }

        public DataTable SelectProject(string location)
        {
            string query = "selectProjectsofDeptLoc";
            var parameters = new Dictionary<string, object>
            {
                { "@location", location }
            };
            return dbMan.ExecuteReader(query, parameters, true);
        }
    }
}
