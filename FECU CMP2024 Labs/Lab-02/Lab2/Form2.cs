using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public Dictionary<string, List<string>> HourList = new Dictionary<string, List<string>>();
        public Dictionary<string, int> CourseHours = new Dictionary<string, int>();

        public Form2(string Name)
        {
            InitializeComponent();
            ApplyModernStyle();

            Text = "Register Form";
            this.AcceptButton = AddButton;
            this.MinimumSize = new Size(800, 550);
            AllContainer.Location = new Point((ClientSize.Width - AllContainer.Width) / 2, (ClientSize.Height - AllContainer.Height) / 2);

            StudentTextBox.Text = Name;
            StudentTextBox.Enabled = false;
            HoursTextBox.Text = "";
            HoursTextBox.Enabled = false;
            TotalHoursTextBox.Text = "";
            TotalHoursTextBox.Enabled = false;

            CoursesDataGrid.Columns[0].Width = 200;
            CoursesDataGrid.Columns[1].Width = 200;
            CoursesDataGrid.Columns[2].Width = 200;
            CoursesDataGrid.Width = 643;

            InitializeData();
        }

        private void InitializeData()
        {
            HourList["Algorithms"] = new List<string>() { "Sunday 1-4", "Monday 1-4" };
            HourList["Object Oriented Programming"] = new List<string>() { "Sunday 8-11", "Monday 8-11" };
            HourList["Data Structures"] = new List<string>() { "Tuesday 2-5", "Wednesday 2-5", "Thursday 2-5" };
            HourList["Database"] = new List<string>() { "Monday 8-10", "Tuesday 8-10", "Wednesday 8-10" };
            HourList["Operating Systems"] = new List<string>() { "Tuesday 3-5", "Wednesday 3-5", "Thursday 3-5" };

            CourseHours["Algorithms"] = 3;
            CourseHours["Object Oriented Programming"] = 3;
            CourseHours["Data Structures"] = 3;
            CourseHours["Database"] = 2;
            CourseHours["Operating Systems"] = 2;
        }

        private void ApplyModernStyle()
        {

            this.BackColor = ColorTranslator.FromHtml("#F0F2F5");
            AllContainer.BackColor = Color.White;
            AllContainer.BorderStyle = BorderStyle.FixedSingle;


            Font labelFont = new Font("Segoe UI", 11, FontStyle.Regular);
            Font inputFont = new Font("Segoe UI", 11, FontStyle.Regular);

            foreach (Control c in AllContainer.Controls)
            {
                if (c is Label) c.Font = labelFont;
                if (c is TextBox) { c.Font = inputFont; c.BackColor = ColorTranslator.FromHtml("#F8F9FA"); }
                if (c is ComboBox) c.Font = inputFont;
            }

            StudentTextBox.BackColor = ColorTranslator.FromHtml("#E9ECEF");
            HoursTextBox.BackColor = ColorTranslator.FromHtml("#E9ECEF");
            TotalHoursTextBox.BackColor = ColorTranslator.FromHtml("#E9ECEF");


            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.BackColor = ColorTranslator.FromHtml("#28A745");
            AddButton.ForeColor = Color.White;
            AddButton.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            AddButton.Cursor = Cursors.Hand;
            AddButton.Text = "Add Course";


            CoursesDataGrid.BackgroundColor = Color.White;
            CoursesDataGrid.BorderStyle = BorderStyle.None;
            CoursesDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CoursesDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            CoursesDataGrid.EnableHeadersVisualStyles = false;
            CoursesDataGrid.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#343A40");
            CoursesDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            CoursesDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            CoursesDataGrid.ColumnHeadersHeight = 35;

            CoursesDataGrid.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#D6EAF8");
            CoursesDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            CoursesDataGrid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            CoursesDataGrid.RowTemplate.Height = 30;
            CoursesDataGrid.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F8F9FA");
            CoursesDataGrid.RowHeadersVisible = false;
            CoursesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void EmptyHourList()
        {
            HoursComboBox.Items.Clear();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            AllContainer.Location = new Point((ClientSize.Width - AllContainer.Width) / 2, (ClientSize.Height - AllContainer.Height) / 2);
        }

        private void CourseComboBox_TextChanged(object sender, EventArgs e)
        {
            EmptyHourList();
            string CurrentCourse = CourseComboBox.Text;

            bool ValidCourse = false;
            for (int i = 0; i < CourseComboBox.Items.Count; i++)
                ValidCourse = ValidCourse | (CurrentCourse == CourseComboBox.GetItemText(CourseComboBox.Items[i]));

            if (!ValidCourse)
            {
                msgLabel.Text = "Invalid Course";
                msgLabel.ForeColor = Color.Red;
            }
            else
            {
                bool isTaken = false;
                foreach (DataGridViewRow row in CoursesDataGrid.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells[0].Value?.ToString() == CurrentCourse)
                    {
                        isTaken = true;
                        break;
                    }
                }

                if (isTaken)
                {
                    msgLabel.Text = "Course is already taken";
                    msgLabel.ForeColor = Color.Red;
                }
                else
                {
                    msgLabel.Text = "";
                }

                HoursTextBox.Text = CourseHours[CurrentCourse].ToString();
                for (int i = 0; i < HourList[CurrentCourse].Count; i++)
                    HoursComboBox.Items.Add(HourList[CurrentCourse][i]);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string CurrentCourse = CourseComboBox.Text;
            string CurrentTimeSlot = HoursComboBox.Text;

            bool ValidCourse = false;
            bool ValidTimeSlot = false;

            for (int i = 0; i < CourseComboBox.Items.Count; i++)
                ValidCourse = ValidCourse | (CurrentCourse == CourseComboBox.GetItemText(CourseComboBox.Items[i]));

            for (int i = 0; i < HoursComboBox.Items.Count; i++)
                ValidTimeSlot = ValidTimeSlot | (CurrentTimeSlot == HoursComboBox.GetItemText(HoursComboBox.Items[i]));

            if (!ValidCourse || !ValidTimeSlot)
            {
                msgLabel.Text = "Invalid Course or Time Slot";
                msgLabel.ForeColor = Color.Red;
            }
            else
            {
                msgLabel.Text = "";
                bool FoundCourseAndSlot = false;

                foreach (DataGridViewRow row in CoursesDataGrid.Rows)
                {
                    if (row.IsNewRow) continue;

                    string? courseInRow = row.Cells[0].Value?.ToString();
                    string? timeSlotInRow = row.Cells[1].Value?.ToString();

                    if (courseInRow == CurrentCourse || timeSlotInRow == CurrentTimeSlot)
                    {
                        FoundCourseAndSlot = true;
                        break;
                    }
                }

                if (FoundCourseAndSlot)
                {
                    bool courseTaken = false;
                    foreach (DataGridViewRow row in CoursesDataGrid.Rows)
                    {
                        if (row.IsNewRow) continue;
                        if (row.Cells[0].Value?.ToString() == CurrentCourse)
                            courseTaken = true;
                    }

                    if (courseTaken)
                        msgLabel.Text = "Course is already taken";
                    else
                        msgLabel.Text = "Time slot conflict";

                    msgLabel.ForeColor = Color.Red;
                }
                else
                {
                    if (TotalHoursTextBox.Text == "")
                        TotalHoursTextBox.Text = "0";
                    TotalHoursTextBox.Text = (Int32.Parse(TotalHoursTextBox.Text) + CourseHours[CurrentCourse]).ToString();
                    CoursesDataGrid.Rows.Add(CurrentCourse, HoursComboBox.Text, CourseHours[CurrentCourse].ToString());
                }
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void HoursComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (msgLabel.Text == "Time slot conflict" || msgLabel.Text == "Invalid Course or Time Slot")
            {
                msgLabel.Text = "";
            }
        }
    }
}