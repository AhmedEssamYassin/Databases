using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace DBapplication
{
    public partial class Dashboard : MaterialForm
    {
        private Controller controllerObj;
        private Form loginForm;
        private bool isLoggingOut = false;

        public Dashboard(Form parentLogin) : this()
        {
            this.loginForm = parentLogin;
        }

        public Dashboard()
        {
            InitializeComponent();
            controllerObj = new Controller();

            comboType.SelectedIndex = 0;
            comboType_SelectedIndexChanged(this, EventArgs.Empty);

            RefreshGrid();

            EmployeeTable.CellContentClick += EmployeeTable_CellContentClick;
            this.Resize += Dashboard_Resize;

            MaterialThemeManager.Initialize(this);
            var isDark = MaterialSkin.MaterialSkinManager.Instance.Theme == MaterialSkin.MaterialSkinManager.Themes.DARK;
            btnThemeToggle.Text = isDark ? "Light Mode" : "Dark Mode";
            MaterialThemeManager.StyleSidebarPanel(panelSidebar, isDark);
            MaterialThemeManager.StyleDataGridView(EmployeeTable);
            MaterialThemeManager.AutoFitGridColumns(EmployeeTable);
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboValue.DataSource = null;
            comboValue.Items.Clear();

            string selectedType = comboType.SelectedItem?.ToString();

            if (selectedType == "None")
            {
                comboValue.Visible = false;
            }
            else if (selectedType == "Department")
            {
                comboValue.Visible = true;
                DataTable dt = controllerObj.SelectDepartmentNames();
                if (dt != null)
                {
                    DataRow topRow = dt.NewRow();
                    topRow["Dname"] = "(All Departments)";
                    topRow["Dnumber"] = -1;
                    dt.Rows.InsertAt(topRow, 0);

                    comboValue.DataSource = dt;
                    comboValue.DisplayMember = "Dname";
                    comboValue.ValueMember = "Dnumber";
                }
            }
            else if (selectedType == "Project")
            {
                comboValue.Visible = true;
                DataTable dt = controllerObj.SelectProjectNames();
                if (dt != null)
                {
                    DataRow topRow = dt.NewRow();
                    topRow["Pname"] = "(All Projects)";
                    topRow["Pnumber"] = -1;
                    dt.Rows.InsertAt(topRow, 0);

                    comboValue.DataSource = dt;
                    comboValue.DisplayMember = "Pname";
                    comboValue.ValueMember = "Pnumber";
                }
            }

            RefreshGrid();
        }

        private void comboValue_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            string type = comboType.SelectedItem?.ToString();
            int id = -1;

            if (comboValue.SelectedValue != null)
            {
                int.TryParse(comboValue.SelectedValue.ToString(), out id);
            }

            if (type == "Project")
            {
                panelProjectActions.Visible = true;
                btnCountEmployees.Enabled = (id != -1);
                btnDeleteProject.Enabled = (id != -1);
            }
            else
            {
                panelProjectActions.Visible = false;
            }

            DataTable dt;

            if (type == "None" || id == -1 || type == null)
                dt = controllerObj.SelectALLEmployees();
            else if (type == "Department")
                dt = controllerObj.SelectDeptEmployee(id);
            else if (type == "Project")
                dt = controllerObj.SelectEmployeesByProject(id);
            else
                dt = controllerObj.SelectALLEmployees();

            EmployeeTable.DataSource = dt;
            FormatGridColumns();
            MaterialThemeManager.StyleDataGridView(EmployeeTable);
            MaterialThemeManager.AutoFitGridColumns(EmployeeTable);
        }

        private void FormatGridColumns()
        {
            if (EmployeeTable.Columns.Contains("Fname")) EmployeeTable.Columns["Fname"].HeaderText = "First Name";
            if (EmployeeTable.Columns.Contains("Minit")) EmployeeTable.Columns["Minit"].HeaderText = "M.I.";
            if (EmployeeTable.Columns.Contains("Lname")) EmployeeTable.Columns["Lname"].HeaderText = "Last Name";
            if (EmployeeTable.Columns.Contains("Bdate")) EmployeeTable.Columns["Bdate"].HeaderText = "Birth Date";
            if (EmployeeTable.Columns.Contains("Sex")) EmployeeTable.Columns["Sex"].HeaderText = "Gender";
            if (EmployeeTable.Columns.Contains("Dno")) EmployeeTable.Columns["Dno"].HeaderText = "Dept No";
            if (EmployeeTable.Columns.Contains("Super_SSN")) EmployeeTable.Columns["Super_SSN"].HeaderText = "Supervisor SSN";
            if (EmployeeTable.Columns.Contains("Salary")) EmployeeTable.Columns["Salary"].HeaderText = "Salary ($)";

            EmployeeTable.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                DataTable dt = controllerObj.SearchEmployees(txtSearch.Text.Trim());
                EmployeeTable.DataSource = dt;
                FormatGridColumns();
                MaterialThemeManager.StyleDataGridView(EmployeeTable);
                MaterialThemeManager.AutoFitGridColumns(EmployeeTable);
            }
            else
            {
                RefreshGrid();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm();
            insertForm.ShowDialog();
            RefreshGrid();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            Supplier supplierForm = new Supplier();
            supplierForm.ShowDialog();
        }

        private void btnRetrieveProjects_Click(object sender, EventArgs e)
        {
            RetrieveProjects retrieveForm = new RetrieveProjects();
            retrieveForm.ShowDialog();
        }

        private void btnReportViewer_Click(object sender, EventArgs e)
        {
            EmployeeReportForm form = new EmployeeReportForm();
            form.ShowDialog();
        }

        private void btnDeptStats_Click(object sender, EventArgs e)
        {
            ViewDepartmentStatistics form = new ViewDepartmentStatistics();
            form.ShowDialog();
        }

        private void btnInsertProject_Click(object sender, EventArgs e)
        {
            InsertProjectForm form = new InsertProjectForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                comboType_SelectedIndexChanged(sender, e);
            }
        }

        private void btnCountEmployees_Click(object sender, EventArgs e)
        {
            if (comboValue.SelectedValue != null)
            {
                int id = -1;
                if (int.TryParse(comboValue.SelectedValue.ToString(), out id) && id != -1)
                {
                    int count = controllerObj.SelectProjEmployeeCount(id);
                    if (count < 0) return;
                    string projName = comboValue.Text;
                    MessageBox.Show($"Number of employees working on project '{projName}': {count}", "Project Employee Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            if (comboValue.SelectedValue != null)
            {
                int id = -1;
                if (int.TryParse(comboValue.SelectedValue.ToString(), out id) && id != -1)
                {
                    string projName = comboValue.Text;
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete project '{projName}' and all its works-on associations?", "Confirm Delete Project", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int r = controllerObj.DeleteProject(id);
                        if (r > 0 || r == -1)
                        {
                            MessageBox.Show("Project deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            comboType_SelectedIndexChanged(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete project.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            isLoggingOut = true;
            if (loginForm is Login parent)
            {
                parent.ResetLoginFields();
                parent.Show();
                this.Close();
            }
            else
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (EmployeeTable.SelectedRows.Count > 0)
            {
                var cellValue = EmployeeTable.SelectedRows[0].Cells["SSN"].Value;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    long ssn = Convert.ToInt64(cellValue);
                    UpdateForm updateForm = new UpdateForm(ssn);
                    updateForm.ShowDialog();
                    RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee row first to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (EmployeeTable.SelectedRows.Count > 0)
            {
                var cellValue = EmployeeTable.SelectedRows[0].Cells["SSN"].Value;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    long ssn = Convert.ToInt64(cellValue);
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int r = controllerObj.DeleteEmployee(ssn);
                        if (r > 0 || r == -1)
                            MessageBox.Show("Employee deleted successfully.");
                        else
                            MessageBox.Show("Deletion failed.");

                        RefreshGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee row first to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EmployeeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnTabEmployees_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            comboType.SelectedIndex = 0;
            comboType_SelectedIndexChanged(sender, e);
        }

        private void btnThemeToggle_Click(object sender, EventArgs e)
        {
            MaterialThemeManager.ToggleTheme();
            var manager = MaterialSkin.MaterialSkinManager.Instance;
            bool isDark = manager.Theme == MaterialSkin.MaterialSkinManager.Themes.DARK;
            btnThemeToggle.Text = isDark ? "Light Mode" : "Dark Mode";
            MaterialThemeManager.StyleSidebarPanel(panelSidebar, isDark);
            MaterialThemeManager.StyleDataGridView(EmployeeTable);
            MaterialThemeManager.AutoFitGridColumns(EmployeeTable);
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            if (EmployeeTable.DataSource != null)
            {
                MaterialThemeManager.AutoFitGridColumns(EmployeeTable);
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            controllerObj.TerminateConnection();
            if (!isLoggingOut)
            {
                Environment.Exit(0);
            }
        }
    }
}
