namespace DBapplication
{
    partial class ViewDepartmentStatistics
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.deptStatsReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.companyDataSet = new DBapplication.CompanyDataSet();
            this.departmentStatisticsTableAdapter = new DBapplication.CompanyDataSetTableAdapters.DepartmentStatisticsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // deptStatsReportViewer
            // 
            this.deptStatsReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deptStatsReportViewer.LocalReport.ReportEmbeddedResource = "DBapplication.DepartmentReport.rdlc";
            this.deptStatsReportViewer.Location = new System.Drawing.Point(0, 0);
            this.deptStatsReportViewer.Name = "deptStatsReportViewer";
            this.deptStatsReportViewer.ServerReport.BearerToken = null;
            this.deptStatsReportViewer.Size = new System.Drawing.Size(800, 450);
            this.deptStatsReportViewer.TabIndex = 1;
            // 
            // companyDataSet
            // 
            this.companyDataSet.DataSetName = "CompanyDataSet";
            this.companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentStatisticsTableAdapter
            // 
            this.departmentStatisticsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewDepartmentStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deptStatsReportViewer);
            this.Name = "ViewDepartmentStatistics";
            this.Text = "View Department Statistics";
            this.Load += new System.EventHandler(this.ViewDepartmentStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        private Microsoft.Reporting.WinForms.ReportViewer deptStatsReportViewer;
        private CompanyDataSet companyDataSet;
        private CompanyDataSetTableAdapters.DepartmentStatisticsTableAdapter departmentStatisticsTableAdapter;
    }
}
