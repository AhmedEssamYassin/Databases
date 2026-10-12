namespace DBapplication
{
    partial class EmployeeReportForm
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
            this.txtDepartmentNo = new System.Windows.Forms.TextBox();
            this.btnFilterEmployees = new System.Windows.Forms.Button();
            this.lblDepartmentNo = new System.Windows.Forms.Label();
            this.employeeReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.companyDataSet = new DBapplication.CompanyDataSet();
            this.employeeTableAdapter = new DBapplication.CompanyDataSetTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDepartmentNo
            // 
            this.txtDepartmentNo.Location = new System.Drawing.Point(130, 10);
            this.txtDepartmentNo.Name = "txtDepartmentNo";
            this.txtDepartmentNo.Size = new System.Drawing.Size(100, 20);
            this.txtDepartmentNo.TabIndex = 0;
            // 
            // btnFilterEmployees
            // 
            this.btnFilterEmployees.Location = new System.Drawing.Point(240, 8);
            this.btnFilterEmployees.Name = "btnFilterEmployees";
            this.btnFilterEmployees.Size = new System.Drawing.Size(75, 23);
            this.btnFilterEmployees.TabIndex = 2;
            this.btnFilterEmployees.Text = "Filter";
            this.btnFilterEmployees.UseVisualStyleBackColor = true;
            this.btnFilterEmployees.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblDepartmentNo
            // 
            this.lblDepartmentNo.AutoSize = true;
            this.lblDepartmentNo.Location = new System.Drawing.Point(10, 13);
            this.lblDepartmentNo.Name = "lblDepartmentNo";
            this.lblDepartmentNo.Size = new System.Drawing.Size(109, 13);
            this.lblDepartmentNo.TabIndex = 1;
            this.lblDepartmentNo.Text = "Department Number:";
            // 
            // employeeReportViewer
            // 
            this.employeeReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeReportViewer.LocalReport.ReportEmbeddedResource = "DBapplication.EmployeeReport.rdlc";
            this.employeeReportViewer.Location = new System.Drawing.Point(0, 40);
            this.employeeReportViewer.Name = "employeeReportViewer";
            this.employeeReportViewer.ServerReport.BearerToken = null;
            this.employeeReportViewer.Size = new System.Drawing.Size(800, 410);
            this.employeeReportViewer.TabIndex = 3;
            // 
            // companyDataSet
            // 
            this.companyDataSet.DataSetName = "CompanyDataSet";
            this.companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeReportViewer);
            this.Controls.Add(this.btnFilterEmployees);
            this.Controls.Add(this.txtDepartmentNo);
            this.Controls.Add(this.lblDepartmentNo);
            this.Name = "EmployeeReportForm";
            this.Text = "Employee Filter Report";
            this.Load += new System.EventHandler(this.EmployeeReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtDepartmentNo;
        private System.Windows.Forms.Button btnFilterEmployees;
        private System.Windows.Forms.Label lblDepartmentNo;
        private Microsoft.Reporting.WinForms.ReportViewer employeeReportViewer;
        private CompanyDataSet companyDataSet;
        private CompanyDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}
