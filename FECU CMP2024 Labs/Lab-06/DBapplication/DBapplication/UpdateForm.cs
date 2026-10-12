using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace DBapplication
{
    public partial class UpdateForm : MaterialForm
    {
        private Controller controllerObj;
        private long _currentSSN; 
        private bool _bdateEditable = true;
        private bool _bdateChanged = false;

        public UpdateForm() : this(0) { }

        public UpdateForm(long ssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            _currentSSN = ssn;
            MaterialThemeManager.Initialize(this);
        }

        private void UpdateForm_Load(object sender, EventArgs e)
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

                // Remove current employee from supervisor options to prevent self-supervision cycle
                if (_currentSSN != 0)
                {
                    for (int i = supervisorsDt.Rows.Count - 1; i >= 0; i--)
                    {
                        if (supervisorsDt.Rows[i]["SSN"] != DBNull.Value && Convert.ToInt64(supervisorsDt.Rows[i]["SSN"]) == _currentSSN)
                        {
                            supervisorsDt.Rows.RemoveAt(i);
                            break;
                        }
                    }
                }

                DataRow noSupervisorRow = supervisorsDt.NewRow();
                noSupervisorRow["DisplayName"] = "(No Supervisor)";
                noSupervisorRow["SSN"] = DBNull.Value;
                supervisorsDt.Rows.InsertAt(noSupervisorRow, 0);

                cmbSupervisor.DataSource = supervisorsDt;
                cmbSupervisor.DisplayMember = "DisplayName";
                cmbSupervisor.ValueMember = "SSN";
            }

            LoadEmployeeData(_currentSSN);
        }

        private void LoadEmployeeData(long ssn)
        {
            if (ssn == 0) return;

            DataTable dataTable = controllerObj.SelectEmployee(ssn);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                FnameTextBox.Text = row["Fname"].ToString();
                MinitTextBox.Text = row["Minit"].ToString();
                LnameTextBox.Text = row["Lname"].ToString();
                SSNTextBox.Text = row["SSN"].ToString();
                
                if (DateTime.TryParse(row["BDate"].ToString(), out DateTime dt))
                    dtpBDate.Value = dt;
                else
                {
                    // NULL Bdate in DB: only write one if the user explicitly picks a date
                    _bdateEditable = false;
                    dtpBDate.ValueChanged += (s, ev) => _bdateChanged = true;
                }

                AddressTextBox.Text = row["Address"].ToString();
                
                string sex = row["Sex"].ToString();
                if (sex == "M" || sex == "F") cmbGender.SelectedItem = sex;

                if (row["Dno"] != DBNull.Value)
                    cmbDeptNo.SelectedValue = Convert.ToInt32(row["Dno"]);

                if (row.Table.Columns.Contains("Salary") && row["Salary"] != DBNull.Value)
                    SalaryTextBox.Text = Convert.ToDecimal(row["Salary"]).ToString("0.##");

                if (row.Table.Columns.Contains("Super_SSN") && row["Super_SSN"] != DBNull.Value)
                    cmbSupervisor.SelectedValue = Convert.ToInt64(row["Super_SSN"]);
            }
            else
            {
                MessageBox.Show("Error: Employee not found!");
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(SalaryTextBox.Text) ||
                cmbGender.SelectedItem == null ||
                cmbDeptNo.SelectedValue == null)
            {
                MessageBox.Show("Please fill out all required fields before saving.");
                return;
            }

            if (!int.TryParse(SalaryTextBox.Text.Trim(), out int salary) || salary < 0)
            {
                MessageBox.Show("Salary must be a valid non-negative integer.");
                return;
            }

            if (cmbSupervisor.SelectedValue != null && cmbSupervisor.SelectedValue != DBNull.Value)
            {
                if (Convert.ToInt64(cmbSupervisor.SelectedValue) == _currentSSN)
                {
                    MessageBox.Show("An employee cannot be their own supervisor.");
                    return;
                }
            }

            var changes = new Dictionary<string, object>
            {
                { "@Fname", FnameTextBox.Text },
                { "@Minit", string.IsNullOrWhiteSpace(MinitTextBox.Text) ? (object)DBNull.Value : MinitTextBox.Text },
                { "@Lname", LnameTextBox.Text },
                { "@Address", AddressTextBox.Text },
                { "@Sex", cmbGender.SelectedItem.ToString() },
                { "@Dno", (int)cmbDeptNo.SelectedValue },
                { "@Salary", salary },
                { "@Super_SSN", (cmbSupervisor.SelectedValue != null && cmbSupervisor.SelectedValue != DBNull.Value) ? cmbSupervisor.SelectedValue : DBNull.Value }
            };

            if (_bdateEditable || _bdateChanged)
                changes["@Bdate"] = dtpBDate.Value.ToString("yyyy-MM-dd");

            try
            {
                int result = controllerObj.UpdateEmployee(changes, _currentSSN);
                if (result == 0)
                    MessageBox.Show("The Update of Data failed");
                else
                {
                    MessageBox.Show("Data updated successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
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