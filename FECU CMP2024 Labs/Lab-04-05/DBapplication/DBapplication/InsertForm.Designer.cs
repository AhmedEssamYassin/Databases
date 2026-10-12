namespace DBapplication
{
    partial class InsertForm
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
            this.AllContainer = new System.Windows.Forms.Panel();
            this.labelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.AddButton = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.lblFname = new MaterialSkin.Controls.MaterialLabel();
            this.FnameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.lblMinit = new MaterialSkin.Controls.MaterialLabel();
            this.MinitTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.lblLname = new MaterialSkin.Controls.MaterialLabel();
            this.LnameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.lblSSN = new MaterialSkin.Controls.MaterialLabel();
            this.SSNTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.lblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.AddressTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.lblBDate = new MaterialSkin.Controls.MaterialLabel();
            this.dtpBDate = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new MaterialSkin.Controls.MaterialLabel();
            this.cmbGender = new MaterialSkin.Controls.MaterialComboBox();
            this.lblDeptNo = new MaterialSkin.Controls.MaterialLabel();
            this.cmbDeptNo = new MaterialSkin.Controls.MaterialComboBox();
            this.lblSupervisor = new MaterialSkin.Controls.MaterialLabel();
            this.cmbSupervisor = new MaterialSkin.Controls.MaterialComboBox();
            this.lblSalary = new MaterialSkin.Controls.MaterialLabel();
            this.SalaryTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.AllContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllContainer
            // 
            this.AllContainer.BackColor = System.Drawing.Color.Transparent;
            this.AllContainer.Controls.Add(this.labelTitle);
            this.AllContainer.Controls.Add(this.AddButton);
            this.AllContainer.Controls.Add(this.btnCancel);
            this.AllContainer.Controls.Add(this.lblFname);
            this.AllContainer.Controls.Add(this.FnameTextBox);
            this.AllContainer.Controls.Add(this.lblMinit);
            this.AllContainer.Controls.Add(this.MinitTextBox);
            this.AllContainer.Controls.Add(this.lblLname);
            this.AllContainer.Controls.Add(this.LnameTextBox);
            this.AllContainer.Controls.Add(this.lblSSN);
            this.AllContainer.Controls.Add(this.SSNTextBox);
            this.AllContainer.Controls.Add(this.lblAddress);
            this.AllContainer.Controls.Add(this.AddressTextBox);
            this.AllContainer.Controls.Add(this.lblBDate);
            this.AllContainer.Controls.Add(this.dtpBDate);
            this.AllContainer.Controls.Add(this.lblGender);
            this.AllContainer.Controls.Add(this.cmbGender);
            this.AllContainer.Controls.Add(this.lblDeptNo);
            this.AllContainer.Controls.Add(this.cmbDeptNo);
            this.AllContainer.Controls.Add(this.lblSupervisor);
            this.AllContainer.Controls.Add(this.cmbSupervisor);
            this.AllContainer.Controls.Add(this.lblSalary);
            this.AllContainer.Controls.Add(this.SalaryTextBox);
            this.AllContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllContainer.Location = new System.Drawing.Point(3, 64);
            this.AllContainer.Name = "AllContainer";
            this.AllContainer.Size = new System.Drawing.Size(724, 483);
            this.AllContainer.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Depth = 0;
            this.labelTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.Location = new System.Drawing.Point(45, 15);
            this.labelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(207, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Add New Employee";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Depth = 0;
            this.lblFname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFname.Location = new System.Drawing.Point(50, 70);
            this.lblFname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(65, 15);
            this.lblFname.TabIndex = 20;
            this.lblFname.Text = "First Name";
            this.lblFname.Visible = false;
            // 
            // FnameTextBox
            // 
            this.FnameTextBox.AnimateReadOnly = false;
            this.FnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FnameTextBox.Depth = 0;
            this.FnameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FnameTextBox.Hint = "First Name";
            this.FnameTextBox.LeadingIcon = null;
            this.FnameTextBox.Location = new System.Drawing.Point(50, 90);
            this.FnameTextBox.MaxLength = 50;
            this.FnameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.FnameTextBox.Multiline = false;
            this.FnameTextBox.Name = "FnameTextBox";
            this.FnameTextBox.Size = new System.Drawing.Size(260, 50);
            this.FnameTextBox.TabIndex = 1;
            this.FnameTextBox.Text = "";
            this.FnameTextBox.TrailingIcon = null;
            // 
            // lblMinit
            // 
            this.lblMinit.AutoSize = true;
            this.lblMinit.Depth = 0;
            this.lblMinit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMinit.Location = new System.Drawing.Point(330, 70);
            this.lblMinit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMinit.Name = "lblMinit";
            this.lblMinit.Size = new System.Drawing.Size(29, 15);
            this.lblMinit.TabIndex = 21;
            this.lblMinit.Text = "M.I.";
            this.lblMinit.Visible = false;
            // 
            // MinitTextBox
            // 
            this.MinitTextBox.AnimateReadOnly = false;
            this.MinitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinitTextBox.Depth = 0;
            this.MinitTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MinitTextBox.Hint = "M.I.";
            this.MinitTextBox.LeadingIcon = null;
            this.MinitTextBox.Location = new System.Drawing.Point(330, 90);
            this.MinitTextBox.MaxLength = 1;
            this.MinitTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.MinitTextBox.Multiline = false;
            this.MinitTextBox.Name = "MinitTextBox";
            this.MinitTextBox.Size = new System.Drawing.Size(60, 50);
            this.MinitTextBox.TabIndex = 2;
            this.MinitTextBox.Text = "";
            this.MinitTextBox.TrailingIcon = null;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Depth = 0;
            this.lblLname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLname.Location = new System.Drawing.Point(410, 70);
            this.lblLname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(65, 15);
            this.lblLname.TabIndex = 22;
            this.lblLname.Text = "Last Name";
            this.lblLname.Visible = false;
            // 
            // LnameTextBox
            // 
            this.LnameTextBox.AnimateReadOnly = false;
            this.LnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LnameTextBox.Depth = 0;
            this.LnameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LnameTextBox.Hint = "Last Name";
            this.LnameTextBox.LeadingIcon = null;
            this.LnameTextBox.Location = new System.Drawing.Point(410, 90);
            this.LnameTextBox.MaxLength = 50;
            this.LnameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.LnameTextBox.Multiline = false;
            this.LnameTextBox.Name = "LnameTextBox";
            this.LnameTextBox.Size = new System.Drawing.Size(270, 50);
            this.LnameTextBox.TabIndex = 3;
            this.LnameTextBox.Text = "";
            this.LnameTextBox.TrailingIcon = null;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Depth = 0;
            this.lblSSN.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSSN.Location = new System.Drawing.Point(50, 130);
            this.lblSSN.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(27, 15);
            this.lblSSN.TabIndex = 23;
            this.lblSSN.Text = "SSN";
            this.lblSSN.Visible = false;
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.AnimateReadOnly = false;
            this.SSNTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SSNTextBox.Depth = 0;
            this.SSNTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SSNTextBox.Hint = "SSN";
            this.SSNTextBox.LeadingIcon = null;
            this.SSNTextBox.Location = new System.Drawing.Point(50, 150);
            this.SSNTextBox.MaxLength = 50;
            this.SSNTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SSNTextBox.Multiline = false;
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(300, 50);
            this.SSNTextBox.TabIndex = 4;
            this.SSNTextBox.Text = "";
            this.SSNTextBox.TrailingIcon = null;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Depth = 0;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAddress.Location = new System.Drawing.Point(380, 130);
            this.lblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 15);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Address";
            this.lblAddress.Visible = false;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.AnimateReadOnly = false;
            this.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressTextBox.Depth = 0;
            this.AddressTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AddressTextBox.Hint = "Address";
            this.AddressTextBox.LeadingIcon = null;
            this.AddressTextBox.Location = new System.Drawing.Point(380, 150);
            this.AddressTextBox.MaxLength = 100;
            this.AddressTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.AddressTextBox.Multiline = false;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(300, 50);
            this.AddressTextBox.TabIndex = 5;
            this.AddressTextBox.Text = "";
            this.AddressTextBox.TrailingIcon = null;
            // 
            // lblBDate
            // 
            this.lblBDate.AutoSize = true;
            this.lblBDate.Depth = 0;
            this.lblBDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblBDate.Location = new System.Drawing.Point(50, 205);
            this.lblBDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBDate.Name = "lblBDate";
            this.lblBDate.Size = new System.Drawing.Size(65, 17);
            this.lblBDate.TabIndex = 25;
            this.lblBDate.Text = "Birth Date";
            // 
            // dtpBDate
            // 
            this.dtpBDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBDate.Location = new System.Drawing.Point(50, 225);
            this.dtpBDate.Size = new System.Drawing.Size(300, 25);
            this.dtpBDate.TabIndex = 6;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Depth = 0;
            this.lblGender.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGender.Location = new System.Drawing.Point(380, 190);
            this.lblGender.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(41, 15);
            this.lblGender.TabIndex = 26;
            this.lblGender.Text = "Gender";
            this.lblGender.Visible = false;
            // 
            // cmbGender
            // 
            this.cmbGender.AutoResize = false;
            this.cmbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGender.Depth = 0;
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGender.DropDownHeight = 174;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.DropDownWidth = 121;
            this.cmbGender.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Hint = "Gender";
            this.cmbGender.IntegralHeight = false;
            this.cmbGender.ItemHeight = 43;
            this.cmbGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbGender.Location = new System.Drawing.Point(380, 210);
            this.cmbGender.MaxDropDownItems = 4;
            this.cmbGender.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(300, 49);
            this.cmbGender.StartIndex = 0;
            this.cmbGender.TabIndex = 7;
            // 
            // lblDeptNo
            // 
            this.lblDeptNo.AutoSize = true;
            this.lblDeptNo.Depth = 0;
            this.lblDeptNo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeptNo.Location = new System.Drawing.Point(50, 250);
            this.lblDeptNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeptNo.Name = "lblDeptNo";
            this.lblDeptNo.Size = new System.Drawing.Size(65, 15);
            this.lblDeptNo.TabIndex = 27;
            this.lblDeptNo.Text = "Department";
            this.lblDeptNo.Visible = false;
            // 
            // cmbDeptNo
            // 
            this.cmbDeptNo.AutoResize = false;
            this.cmbDeptNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDeptNo.Depth = 0;
            this.cmbDeptNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDeptNo.DropDownHeight = 174;
            this.cmbDeptNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeptNo.DropDownWidth = 121;
            this.cmbDeptNo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbDeptNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbDeptNo.FormattingEnabled = true;
            this.cmbDeptNo.Hint = "Department";
            this.cmbDeptNo.IntegralHeight = false;
            this.cmbDeptNo.ItemHeight = 43;
            this.cmbDeptNo.Location = new System.Drawing.Point(50, 270);
            this.cmbDeptNo.MaxDropDownItems = 4;
            this.cmbDeptNo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDeptNo.Name = "cmbDeptNo";
            this.cmbDeptNo.Size = new System.Drawing.Size(300, 49);
            this.cmbDeptNo.StartIndex = 0;
            this.cmbDeptNo.TabIndex = 8;
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Depth = 0;
            this.lblSupervisor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSupervisor.Location = new System.Drawing.Point(50, 330);
            this.lblSupervisor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(65, 15);
            this.lblSupervisor.TabIndex = 28;
            this.lblSupervisor.Text = "Supervisor";
            this.lblSupervisor.Visible = false;
            // 
            // cmbSupervisor
            // 
            this.cmbSupervisor.AutoResize = false;
            this.cmbSupervisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSupervisor.Depth = 0;
            this.cmbSupervisor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSupervisor.DropDownHeight = 174;
            this.cmbSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupervisor.DropDownWidth = 121;
            this.cmbSupervisor.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSupervisor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSupervisor.FormattingEnabled = true;
            this.cmbSupervisor.Hint = "Supervisor (Optional)";
            this.cmbSupervisor.IntegralHeight = false;
            this.cmbSupervisor.ItemHeight = 43;
            this.cmbSupervisor.Location = new System.Drawing.Point(50, 350);
            this.cmbSupervisor.MaxDropDownItems = 4;
            this.cmbSupervisor.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSupervisor.Name = "cmbSupervisor";
            this.cmbSupervisor.Size = new System.Drawing.Size(300, 49);
            this.cmbSupervisor.StartIndex = 0;
            this.cmbSupervisor.TabIndex = 9;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Depth = 0;
            this.lblSalary.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSalary.Location = new System.Drawing.Point(380, 330);
            this.lblSalary.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(40, 15);
            this.lblSalary.TabIndex = 29;
            this.lblSalary.Text = "Salary";
            this.lblSalary.Visible = false;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.AnimateReadOnly = false;
            this.SalaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalaryTextBox.Depth = 0;
            this.SalaryTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SalaryTextBox.Hint = "Salary ($)";
            this.SalaryTextBox.LeadingIcon = null;
            this.SalaryTextBox.Location = new System.Drawing.Point(380, 350);
            this.SalaryTextBox.MaxLength = 50;
            this.SalaryTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SalaryTextBox.Multiline = false;
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(300, 50);
            this.SalaryTextBox.TabIndex = 10;
            this.SalaryTextBox.Text = "";
            this.SalaryTextBox.TrailingIcon = null;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = false;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddButton.Depth = 0;
            this.AddButton.HighEmphasis = true;
            this.AddButton.Icon = null;
            this.AddButton.Location = new System.Drawing.Point(380, 420);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddButton.Size = new System.Drawing.Size(300, 45);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Save Employee";
            this.AddButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddButton.UseAccentColor = false;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_MouseClick);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = false;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(50, 420);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(300, 45);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.AllContainer);
            this.Name = "InsertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            this.AllContainer.ResumeLayout(false);
            this.AllContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AllContainer;
        private MaterialSkin.Controls.MaterialLabel labelTitle;
        private MaterialSkin.Controls.MaterialButton AddButton;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel lblFname;
        private MaterialSkin.Controls.MaterialTextBox FnameTextBox;
        private MaterialSkin.Controls.MaterialLabel lblMinit;
        private MaterialSkin.Controls.MaterialTextBox MinitTextBox;
        private MaterialSkin.Controls.MaterialLabel lblLname;
        private MaterialSkin.Controls.MaterialTextBox LnameTextBox;
        private MaterialSkin.Controls.MaterialLabel lblSSN;
        private MaterialSkin.Controls.MaterialTextBox SSNTextBox;
        private MaterialSkin.Controls.MaterialLabel lblAddress;
        private MaterialSkin.Controls.MaterialTextBox AddressTextBox;
        private MaterialSkin.Controls.MaterialLabel lblBDate;
        private System.Windows.Forms.DateTimePicker dtpBDate;
        private MaterialSkin.Controls.MaterialLabel lblGender;
        private MaterialSkin.Controls.MaterialComboBox cmbGender;
        private MaterialSkin.Controls.MaterialLabel lblDeptNo;
        private MaterialSkin.Controls.MaterialComboBox cmbDeptNo;
        private MaterialSkin.Controls.MaterialLabel lblSupervisor;
        private MaterialSkin.Controls.MaterialComboBox cmbSupervisor;
        private MaterialSkin.Controls.MaterialLabel lblSalary;
        private MaterialSkin.Controls.MaterialTextBox SalaryTextBox;
    }
}