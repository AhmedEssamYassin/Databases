namespace Lab2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AllContainer = new Panel();
            msgLabel = new Label();
            CoursesDataGrid = new DataGridView();
            CourseColumn = new DataGridViewTextBoxColumn();
            TimeSlotColumn = new DataGridViewTextBoxColumn();
            HoursColumn = new DataGridViewTextBoxColumn();
            TotalHoursTextBox = new TextBox();
            TotalHoursLabel = new Label();
            AddButton = new Button();
            HoursComboBox = new ComboBox();
            TimeLabel = new Label();
            HoursTextBox = new TextBox();
            HoursLabel = new Label();
            CourseComboBox = new ComboBox();
            CourseLabel = new Label();
            StudentTextBox = new TextBox();
            StudentLabel = new Label();
            AllContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CoursesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // AllContainer
            // 
            AllContainer.Controls.Add(msgLabel);
            AllContainer.Controls.Add(CoursesDataGrid);
            AllContainer.Controls.Add(TotalHoursTextBox);
            AllContainer.Controls.Add(TotalHoursLabel);
            AllContainer.Controls.Add(AddButton);
            AllContainer.Controls.Add(HoursComboBox);
            AllContainer.Controls.Add(TimeLabel);
            AllContainer.Controls.Add(HoursTextBox);
            AllContainer.Controls.Add(HoursLabel);
            AllContainer.Controls.Add(CourseComboBox);
            AllContainer.Controls.Add(CourseLabel);
            AllContainer.Controls.Add(StudentTextBox);
            AllContainer.Controls.Add(StudentLabel);
            AllContainer.Font = new Font("Segoe UI", 14F);
            AllContainer.Location = new Point(99, 43);
            AllContainer.Name = "AllContainer";
            AllContainer.Size = new Size(786, 504);
            AllContainer.TabIndex = 0;
            // 
            // msgLabel
            // 
            msgLabel.AutoSize = true;
            msgLabel.Location = new Point(188, 112);
            msgLabel.Name = "msgLabel";
            msgLabel.Size = new Size(0, 25);
            msgLabel.TabIndex = 12;
            // 
            // CoursesDataGrid
            // 
            CoursesDataGrid.AllowUserToAddRows = false;
            CoursesDataGrid.AllowUserToDeleteRows = false;
            CoursesDataGrid.AllowUserToOrderColumns = false;
            CoursesDataGrid.ReadOnly = true;
            CoursesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoursesDataGrid.Columns.AddRange(new DataGridViewColumn[] { CourseColumn, TimeSlotColumn, HoursColumn });
            CoursesDataGrid.Location = new Point(45, 269);
            CoursesDataGrid.Name = "CoursesDataGrid";
            CoursesDataGrid.Size = new Size(339, 165);
            CoursesDataGrid.TabIndex = 11;
            // 
            // CourseColumn
            // 
            CourseColumn.HeaderText = "Course";
            CourseColumn.Name = "CourseColumn";
            // 
            // TimeSlotColumn
            // 
            TimeSlotColumn.HeaderText = "Time Slot";
            TimeSlotColumn.Name = "TimeSlotColumn";
            // 
            // HoursColumn
            // 
            HoursColumn.HeaderText = "Hours";
            HoursColumn.Name = "HoursColumn";
            // 
            // TotalHoursTextBox
            // 
            TotalHoursTextBox.Location = new Point(379, 211);
            TotalHoursTextBox.Name = "TotalHoursTextBox";
            TotalHoursTextBox.Size = new Size(84, 32);
            TotalHoursTextBox.TabIndex = 10;
            // 
            // TotalHoursLabel
            // 
            TotalHoursLabel.AutoSize = true;
            TotalHoursLabel.Location = new Point(244, 214);
            TotalHoursLabel.Name = "TotalHoursLabel";
            TotalHoursLabel.Size = new Size(107, 25);
            TotalHoursLabel.TabIndex = 9;
            TotalHoursLabel.Text = "Total Hours";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(45, 206);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(123, 40);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add Course";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // HoursComboBox
            // 
            HoursComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            HoursComboBox.FormattingEnabled = true;
            HoursComboBox.Location = new Point(154, 153);
            HoursComboBox.Name = "HoursComboBox";
            HoursComboBox.Size = new Size(230, 33);
            HoursComboBox.TabIndex = 7;
            HoursComboBox.SelectedIndexChanged += HoursComboBox_SelectedIndexChanged;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(45, 156);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(98, 25);
            TimeLabel.TabIndex = 6;
            TimeLabel.Text = "Time Slots";
            // 
            // HoursTextBox
            // 
            HoursTextBox.Location = new Point(515, 76);
            HoursTextBox.Name = "HoursTextBox";
            HoursTextBox.Size = new Size(84, 32);
            HoursTextBox.TabIndex = 5;
            // 
            // HoursLabel
            // 
            HoursLabel.AutoSize = true;
            HoursLabel.Location = new Point(426, 79);
            HoursLabel.Name = "HoursLabel";
            HoursLabel.Size = new Size(62, 25);
            HoursLabel.TabIndex = 4;
            HoursLabel.Text = "Hours";
            // 
            // CourseComboBox
            // 
            CourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseComboBox.FormattingEnabled = true;
            CourseComboBox.Items.AddRange(new object[] { "Algorithms", "Object Oriented Programming", "Data Structures", "Database", "Operating Systems" });
            CourseComboBox.Location = new Point(154, 76);
            CourseComboBox.Name = "CourseComboBox";
            CourseComboBox.Size = new Size(250, 33);
            CourseComboBox.TabIndex = 3;
            CourseComboBox.TextChanged += CourseComboBox_TextChanged;
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Location = new Point(45, 79);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(71, 25);
            CourseLabel.TabIndex = 2;
            CourseLabel.Text = "Course";
            // 
            // StudentTextBox
            // 
            StudentTextBox.Location = new Point(154, 24);
            StudentTextBox.Name = "StudentTextBox";
            StudentTextBox.Size = new Size(230, 32);
            StudentTextBox.TabIndex = 1;
            // 
            // StudentLabel
            // 
            StudentLabel.AutoSize = true;
            StudentLabel.Location = new Point(45, 27);
            StudentLabel.Name = "StudentLabel";
            StudentLabel.Size = new Size(76, 25);
            StudentLabel.TabIndex = 1;
            StudentLabel.Text = "Student";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 585);
            Controls.Add(AllContainer);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Resize += Form2_Resize;
            AllContainer.ResumeLayout(false);
            AllContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CoursesDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel AllContainer;
        private Label StudentLabel;
        private TextBox StudentTextBox;
        private Label CourseLabel;
        private TextBox HoursTextBox;
        private Label HoursLabel;
        private ComboBox CourseComboBox;
        private ComboBox HoursComboBox;
        private Label TimeLabel;
        private Label TotalHoursLabel;
        private Button AddButton;
        private TextBox TotalHoursTextBox;
        private DataGridView CoursesDataGrid;
        private DataGridViewTextBoxColumn CourseColumn;
        private DataGridViewTextBoxColumn TimeSlotColumn;
        private DataGridViewTextBoxColumn HoursColumn;
        private Label msgLabel;
    }
}