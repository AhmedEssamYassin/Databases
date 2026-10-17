using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ViewDepartmentStatistics : Form
    {
        public ViewDepartmentStatistics()
        {
            InitializeComponent();
        }

        private void ViewDepartmentStatistics_Load(object sender, EventArgs e)
        {
            try
            {
                this.departmentStatisticsTableAdapter.Fill(this.companyDataSet.DepartmentStatistics);

                this.deptStatsReportViewer.LocalReport.DataSources.Clear();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource(
                    "DepartmentDataSet",
                    (System.Data.DataTable)this.companyDataSet.DepartmentStatistics
                );
                this.deptStatsReportViewer.LocalReport.DataSources.Add(rds);

                this.deptStatsReportViewer.RefreshReport();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("A database error occurred while loading department statistics: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
