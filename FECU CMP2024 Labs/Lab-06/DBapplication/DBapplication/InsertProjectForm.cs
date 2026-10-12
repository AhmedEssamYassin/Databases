using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace DBapplication
{
    public partial class InsertProjectForm : MaterialForm
    {
        private Controller controllerObj;

        public InsertProjectForm()
        {
            InitializeComponent();
            controllerObj = new Controller();
            MaterialThemeManager.Initialize(this);
        }

        private void InsertProjectForm_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectDepartmentNames();
            if (dt != null)
            {
                cmbDepartment.DataSource = dt;
                cmbDepartment.DisplayMember = "Dname";
                cmbDepartment.ValueMember = "Dnumber";
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(PnumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(PlocationTextBox.Text) ||
                cmbDepartment.SelectedValue == null)
            {
                MessageBox.Show("Please fill out all required fields before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(PnumberTextBox.Text.Trim(), out int pnumber) || pnumber <= 0)
            {
                MessageBox.Show("Project Number must be a valid positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int deptNo = Convert.ToInt32(cmbDepartment.SelectedValue);

            int result = controllerObj.InsertProject(PnameTextBox.Text.Trim(), pnumber, PlocationTextBox.Text.Trim(), deptNo);

            if (result == 0)
            {
                MessageBox.Show("Failed to insert the project. The project number may already exist or a database constraint failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Project created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (controllerObj != null)
            {
                controllerObj.TerminateConnection();
            }
            base.OnFormClosed(e);
        }
    }
}
