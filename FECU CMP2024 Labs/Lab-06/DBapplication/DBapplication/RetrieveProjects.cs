using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace DBapplication
{
    public partial class RetrieveProjects : MaterialForm
    {
        private Controller controllerObj;

        public RetrieveProjects()
        {
            InitializeComponent();
            controllerObj = new Controller();
            MaterialThemeManager.Initialize(this);
        }

        private void RetrieveProjects_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectDepLoc();
            if (dt != null)
            {
                cmbLocations.DataSource = dt;
                cmbLocations.DisplayMember = "Dlocation";
                cmbLocations.ValueMember = "Dlocation";
            }
        }

        private void FormatGrid()
        {
            if (dgvProjects.Columns.Contains("Pname")) dgvProjects.Columns["Pname"].HeaderText = "Project Name";
            if (dgvProjects.Columns.Contains("Dname")) dgvProjects.Columns["Dname"].HeaderText = "Department Name";
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (cmbLocations.SelectedValue != null)
            {
                string selectedLocation = cmbLocations.SelectedValue.ToString();
                DataTable dt = controllerObj.SelectProject(selectedLocation);
                dgvProjects.DataSource = dt;
                FormatGrid();
                MaterialThemeManager.StyleDataGridView(dgvProjects);
                MaterialThemeManager.AutoFitGridColumns(dgvProjects);
                dgvProjects.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a location.");
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            InsertProjectForm form = new InsertProjectForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                object previous = cmbLocations.SelectedValue;
                RetrieveProjects_Load(sender, e);
                if (previous != null) cmbLocations.SelectedValue = previous;
                if (cmbLocations.SelectedValue != null)
                {
                    btnExecute_Click(sender, e);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
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
