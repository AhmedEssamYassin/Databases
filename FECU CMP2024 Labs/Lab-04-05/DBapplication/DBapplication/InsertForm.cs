using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace DBapplication
{
    public partial class InsertForm : MaterialForm
    {
        private Controller controllerObj;

        public InsertForm()
        {
            InitializeComponent();
            controllerObj = new Controller();
            MaterialThemeManager.Initialize(this);
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectDepartmentNames();
            if (dt != null)
            {
                cmbDeptNo.DataSource = dt;
                cmbDeptNo.DisplayMember = "Dname";
                cmbDeptNo.ValueMember = "Dnumber";
            }

            DataTable supervisorsDt = controllerObj.SelectSupervisors();
            if (supervisorsDt != null)
            {
                supervisorsDt.Columns["SSN"].ReadOnly = false;
                supervisorsDt.Columns["SSN"].AllowDBNull = true;
                DataRow noSupervisorRow = supervisorsDt.NewRow();
                noSupervisorRow["DisplayName"] = "(No Supervisor)";
                noSupervisorRow["SSN"] = DBNull.Value;
                supervisorsDt.Rows.InsertAt(noSupervisorRow, 0);

                cmbSupervisor.DataSource = supervisorsDt;
                cmbSupervisor.DisplayMember = "DisplayName";
                cmbSupervisor.ValueMember = "SSN";
            }
        }

        private void AddButton_MouseClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(SSNTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(SalaryTextBox.Text) ||
                cmbGender.SelectedItem == null ||
                cmbDeptNo.SelectedValue == null)
            {
                MessageBox.Show("Please fill out all required fields before submitting.");
                return;
            }

            if (!long.TryParse(SSNTextBox.Text, out long ssn))
            {
                MessageBox.Show("SSN must be a valid number.");
                return;
            }

            if (!decimal.TryParse(SalaryTextBox.Text, out decimal salary))
            {
                MessageBox.Show("Salary must be a valid number.");
                return;
            }

            string bDate = dtpBDate.Value.ToString("yyyy-MM-dd");
            string gender = cmbGender.SelectedItem.ToString();
            int deptNo = (int)cmbDeptNo.SelectedValue;
            string minit = string.IsNullOrWhiteSpace(MinitTextBox.Text) ? null : MinitTextBox.Text;

            long? superSsn = null;
            if (cmbSupervisor.SelectedValue != null && cmbSupervisor.SelectedValue != DBNull.Value)
            {
                superSsn = Convert.ToInt64(cmbSupervisor.SelectedValue);
            }

            int result = controllerObj.InsertEmployee(FnameTextBox.Text, minit, LnameTextBox.Text, ssn, AddressTextBox.Text, bDate, gender, deptNo, salary, superSsn);

            if (result == 0)
            {
                MessageBox.Show("The insertion of a new Employee failed.");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            controllerObj.TerminateConnection();
            base.OnFormClosed(e);
        }
    }
}
