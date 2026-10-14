using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace DBapplication
{
    public partial class Supplier : MaterialForm
    {
        private Controller controllerObj;

        public Supplier()
        {
            InitializeComponent();
            MaterialThemeManager.Initialize(this);
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            RefreshGrid();
        }

        private void FormatGrid()
        {
            if (suppliersDataGrid.Columns.Contains("SNum")) suppliersDataGrid.Columns["SNum"].HeaderText = "Supplier Number";
            if (suppliersDataGrid.Columns.Contains("SName")) suppliersDataGrid.Columns["SName"].HeaderText = "Supplier Name";
            if (suppliersDataGrid.Columns.Contains("City")) suppliersDataGrid.Columns["City"].HeaderText = "City";
            if (suppliersDataGrid.Columns.Contains("Status")) suppliersDataGrid.Columns["Status"].HeaderText = "Status";
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sNumTextBox.Text) ||
                string.IsNullOrWhiteSpace(sNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(cityTextBox.Text) ||
                string.IsNullOrWhiteSpace(statusTextBox.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!int.TryParse(sNumTextBox.Text, out _))
            {
                MessageBox.Show("Supplier Number must be an integer.");
                return;
            }

            if (!int.TryParse(statusTextBox.Text, out int status))
            {
                MessageBox.Show("Status must be an integer.");
                return;
            }

            try
            {
                int result = controllerObj.InsertSupplier(sNumTextBox.Text, sNameTextBox.Text, cityTextBox.Text, status);
                if (result == 0)
                    MessageBox.Show("The insertion of a new Supplier failed");
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                    sNumTextBox.Clear();
                    sNameTextBox.Clear();
                    cityTextBox.Clear();
                    statusTextBox.Clear();
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert Supplier.\n\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sNumDelTextBox.Text))
            {
                MessageBox.Show("Please enter a Supplier Number.");
                return;
            }

            if (!int.TryParse(sNumDelTextBox.Text, out _))
            {
                MessageBox.Show("Supplier Number must be an integer.");
                return;
            }

            try
            {
                int result = controllerObj.DeleteSupplier(sNumDelTextBox.Text);
                if (result == 0)
                    MessageBox.Show("No rows are deleted");
                else
                {
                    MessageBox.Show("The row is deleted successfully!");
                    sNumDelTextBox.Clear();
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete Supplier.\n\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sNumUpdateTextBox.Text) || string.IsNullOrWhiteSpace(cityUpdateTextBox.Text))
            {
                MessageBox.Show("Please enter Supplier Number and New City.");
                return;
            }

            if (!int.TryParse(sNumUpdateTextBox.Text, out _))
            {
                MessageBox.Show("Supplier Number must be an integer.");
                return;
            }

            try
            {
                int result = controllerObj.UpdateSupplier(sNumUpdateTextBox.Text, cityUpdateTextBox.Text);
                if (result == 0)
                    MessageBox.Show("No rows are updated");
                else
                {
                    MessageBox.Show("The row is updated successfully");
                    sNumUpdateTextBox.Clear();
                    cityUpdateTextBox.Clear();
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update Supplier.\n\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            try
            {
                DataTable dt = controllerObj.SelectAllSuppliers();
                suppliersDataGrid.DataSource = dt;
                FormatGrid();
                MaterialThemeManager.StyleDataGridView(suppliersDataGrid);
                MaterialThemeManager.AutoFitGridColumns(suppliersDataGrid);
                suppliersDataGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Suppliers.\n\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            try
            {
                int count = controllerObj.CountSuppliers();
                if (count >= 0) countTextBox.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to count Suppliers.\n\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
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
