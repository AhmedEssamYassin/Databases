namespace DBapplication
{
    partial class InsertProjectForm
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
            this.lblPname = new MaterialSkin.Controls.MaterialLabel();
            this.PnameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPnumber = new MaterialSkin.Controls.MaterialLabel();
            this.PnumberTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPlocation = new MaterialSkin.Controls.MaterialLabel();
            this.PlocationTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDept = new MaterialSkin.Controls.MaterialLabel();
            this.cmbDepartment = new MaterialSkin.Controls.MaterialComboBox();
            this.AddButton = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.AllContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllContainer
            // 
            this.AllContainer.BackColor = System.Drawing.Color.Transparent;
            this.AllContainer.Controls.Add(this.labelTitle);
            this.AllContainer.Controls.Add(this.lblPname);
            this.AllContainer.Controls.Add(this.PnameTextBox);
            this.AllContainer.Controls.Add(this.lblPnumber);
            this.AllContainer.Controls.Add(this.PnumberTextBox);
            this.AllContainer.Controls.Add(this.lblPlocation);
            this.AllContainer.Controls.Add(this.PlocationTextBox);
            this.AllContainer.Controls.Add(this.lblDept);
            this.AllContainer.Controls.Add(this.cmbDepartment);
            this.AllContainer.Controls.Add(this.AddButton);
            this.AllContainer.Controls.Add(this.btnCancel);
            this.AllContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllContainer.Location = new System.Drawing.Point(3, 64);
            this.AllContainer.Name = "AllContainer";
            this.AllContainer.Size = new System.Drawing.Size(494, 433);
            this.AllContainer.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Depth = 0;
            this.labelTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(183, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Add New Project";
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Depth = 0;
            this.lblPname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPname.Location = new System.Drawing.Point(30, 70);
            this.lblPname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(76, 14);
            this.lblPname.TabIndex = 1;
            this.lblPname.Text = "Project Name";
            // 
            // PnameTextBox
            // 
            this.PnameTextBox.AnimateReadOnly = false;
            this.PnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PnameTextBox.Depth = 0;
            this.PnameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PnameTextBox.LeadingIcon = null;
            this.PnameTextBox.Location = new System.Drawing.Point(30, 90);
            this.PnameTextBox.MaxLength = 50;
            this.PnameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PnameTextBox.Multiline = false;
            this.PnameTextBox.Name = "PnameTextBox";
            this.PnameTextBox.Size = new System.Drawing.Size(430, 50);
            this.PnameTextBox.TabIndex = 2;
            this.PnameTextBox.Text = "";
            this.PnameTextBox.TrailingIcon = null;
            // 
            // lblPnumber
            // 
            this.lblPnumber.AutoSize = true;
            this.lblPnumber.Depth = 0;
            this.lblPnumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPnumber.Location = new System.Drawing.Point(30, 150);
            this.lblPnumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPnumber.Name = "lblPnumber";
            this.lblPnumber.Size = new System.Drawing.Size(89, 14);
            this.lblPnumber.TabIndex = 3;
            this.lblPnumber.Text = "Project Number";
            // 
            // PnumberTextBox
            // 
            this.PnumberTextBox.AnimateReadOnly = false;
            this.PnumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PnumberTextBox.Depth = 0;
            this.PnumberTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PnumberTextBox.LeadingIcon = null;
            this.PnumberTextBox.Location = new System.Drawing.Point(30, 170);
            this.PnumberTextBox.MaxLength = 10;
            this.PnumberTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PnumberTextBox.Multiline = false;
            this.PnumberTextBox.Name = "PnumberTextBox";
            this.PnumberTextBox.Size = new System.Drawing.Size(200, 50);
            this.PnumberTextBox.TabIndex = 4;
            this.PnumberTextBox.Text = "";
            this.PnumberTextBox.TrailingIcon = null;
            // 
            // lblPlocation
            // 
            this.lblPlocation.AutoSize = true;
            this.lblPlocation.Depth = 0;
            this.lblPlocation.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPlocation.Location = new System.Drawing.Point(260, 150);
            this.lblPlocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPlocation.Name = "lblPlocation";
            this.lblPlocation.Size = new System.Drawing.Size(49, 14);
            this.lblPlocation.TabIndex = 5;
            this.lblPlocation.Text = "Location";
            // 
            // PlocationTextBox
            // 
            this.PlocationTextBox.AnimateReadOnly = false;
            this.PlocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlocationTextBox.Depth = 0;
            this.PlocationTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PlocationTextBox.LeadingIcon = null;
            this.PlocationTextBox.Location = new System.Drawing.Point(260, 170);
            this.PlocationTextBox.MaxLength = 50;
            this.PlocationTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PlocationTextBox.Multiline = false;
            this.PlocationTextBox.Name = "PlocationTextBox";
            this.PlocationTextBox.Size = new System.Drawing.Size(200, 50);
            this.PlocationTextBox.TabIndex = 6;
            this.PlocationTextBox.Text = "";
            this.PlocationTextBox.TrailingIcon = null;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Depth = 0;
            this.lblDept.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDept.Location = new System.Drawing.Point(30, 235);
            this.lblDept.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(134, 14);
            this.lblDept.TabIndex = 7;
            this.lblDept.Text = "Controlling Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.AutoResize = false;
            this.cmbDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDepartment.Depth = 0;
            this.cmbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDepartment.DropDownHeight = 174;
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.DropDownWidth = 121;
            this.cmbDepartment.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.IntegralHeight = false;
            this.cmbDepartment.ItemHeight = 43;
            this.cmbDepartment.Location = new System.Drawing.Point(30, 255);
            this.cmbDepartment.MaxDropDownItems = 4;
            this.cmbDepartment.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(430, 49);
            this.cmbDepartment.StartIndex = 0;
            this.cmbDepartment.TabIndex = 8;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = false;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddButton.Depth = 0;
            this.AddButton.HighEmphasis = true;
            this.AddButton.Icon = null;
            this.AddButton.Location = new System.Drawing.Point(310, 345);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddButton.Size = new System.Drawing.Size(150, 40);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Create Project";
            this.AddButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddButton.UseAccentColor = false;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = false;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(190, 345);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // InsertProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.AllContainer);
            this.Name = "InsertProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Project";
            this.Load += new System.EventHandler(this.InsertProjectForm_Load);
            this.AllContainer.ResumeLayout(false);
            this.AllContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AllContainer;
        private MaterialSkin.Controls.MaterialLabel labelTitle;
        private MaterialSkin.Controls.MaterialLabel lblPname;
        private MaterialSkin.Controls.MaterialTextBox PnameTextBox;
        private MaterialSkin.Controls.MaterialLabel lblPnumber;
        private MaterialSkin.Controls.MaterialTextBox PnumberTextBox;
        private MaterialSkin.Controls.MaterialLabel lblPlocation;
        private MaterialSkin.Controls.MaterialTextBox PlocationTextBox;
        private MaterialSkin.Controls.MaterialLabel lblDept;
        private MaterialSkin.Controls.MaterialComboBox cmbDepartment;
        private MaterialSkin.Controls.MaterialButton AddButton;
        private MaterialSkin.Controls.MaterialButton btnCancel;
    }
}
