namespace DBapplication
{
    partial class Dashboard
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnThemeToggle = new System.Windows.Forms.Button();
            this.btnDeptStats = new System.Windows.Forms.Button();
            this.btnReportViewer = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnRetrieveProjects = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnTabEmployees = new System.Windows.Forms.Button();
            this.lblNavHeader = new MaterialSkin.Controls.MaterialLabel();
            this.panelNavSeparator = new System.Windows.Forms.Panel();
            this.comboValue = new MaterialSkin.Controls.MaterialComboBox();
            this.comboType = new MaterialSkin.Controls.MaterialComboBox();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.lblSearchFilterHeader = new MaterialSkin.Controls.MaterialLabel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new MaterialSkin.Controls.MaterialLabel();
            this.panelProjectActions = new System.Windows.Forms.Panel();
            this.lblProjectActions = new MaterialSkin.Controls.MaterialLabel();
            this.btnCountEmployees = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteProject = new MaterialSkin.Controls.MaterialButton();
            this.btnInsertProject = new MaterialSkin.Controls.MaterialButton();
            this.AllContainer = new System.Windows.Forms.Panel();
            this.EmployeeTable = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblHeaderTitle = new MaterialSkin.Controls.MaterialLabel();
            this.panelEmployeeActions = new System.Windows.Forms.Panel();
            this.btnEditEmployee = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteEmployee = new MaterialSkin.Controls.MaterialButton();
            this.panelSidebar.SuspendLayout();
            this.panelProjectActions.SuspendLayout();
            this.AllContainer.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelEmployeeActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.Transparent;
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnThemeToggle);
            this.panelSidebar.Controls.Add(this.btnDeptStats);
            this.panelSidebar.Controls.Add(this.btnReportViewer);
            this.panelSidebar.Controls.Add(this.btnSuppliers);
            this.panelSidebar.Controls.Add(this.btnRetrieveProjects);
            this.panelSidebar.Controls.Add(this.btnAddEmployee);
            this.panelSidebar.Controls.Add(this.btnTabEmployees);
            this.panelSidebar.Controls.Add(this.lblNavHeader);
            this.panelSidebar.Controls.Add(this.panelNavSeparator);
            this.panelSidebar.Controls.Add(this.comboValue);
            this.panelSidebar.Controls.Add(this.comboType);
            this.panelSidebar.Controls.Add(this.btnSearch);
            this.panelSidebar.Controls.Add(this.txtSearch);
            this.panelSidebar.Controls.Add(this.lblSearchFilterHeader);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(3, 64);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(260, 633);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = false;
            this.btnLogout.Location = new System.Drawing.Point(20, 615);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 40);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnThemeToggle
            // 
            this.btnThemeToggle.AutoSize = false;
            this.btnThemeToggle.Location = new System.Drawing.Point(20, 570);
            this.btnThemeToggle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemeToggle.Name = "btnThemeToggle";
            this.btnThemeToggle.Size = new System.Drawing.Size(220, 40);
            this.btnThemeToggle.TabIndex = 13;
            this.btnThemeToggle.Text = "Light Mode";
            this.btnThemeToggle.UseVisualStyleBackColor = true;
            this.btnThemeToggle.Click += new System.EventHandler(this.btnThemeToggle_Click);
            // 
            // btnDeptStats
            // 
            this.btnDeptStats.AutoSize = false;
            this.btnDeptStats.Location = new System.Drawing.Point(20, 525);
            this.btnDeptStats.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeptStats.Name = "btnDeptStats";
            this.btnDeptStats.Size = new System.Drawing.Size(220, 40);
            this.btnDeptStats.TabIndex = 15;
            this.btnDeptStats.Text = "Department Stats";
            this.btnDeptStats.UseVisualStyleBackColor = true;
            this.btnDeptStats.Click += new System.EventHandler(this.btnDeptStats_Click);
            // 
            // btnReportViewer
            // 
            this.btnReportViewer.AutoSize = false;
            this.btnReportViewer.Location = new System.Drawing.Point(20, 480);
            this.btnReportViewer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReportViewer.Name = "btnReportViewer";
            this.btnReportViewer.Size = new System.Drawing.Size(220, 40);
            this.btnReportViewer.TabIndex = 14;
            this.btnReportViewer.Text = "Report Viewer";
            this.btnReportViewer.UseVisualStyleBackColor = true;
            this.btnReportViewer.Click += new System.EventHandler(this.btnReportViewer_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.AutoSize = false;
                                                                        this.btnSuppliers.Location = new System.Drawing.Point(20, 435);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.btnSuppliers.Name = "btnSuppliers";
                        this.btnSuppliers.Size = new System.Drawing.Size(220, 40);
            this.btnSuppliers.TabIndex = 11;
            this.btnSuppliers.Text = "Manage Suppliers";
                                    this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnRetrieveProjects
            // 
            this.btnRetrieveProjects.AutoSize = false;
                                                                        this.btnRetrieveProjects.Location = new System.Drawing.Point(20, 390);
            this.btnRetrieveProjects.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.btnRetrieveProjects.Name = "btnRetrieveProjects";
                        this.btnRetrieveProjects.Size = new System.Drawing.Size(220, 40);
            this.btnRetrieveProjects.TabIndex = 10;
            this.btnRetrieveProjects.Text = "Retrieve Projects";
                                    this.btnRetrieveProjects.UseVisualStyleBackColor = true;
            this.btnRetrieveProjects.Click += new System.EventHandler(this.btnRetrieveProjects_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.AutoSize = false;
                                                                        this.btnAddEmployee.Location = new System.Drawing.Point(20, 345);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.btnAddEmployee.Name = "btnAddEmployee";
                        this.btnAddEmployee.Size = new System.Drawing.Size(220, 40);
            this.btnAddEmployee.TabIndex = 9;
            this.btnAddEmployee.Text = "Add Employee";
                                    this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnTabEmployees
            // 
            this.btnTabEmployees.AutoSize = false;
                                                                        this.btnTabEmployees.Location = new System.Drawing.Point(20, 300);
            this.btnTabEmployees.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.btnTabEmployees.Name = "btnTabEmployees";
                        this.btnTabEmployees.Size = new System.Drawing.Size(220, 40);
            this.btnTabEmployees.TabIndex = 8;
            this.btnTabEmployees.Text = "Employees";
                                    this.btnTabEmployees.UseVisualStyleBackColor = true;
            this.btnTabEmployees.Click += new System.EventHandler(this.btnTabEmployees_Click);
            // 
            // lblNavHeader
            // 
            this.lblNavHeader.AutoSize = true;
            this.lblNavHeader.Depth = 0;
            this.lblNavHeader.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNavHeader.Location = new System.Drawing.Point(20, 275);
            this.lblNavHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNavHeader.Name = "lblNavHeader";
            this.lblNavHeader.Size = new System.Drawing.Size(78, 17);
            this.lblNavHeader.TabIndex = 7;
            this.lblNavHeader.Text = "NAVIGATION";
            // 
            // panelNavSeparator
            // 
            this.panelNavSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panelNavSeparator.Location = new System.Drawing.Point(20, 260);
            this.panelNavSeparator.Name = "panelNavSeparator";
            this.panelNavSeparator.Size = new System.Drawing.Size(220, 1);
            this.panelNavSeparator.TabIndex = 6;
            // 
            // comboValue
            // 
            this.comboValue.AutoResize = false;
            this.comboValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboValue.Depth = 0;
            this.comboValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboValue.DropDownHeight = 174;
            this.comboValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboValue.DropDownWidth = 121;
            this.comboValue.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboValue.FormattingEnabled = true;
            this.comboValue.Hint = "Filter Option";
            this.comboValue.IntegralHeight = false;
            this.comboValue.ItemHeight = 43;
            this.comboValue.Location = new System.Drawing.Point(20, 200);
            this.comboValue.MaxDropDownItems = 4;
            this.comboValue.MouseState = MaterialSkin.MouseState.OUT;
            this.comboValue.Name = "comboValue";
            this.comboValue.Size = new System.Drawing.Size(220, 49);
            this.comboValue.StartIndex = 0;
            this.comboValue.TabIndex = 5;
            this.comboValue.SelectionChangeCommitted += new System.EventHandler(this.comboValue_SelectionChangeCommitted);
            // 
            // comboType
            // 
            this.comboType.AutoResize = false;
            this.comboType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboType.Depth = 0;
            this.comboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboType.DropDownHeight = 174;
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.DropDownWidth = 121;
            this.comboType.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboType.FormattingEnabled = true;
            this.comboType.Hint = "Filter By";
            this.comboType.IntegralHeight = false;
            this.comboType.ItemHeight = 43;
            this.comboType.Items.AddRange(new object[] {
            "None",
            "Department",
            "Project"});
            this.comboType.Location = new System.Drawing.Point(20, 145);
            this.comboType.MaxDropDownItems = 4;
            this.comboType.MouseState = MaterialSkin.MouseState.OUT;
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(220, 49);
            this.comboType.StartIndex = 0;
            this.comboType.TabIndex = 4;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(180, 90);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(60, 50);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Find";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Hint = "Search Name/SSN...";
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(20, 90);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(155, 50);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "";
            this.txtSearch.TrailingIcon = null;
            // 
            // lblSearchFilterHeader
            // 
            this.lblSearchFilterHeader.AutoSize = true;
            this.lblSearchFilterHeader.Depth = 0;
            this.lblSearchFilterHeader.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSearchFilterHeader.Location = new System.Drawing.Point(20, 70);
            this.lblSearchFilterHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSearchFilterHeader.Name = "lblSearchFilterHeader";
            this.lblSearchFilterHeader.Size = new System.Drawing.Size(109, 17);
            this.lblSearchFilterHeader.TabIndex = 1;
            this.lblSearchFilterHeader.Text = "SEARCH & FILTERS";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(260, 65);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Depth = 0;
            this.lblLogo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLogo.Location = new System.Drawing.Point(20, 20);
            this.lblLogo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(126, 21);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "CORE PORTAL";
            // 
            // panelProjectActions
            // 
            this.panelProjectActions.BackColor = System.Drawing.Color.Transparent;
            this.panelProjectActions.Controls.Add(this.lblProjectActions);
            this.panelProjectActions.Controls.Add(this.btnInsertProject);
            this.panelProjectActions.Controls.Add(this.btnCountEmployees);
            this.panelProjectActions.Controls.Add(this.btnDeleteProject);
            this.panelProjectActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProjectActions.Location = new System.Drawing.Point(30, 85);
            this.panelProjectActions.Name = "panelProjectActions";
            this.panelProjectActions.Size = new System.Drawing.Size(880, 55);
            this.panelProjectActions.TabIndex = 2;
            this.panelProjectActions.Visible = false;
            // 
            // lblProjectActions
            // 
            this.lblProjectActions.AutoSize = true;
            this.lblProjectActions.Depth = 0;
            this.lblProjectActions.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProjectActions.Location = new System.Drawing.Point(15, 17);
            this.lblProjectActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProjectActions.Name = "lblProjectActions";
            this.lblProjectActions.Size = new System.Drawing.Size(110, 19);
            this.lblProjectActions.TabIndex = 0;
            this.lblProjectActions.Text = "Project Actions:";
            // 
            // btnInsertProject
            // 
            this.btnInsertProject.AutoSize = false;
            this.btnInsertProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertProject.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInsertProject.Depth = 0;
            this.btnInsertProject.HighEmphasis = true;
            this.btnInsertProject.Icon = null;
            this.btnInsertProject.Location = new System.Drawing.Point(135, 10);
            this.btnInsertProject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInsertProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertProject.Name = "btnInsertProject";
            this.btnInsertProject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInsertProject.Size = new System.Drawing.Size(125, 35);
            this.btnInsertProject.TabIndex = 1;
            this.btnInsertProject.Text = "+ New Project";
            this.btnInsertProject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInsertProject.UseAccentColor = false;
            this.btnInsertProject.UseVisualStyleBackColor = true;
            this.btnInsertProject.Click += new System.EventHandler(this.btnInsertProject_Click);
            // 
            // btnCountEmployees
            // 
            this.btnCountEmployees.AutoSize = false;
            this.btnCountEmployees.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCountEmployees.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCountEmployees.Depth = 0;
            this.btnCountEmployees.HighEmphasis = true;
            this.btnCountEmployees.Icon = null;
            this.btnCountEmployees.Location = new System.Drawing.Point(270, 10);
            this.btnCountEmployees.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCountEmployees.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCountEmployees.Name = "btnCountEmployees";
            this.btnCountEmployees.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCountEmployees.Size = new System.Drawing.Size(140, 35);
            this.btnCountEmployees.TabIndex = 2;
            this.btnCountEmployees.Text = "Count Employees";
            this.btnCountEmployees.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCountEmployees.UseAccentColor = false;
            this.btnCountEmployees.UseVisualStyleBackColor = true;
            this.btnCountEmployees.Click += new System.EventHandler(this.btnCountEmployees_Click);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.AutoSize = false;
            this.btnDeleteProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteProject.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteProject.Depth = 0;
            this.btnDeleteProject.HighEmphasis = true;
            this.btnDeleteProject.Icon = null;
            this.btnDeleteProject.Location = new System.Drawing.Point(420, 10);
            this.btnDeleteProject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteProject.Size = new System.Drawing.Size(120, 35);
            this.btnDeleteProject.TabIndex = 3;
            this.btnDeleteProject.Text = "Delete Project";
            this.btnDeleteProject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteProject.UseAccentColor = true;
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // AllContainer
            // 
            this.AllContainer.BackColor = System.Drawing.Color.Transparent;
            this.AllContainer.Controls.Add(this.EmployeeTable);
            this.AllContainer.Controls.Add(this.panelEmployeeActions);
            this.AllContainer.Controls.Add(this.panelProjectActions);
            this.AllContainer.Controls.Add(this.panelHeader);
            this.AllContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllContainer.Location = new System.Drawing.Point(260, 64);
            this.AllContainer.Name = "AllContainer";
            this.AllContainer.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.AllContainer.Size = new System.Drawing.Size(937, 633);
            this.AllContainer.TabIndex = 1;
            // 
            // EmployeeTable
            // 
            this.EmployeeTable.AllowUserToAddRows = false;
            this.EmployeeTable.AllowUserToDeleteRows = false;
            this.EmployeeTable.ReadOnly = true;
            this.EmployeeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeTable.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeTable.ColumnHeadersHeight = 35;
            this.EmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeTable.EnableHeadersVisualStyles = false;
            this.EmployeeTable.Location = new System.Drawing.Point(30, 140);
            this.EmployeeTable.Name = "EmployeeTable";
            this.EmployeeTable.RowHeadersVisible = false;
            this.EmployeeTable.Size = new System.Drawing.Size(877, 463);
            this.EmployeeTable.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.lblHeaderSubtitle);
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(30, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(877, 85);
            this.panelHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Depth = 0;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(0, 52);
            this.lblHeaderSubtitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(325, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "View, search, and filter employee records interactively.";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Depth = 0;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHeaderTitle.Location = new System.Drawing.Point(0, 20);
            this.lblHeaderTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(120, 29);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Employees";
            // 
            // panelEmployeeActions
            // 
            this.panelEmployeeActions.BackColor = System.Drawing.Color.Transparent;
            this.panelEmployeeActions.Controls.Add(this.btnEditEmployee);
            this.panelEmployeeActions.Controls.Add(this.btnDeleteEmployee);
            this.panelEmployeeActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEmployeeActions.Location = new System.Drawing.Point(30, 563);
            this.panelEmployeeActions.Name = "panelEmployeeActions";
            this.panelEmployeeActions.Size = new System.Drawing.Size(877, 40);
            this.panelEmployeeActions.TabIndex = 3;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.AutoSize = false;
            this.btnEditEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditEmployee.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditEmployee.Depth = 0;
            this.btnEditEmployee.HighEmphasis = true;
            this.btnEditEmployee.Icon = null;
            this.btnEditEmployee.Location = new System.Drawing.Point(0, 5);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditEmployee.Size = new System.Drawing.Size(140, 35);
            this.btnEditEmployee.TabIndex = 0;
            this.btnEditEmployee.Text = "Edit Selected";
            this.btnEditEmployee.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnEditEmployee.UseAccentColor = false;
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.AutoSize = false;
            this.btnDeleteEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteEmployee.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteEmployee.Depth = 0;
            this.btnDeleteEmployee.HighEmphasis = true;
            this.btnDeleteEmployee.Icon = null;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(150, 5);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteEmployee.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteEmployee.TabIndex = 1;
            this.btnDeleteEmployee.Text = "Delete Selected";
            this.btnDeleteEmployee.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteEmployee.UseAccentColor = true;
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.AllContainer);
            this.Controls.Add(this.panelSidebar);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelProjectActions.ResumeLayout(false);
            this.panelProjectActions.PerformLayout();
            this.AllContainer.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelEmployeeActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private MaterialSkin.Controls.MaterialLabel lblLogo;
        private MaterialSkin.Controls.MaterialLabel lblSearchFilterHeader;
        private System.Windows.Forms.Panel panelNavSeparator;
        private MaterialSkin.Controls.MaterialLabel lblNavHeader;
        private System.Windows.Forms.Button btnTabEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private MaterialSkin.Controls.MaterialComboBox comboType;
        private MaterialSkin.Controls.MaterialComboBox comboValue;
        private System.Windows.Forms.Panel AllContainer;
        private System.Windows.Forms.Panel panelHeader;
        private MaterialSkin.Controls.MaterialLabel lblHeaderTitle;
        private MaterialSkin.Controls.MaterialLabel lblHeaderSubtitle;
        private System.Windows.Forms.DataGridView EmployeeTable;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private System.Windows.Forms.Button btnRetrieveProjects;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelProjectActions;
        private MaterialSkin.Controls.MaterialLabel lblProjectActions;
        private MaterialSkin.Controls.MaterialButton btnInsertProject;
        private MaterialSkin.Controls.MaterialButton btnCountEmployees;
        private MaterialSkin.Controls.MaterialButton btnDeleteProject;
        private System.Windows.Forms.Button btnThemeToggle;
        private System.Windows.Forms.Button btnReportViewer;
        private System.Windows.Forms.Button btnDeptStats;
        private System.Windows.Forms.Panel panelEmployeeActions;
        private MaterialSkin.Controls.MaterialButton btnEditEmployee;
        private MaterialSkin.Controls.MaterialButton btnDeleteEmployee;
    }
}