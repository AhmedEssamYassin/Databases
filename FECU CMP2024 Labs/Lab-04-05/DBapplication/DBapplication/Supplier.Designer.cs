namespace DBapplication
{
    partial class Supplier
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AllContainer = new System.Windows.Forms.Panel();
            this.labelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.closeButton = new MaterialSkin.Controls.MaterialButton();
            this.grpInsert = new System.Windows.Forms.GroupBox();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.sNumTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.sNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.cityTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.statusTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.insertButton = new MaterialSkin.Controls.MaterialButton();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.sNumUpdateTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.cityUpdateTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.updateButton = new MaterialSkin.Controls.MaterialButton();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.sNumDelTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.grpView = new System.Windows.Forms.GroupBox();
            this.suppliersDataGrid = new System.Windows.Forms.DataGridView();
            this.selectAllButton = new MaterialSkin.Controls.MaterialButton();
            this.countButton = new MaterialSkin.Controls.MaterialButton();
            this.label8 = new MaterialSkin.Controls.MaterialLabel();
            this.countTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.AllContainer.SuspendLayout();
            this.grpInsert.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.grpView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AllContainer
            // 
            this.AllContainer.BackColor = System.Drawing.Color.Transparent;
            this.AllContainer.Controls.Add(this.labelTitle);
            this.AllContainer.Controls.Add(this.grpInsert);
            this.AllContainer.Controls.Add(this.grpUpdate);
            this.AllContainer.Controls.Add(this.grpDelete);
            this.AllContainer.Controls.Add(this.grpView);
            this.AllContainer.Controls.Add(this.closeButton);
            this.AllContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllContainer.Location = new System.Drawing.Point(3, 64);
            this.AllContainer.Name = "AllContainer";
            this.AllContainer.Size = new System.Drawing.Size(894, 683);
            this.AllContainer.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Depth = 0;
            this.labelTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.Location = new System.Drawing.Point(28, 15);
            this.labelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(191, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Manage Suppliers";
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = false;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.closeButton.Depth = 0;
            this.closeButton.HighEmphasis = false;
            this.closeButton.Icon = null;
            this.closeButton.Location = new System.Drawing.Point(753, 635);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.closeButton.Size = new System.Drawing.Size(120, 35);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Close";
            this.closeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.closeButton.UseAccentColor = false;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // grpInsert
            // 
            this.grpInsert.BackColor = System.Drawing.Color.Transparent;
            this.grpInsert.Controls.Add(this.label1);
            this.grpInsert.Controls.Add(this.sNumTextBox);
            this.grpInsert.Controls.Add(this.label2);
            this.grpInsert.Controls.Add(this.sNameTextBox);
            this.grpInsert.Controls.Add(this.label3);
            this.grpInsert.Controls.Add(this.cityTextBox);
            this.grpInsert.Controls.Add(this.label4);
            this.grpInsert.Controls.Add(this.statusTextBox);
            this.grpInsert.Controls.Add(this.insertButton);
            this.grpInsert.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInsert.ForeColor = System.Drawing.Color.Gray;
            this.grpInsert.Location = new System.Drawing.Point(28, 60);
            this.grpInsert.Name = "grpInsert";
            this.grpInsert.Size = new System.Drawing.Size(845, 125);
            this.grpInsert.TabIndex = 1;
            this.grpInsert.TabStop = false;
            this.grpInsert.Text = "Insert Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Supplier No";
            this.label1.Visible = false;
            // 
            // sNumTextBox
            // 
            this.sNumTextBox.AnimateReadOnly = false;
            this.sNumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sNumTextBox.Depth = 0;
            this.sNumTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sNumTextBox.Hint = "Supplier No";
            this.sNumTextBox.LeadingIcon = null;
            this.sNumTextBox.Location = new System.Drawing.Point(20, 48);
            this.sNumTextBox.MaxLength = 50;
            this.sNumTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.sNumTextBox.Multiline = false;
            this.sNumTextBox.Name = "sNumTextBox";
            this.sNumTextBox.Size = new System.Drawing.Size(130, 50);
            this.sNumTextBox.TabIndex = 2;
            this.sNumTextBox.Text = "";
            this.sNumTextBox.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(170, 30);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Supplier Name";
            this.label2.Visible = false;
            // 
            // sNameTextBox
            // 
            this.sNameTextBox.AnimateReadOnly = false;
            this.sNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sNameTextBox.Depth = 0;
            this.sNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sNameTextBox.Hint = "Supplier Name";
            this.sNameTextBox.LeadingIcon = null;
            this.sNameTextBox.Location = new System.Drawing.Point(170, 48);
            this.sNameTextBox.MaxLength = 50;
            this.sNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.sNameTextBox.Multiline = false;
            this.sNameTextBox.Name = "sNameTextBox";
            this.sNameTextBox.Size = new System.Drawing.Size(170, 50);
            this.sNameTextBox.TabIndex = 3;
            this.sNameTextBox.Text = "";
            this.sNameTextBox.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(360, 30);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "City";
            this.label3.Visible = false;
            // 
            // cityTextBox
            // 
            this.cityTextBox.AnimateReadOnly = false;
            this.cityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityTextBox.Depth = 0;
            this.cityTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cityTextBox.Hint = "City";
            this.cityTextBox.LeadingIcon = null;
            this.cityTextBox.Location = new System.Drawing.Point(360, 48);
            this.cityTextBox.MaxLength = 50;
            this.cityTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.cityTextBox.Multiline = false;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(150, 50);
            this.cityTextBox.TabIndex = 4;
            this.cityTextBox.Text = "";
            this.cityTextBox.TrailingIcon = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(530, 30);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Status";
            this.label4.Visible = false;
            // 
            // statusTextBox
            // 
            this.statusTextBox.AnimateReadOnly = false;
            this.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTextBox.Depth = 0;
            this.statusTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statusTextBox.Hint = "Status";
            this.statusTextBox.LeadingIcon = null;
            this.statusTextBox.Location = new System.Drawing.Point(530, 48);
            this.statusTextBox.MaxLength = 50;
            this.statusTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.statusTextBox.Multiline = false;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 50);
            this.statusTextBox.TabIndex = 5;
            this.statusTextBox.Text = "";
            this.statusTextBox.TrailingIcon = null;
            // 
            // insertButton
            // 
            this.insertButton.AutoSize = false;
            this.insertButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.insertButton.Depth = 0;
            this.insertButton.HighEmphasis = true;
            this.insertButton.Icon = null;
            this.insertButton.Location = new System.Drawing.Point(670, 48);
            this.insertButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.insertButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertButton.Name = "insertButton";
            this.insertButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.insertButton.Size = new System.Drawing.Size(150, 50);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "Insert";
            this.insertButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.insertButton.UseAccentColor = false;
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // grpUpdate
            // 
            this.grpUpdate.BackColor = System.Drawing.Color.Transparent;
            this.grpUpdate.Controls.Add(this.label6);
            this.grpUpdate.Controls.Add(this.sNumUpdateTextBox);
            this.grpUpdate.Controls.Add(this.label7);
            this.grpUpdate.Controls.Add(this.cityUpdateTextBox);
            this.grpUpdate.Controls.Add(this.updateButton);
            this.grpUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpUpdate.ForeColor = System.Drawing.Color.Gray;
            this.grpUpdate.Location = new System.Drawing.Point(28, 200);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(400, 125);
            this.grpUpdate.TabIndex = 2;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update Supplier City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(20, 30);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Supplier No";
            this.label6.Visible = false;
            // 
            // sNumUpdateTextBox
            // 
            this.sNumUpdateTextBox.AnimateReadOnly = false;
            this.sNumUpdateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sNumUpdateTextBox.Depth = 0;
            this.sNumUpdateTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sNumUpdateTextBox.Hint = "Supplier No";
            this.sNumUpdateTextBox.LeadingIcon = null;
            this.sNumUpdateTextBox.Location = new System.Drawing.Point(20, 48);
            this.sNumUpdateTextBox.MaxLength = 50;
            this.sNumUpdateTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.sNumUpdateTextBox.Multiline = false;
            this.sNumUpdateTextBox.Name = "sNumUpdateTextBox";
            this.sNumUpdateTextBox.Size = new System.Drawing.Size(130, 50);
            this.sNumUpdateTextBox.TabIndex = 2;
            this.sNumUpdateTextBox.Text = "";
            this.sNumUpdateTextBox.TrailingIcon = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(170, 30);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "New City";
            this.label7.Visible = false;
            // 
            // cityUpdateTextBox
            // 
            this.cityUpdateTextBox.AnimateReadOnly = false;
            this.cityUpdateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityUpdateTextBox.Depth = 0;
            this.cityUpdateTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cityUpdateTextBox.Hint = "New City";
            this.cityUpdateTextBox.LeadingIcon = null;
            this.cityUpdateTextBox.Location = new System.Drawing.Point(170, 48);
            this.cityUpdateTextBox.MaxLength = 50;
            this.cityUpdateTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.cityUpdateTextBox.Multiline = false;
            this.cityUpdateTextBox.Name = "cityUpdateTextBox";
            this.cityUpdateTextBox.Size = new System.Drawing.Size(100, 50);
            this.cityUpdateTextBox.TabIndex = 3;
            this.cityUpdateTextBox.Text = "";
            this.cityUpdateTextBox.TrailingIcon = null;
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = false;
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.updateButton.Depth = 0;
            this.updateButton.HighEmphasis = true;
            this.updateButton.Icon = null;
            this.updateButton.Location = new System.Drawing.Point(290, 48);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.updateButton.Size = new System.Drawing.Size(90, 50);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.updateButton.UseAccentColor = false;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // grpDelete
            // 
            this.grpDelete.BackColor = System.Drawing.Color.Transparent;
            this.grpDelete.Controls.Add(this.label5);
            this.grpDelete.Controls.Add(this.sNumDelTextBox);
            this.grpDelete.Controls.Add(this.deleteButton);
            this.grpDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDelete.ForeColor = System.Drawing.Color.Gray;
            this.grpDelete.Location = new System.Drawing.Point(452, 200);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(420, 125);
            this.grpDelete.TabIndex = 3;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(20, 30);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Supplier No";
            this.label5.Visible = false;
            // 
            // sNumDelTextBox
            // 
            this.sNumDelTextBox.AnimateReadOnly = false;
            this.sNumDelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sNumDelTextBox.Depth = 0;
            this.sNumDelTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sNumDelTextBox.Hint = "Supplier No";
            this.sNumDelTextBox.LeadingIcon = null;
            this.sNumDelTextBox.Location = new System.Drawing.Point(20, 48);
            this.sNumDelTextBox.MaxLength = 50;
            this.sNumDelTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.sNumDelTextBox.Multiline = false;
            this.sNumDelTextBox.Name = "sNumDelTextBox";
            this.sNumDelTextBox.Size = new System.Drawing.Size(180, 50);
            this.sNumDelTextBox.TabIndex = 2;
            this.sNumDelTextBox.Text = "";
            this.sNumDelTextBox.TrailingIcon = null;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = false;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteButton.Depth = 0;
            this.deleteButton.HighEmphasis = true;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(220, 48);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteButton.Size = new System.Drawing.Size(180, 50);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteButton.UseAccentColor = true;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // grpView
            // 
            this.grpView.BackColor = System.Drawing.Color.Transparent;
            this.grpView.Controls.Add(this.suppliersDataGrid);
            this.grpView.Controls.Add(this.selectAllButton);
            this.grpView.Controls.Add(this.countButton);
            this.grpView.Controls.Add(this.label8);
            this.grpView.Controls.Add(this.countTextBox);
            this.grpView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpView.ForeColor = System.Drawing.Color.Gray;
            this.grpView.Location = new System.Drawing.Point(28, 340);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(845, 280);
            this.grpView.TabIndex = 4;
            this.grpView.TabStop = false;
            this.grpView.Text = "View Suppliers";
            // 
            // suppliersDataGrid
            // 
            this.suppliersDataGrid.AllowUserToAddRows = false;
            this.suppliersDataGrid.AllowUserToDeleteRows = false;
            this.suppliersDataGrid.ReadOnly = true;
            this.suppliersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.suppliersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.suppliersDataGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.suppliersDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.suppliersDataGrid.EnableHeadersVisualStyles = false;
            this.suppliersDataGrid.Location = new System.Drawing.Point(20, 30);
            this.suppliersDataGrid.Name = "suppliersDataGrid";
            this.suppliersDataGrid.RowHeadersVisible = false;
            this.suppliersDataGrid.Size = new System.Drawing.Size(800, 180);
            this.suppliersDataGrid.TabIndex = 0;
            // 
            // selectAllButton
            // 
            this.selectAllButton.AutoSize = false;
            this.selectAllButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectAllButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.selectAllButton.Depth = 0;
            this.selectAllButton.HighEmphasis = true;
            this.selectAllButton.Icon = null;
            this.selectAllButton.Location = new System.Drawing.Point(20, 220);
            this.selectAllButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.selectAllButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.selectAllButton.Size = new System.Drawing.Size(150, 40);
            this.selectAllButton.TabIndex = 1;
            this.selectAllButton.Text = "Load All";
            this.selectAllButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.selectAllButton.UseAccentColor = false;
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // countButton
            // 
            this.countButton.AutoSize = false;
            this.countButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.countButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.countButton.Depth = 0;
            this.countButton.HighEmphasis = true;
            this.countButton.Icon = null;
            this.countButton.Location = new System.Drawing.Point(190, 220);
            this.countButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.countButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.countButton.Name = "countButton";
            this.countButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.countButton.Size = new System.Drawing.Size(150, 40);
            this.countButton.TabIndex = 2;
            this.countButton.Text = "Count Suppliers";
            this.countButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.countButton.UseAccentColor = false;
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Depth = 0;
            this.label8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.Location = new System.Drawing.Point(360, 230);
            this.label8.MouseState = MaterialSkin.MouseState.HOVER;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Count:";
            this.label8.Visible = true;
            // 
            // countTextBox
            // 
            this.countTextBox.AnimateReadOnly = false;
            this.countTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countTextBox.Depth = 0;
            this.countTextBox.Enabled = false;
            this.countTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.countTextBox.Hint = "";
            this.countTextBox.LeadingIcon = null;
            this.countTextBox.Location = new System.Drawing.Point(420, 215);
            this.countTextBox.MaxLength = 50;
            this.countTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.countTextBox.Multiline = false;
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.ReadOnly = true;
            this.countTextBox.Size = new System.Drawing.Size(100, 50);
            this.countTextBox.TabIndex = 4;
            this.countTextBox.Text = "";
            this.countTextBox.TrailingIcon = null;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.AllContainer);
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Supplier Management";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.AllContainer.ResumeLayout(false);
            this.AllContainer.PerformLayout();
            this.grpInsert.ResumeLayout(false);
            this.grpInsert.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.grpView.ResumeLayout(false);
            this.grpView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AllContainer;
        private MaterialSkin.Controls.MaterialLabel labelTitle;
        private System.Windows.Forms.GroupBox grpInsert;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.GroupBox grpView;
        private MaterialSkin.Controls.MaterialButton insertButton;
        private MaterialSkin.Controls.MaterialTextBox sNumTextBox;
        private MaterialSkin.Controls.MaterialTextBox sNameTextBox;
        private MaterialSkin.Controls.MaterialTextBox cityTextBox;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialTextBox statusTextBox;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialTextBox sNumDelTextBox;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private MaterialSkin.Controls.MaterialLabel label6;
        private MaterialSkin.Controls.MaterialLabel label7;
        private MaterialSkin.Controls.MaterialTextBox sNumUpdateTextBox;
        private MaterialSkin.Controls.MaterialTextBox cityUpdateTextBox;
        private MaterialSkin.Controls.MaterialButton updateButton;
        private MaterialSkin.Controls.MaterialButton closeButton;
        private System.Windows.Forms.DataGridView suppliersDataGrid;
        private MaterialSkin.Controls.MaterialButton selectAllButton;
        private MaterialSkin.Controls.MaterialButton countButton;
        private MaterialSkin.Controls.MaterialTextBox countTextBox;
        private MaterialSkin.Controls.MaterialLabel label8;
    }
}
