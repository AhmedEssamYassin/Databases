using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class EmployeeReportForm : Form
    {
        public EmployeeReportForm()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int? departmentNo = null;
            string input = txtDepartmentNo.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out int parsedDno))
                {
                    departmentNo = parsedDno;
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric department number or leave blank to show all employees.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                this.employeeTableAdapter.Fill(this.companyDataSet.Employee, departmentNo);

                this.employeeReportViewer.LocalReport.DataSources.Clear();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource(
                    "EmployeeDataSet",
                    (System.Data.DataTable)this.companyDataSet.Employee
                );
                this.employeeReportViewer.LocalReport.DataSources.Add(rds);

                this.employeeReportViewer.RefreshReport();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("A database error occurred while loading the employee report: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.Fill(this.companyDataSet.Employee, null);

                this.employeeReportViewer.LocalReport.DataSources.Clear();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource(
                    "EmployeeDataSet",
                    (System.Data.DataTable)this.companyDataSet.Employee
                );
                this.employeeReportViewer.LocalReport.DataSources.Add(rds);

                this.employeeReportViewer.RefreshReport();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("A database error occurred while loading the employee report: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
