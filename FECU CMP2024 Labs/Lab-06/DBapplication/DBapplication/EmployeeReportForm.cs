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
            try
            {
                int departmentNo = int.Parse(txtDepartmentNo.Text);
                this.employeeTableAdapter.Fill(this.companyDataSet.Employee, departmentNo);
                
                this.employeeReportViewer.LocalReport.DataSources.Clear();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource(
                    "EmployeeDataSet",
                    (System.Data.DataTable)this.companyDataSet.Employee
                );
                this.employeeReportViewer.LocalReport.DataSources.Add(rds);
                
                this.employeeReportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid department number: " + ex.Message);
            }
        }

        private void EmployeeReportForm_Load(object sender, EventArgs e)
        {
            this.employeeReportViewer.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource(
                "EmployeeDataSet",
                (System.Data.DataTable)this.companyDataSet.Employee
            );
            this.employeeReportViewer.LocalReport.DataSources.Add(rds);

            this.employeeReportViewer.RefreshReport();
        }
    }
}
