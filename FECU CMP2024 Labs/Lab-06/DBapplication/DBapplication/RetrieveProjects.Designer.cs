namespace DBapplication
{
    partial class RetrieveProjects
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AllContainer = new System.Windows.Forms.Panel();
            this.labelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblLocation = new MaterialSkin.Controls.MaterialLabel();
            this.cmbLocations = new MaterialSkin.Controls.MaterialComboBox();
            this.btnExecute = new MaterialSkin.Controls.MaterialButton();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.btnAddProject = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.AllContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // AllContainer
            // 
            this.AllContainer.BackColor = System.Drawing.Color.Transparent;
            this.AllContainer.Controls.Add(this.labelTitle);
            this.AllContainer.Controls.Add(this.lblLocation);
            this.AllContainer.Controls.Add(this.cmbLocations);
            this.AllContainer.Controls.Add(this.btnExecute);
            this.AllContainer.Controls.Add(this.dgvProjects);
            this.AllContainer.Controls.Add(this.btnAddProject);
            this.AllContainer.Controls.Add(this.btnClose);
            this.AllContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllContainer.Location = new System.Drawing.Point(3, 64);
            this.AllContainer.Name = "AllContainer";
            this.AllContainer.Size = new System.Drawing.Size(644, 473);
            this.AllContainer.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Depth = 0;
            this.labelTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.Location = new System.Drawing.Point(50, 15);
            this.labelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(315, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Retrieve Projects by Location";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Depth = 0;
            this.lblLocation.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLocation.Location = new System.Drawing.Point(50, 70);
            this.lblLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(91, 15);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Select Location:";
            this.lblLocation.Visible = false;
            // 
            // cmbLocations
            // 
            this.cmbLocations.AutoResize = false;
            this.cmbLocations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLocations.Depth = 0;
            this.cmbLocations.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLocations.DropDownHeight = 174;
            this.cmbLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocations.DropDownWidth = 121;
            this.cmbLocations.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbLocations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbLocations.FormattingEnabled = true;
            this.cmbLocations.Hint = "Select Location";
            this.cmbLocations.IntegralHeight = false;
            this.cmbLocations.ItemHeight = 43;
            this.cmbLocations.Location = new System.Drawing.Point(50, 90);
            this.cmbLocations.MaxDropDownItems = 4;
            this.cmbLocations.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbLocations.Name = "cmbLocations";
            this.cmbLocations.Size = new System.Drawing.Size(200, 49);
            this.cmbLocations.StartIndex = 0;
            this.cmbLocations.TabIndex = 2;
            // 
            // btnExecute
            // 
            this.btnExecute.AutoSize = false;
            this.btnExecute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExecute.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExecute.Depth = 0;
            this.btnExecute.HighEmphasis = true;
            this.btnExecute.Icon = null;
            this.btnExecute.Location = new System.Drawing.Point(260, 90);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExecute.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExecute.Size = new System.Drawing.Size(130, 49);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute";
            this.btnExecute.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExecute.UseAccentColor = false;
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjects.BackgroundColor = System.Drawing.Color.White;
            this.dgvProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjects.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjects.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProjects.EnableHeadersVisualStyles = false;
            this.dgvProjects.Location = new System.Drawing.Point(50, 160);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.RowHeadersVisible = false;
            this.dgvProjects.Size = new System.Drawing.Size(550, 240);
            this.dgvProjects.TabIndex = 4;
            // 
            // btnAddProject
            // 
            this.btnAddProject.AutoSize = false;
            this.btnAddProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddProject.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddProject.Depth = 0;
            this.btnAddProject.HighEmphasis = true;
            this.btnAddProject.Icon = null;
            this.btnAddProject.Location = new System.Drawing.Point(50, 415);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddProject.Size = new System.Drawing.Size(130, 35);
            this.btnAddProject.TabIndex = 6;
            this.btnAddProject.Text = "+ New Project";
            this.btnAddProject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddProject.UseAccentColor = false;
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = false;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(500, 415);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RetrieveProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 540);
            this.Controls.Add(this.AllContainer);
            this.Name = "RetrieveProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Retrieve Projects";
            this.Load += new System.EventHandler(this.RetrieveProjects_Load);
            this.AllContainer.ResumeLayout(false);
            this.AllContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AllContainer;
        private MaterialSkin.Controls.MaterialLabel labelTitle;
        private MaterialSkin.Controls.MaterialLabel lblLocation;
        private MaterialSkin.Controls.MaterialComboBox cmbLocations;
        private MaterialSkin.Controls.MaterialButton btnExecute;
        private System.Windows.Forms.DataGridView dgvProjects;
        private MaterialSkin.Controls.MaterialButton btnAddProject;
        private MaterialSkin.Controls.MaterialButton btnClose;
    }
}
