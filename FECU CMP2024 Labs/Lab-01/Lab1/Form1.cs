using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public struct Movie
    {
        public string Title;
        public string Genre;
        public string Accessibility;
        public string Actor;
    }

    public partial class Form1 : Form
    {
        List<Movie> Movies;

        public Form1()
        {
            InitializeComponent();
            ApplyModernStyle();

            Text = "Enter Movie Data";
            GenreGroupBox.Enabled = false;
            this.MinimumSize = new Size(800, 550);
            AllContainer.Location = new Point((ClientSize.Width - AllContainer.Width) / 2, (ClientSize.Height - AllContainer.Height) / 2);
            Movies = new List<Movie>();
        }

        private void ApplyModernStyle()
        {
            this.BackColor = ColorTranslator.FromHtml("#F0F2F5");
            AllContainer.BackColor = Color.White;
            AllContainer.BorderStyle = BorderStyle.FixedSingle;


            Font standardFont = new Font("Segoe UI", 10, FontStyle.Regular);
            Font headerFont = new Font("Segoe UI", 14, FontStyle.Bold);
            Font titleFont = new Font("Segoe UI", 22, FontStyle.Regular);

            TitleLabel.Font = titleFont;
            TitleLabel.ForeColor = Color.FromArgb(64, 64, 64);

            GenreCheckBox.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            GenreGroupBox.Font = headerFont;
            AccessibilityGroupBox.Font = headerFont;


            TitleText.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            TitleText.BorderStyle = BorderStyle.FixedSingle;

            OtherTextBox.Font = standardFont;
            OtherTextBox.BorderStyle = BorderStyle.FixedSingle;


            StyleButton(AddActorsButton);
        }

        private void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = ColorTranslator.FromHtml("#007BFF");
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            IntPtr hrgn = CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 10, 10);
            btn.Region?.Dispose();
            btn.Region = Region.FromHrgn(hrgn); 
            DeleteObject(hrgn);
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);

        private void Form1_Resize(object sender, EventArgs e)
        {
            AllContainer.Location = new Point((ClientSize.Width - AllContainer.Width) / 2, (ClientSize.Height - AllContainer.Height) / 2);
        }

        private void GenreCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            GenreGroupBox.Enabled = GenreCheckBox.Checked;
        }

        private void AddActorsButton_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(TitleText.Text))
            {
                errors.Add("- Movie Title is required.");
            }

            if (GenreGroupBox.Enabled)
            {
                if (!ComedyButton.Checked && !HorrorButton.Checked && !OtherButton.Checked)
                {
                    errors.Add("- Please select a genre.");
                }
                else if (OtherButton.Checked && string.IsNullOrWhiteSpace(OtherTextBox.Text))
                {
                    errors.Add("- Please enter the genre for 'Other'.");
                }
            }

            if (!PrivateButton.Checked && !PublicButton.Checked)
            {
                errors.Add("- Please select the accessibility option.");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show("Please correct the following errors:\n" + string.Join("\n", errors), 
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string MovieTitle = TitleText.Text;
            string MovieGenre = "";
            if (GenreGroupBox.Enabled)
            {
                if (ComedyButton.Checked)
                    MovieGenre = "Comedy";
                else if (HorrorButton.Checked)
                    MovieGenre = "Horror";
                else if (OtherButton.Checked)
                    MovieGenre = OtherTextBox.Text;
            }

            string MovieAccessibility;
            if (PrivateButton.Checked)
                MovieAccessibility = "Private";
            else
                MovieAccessibility = "Public";

            Movie currentMovie;
            currentMovie.Title = MovieTitle;
            currentMovie.Genre = MovieGenre;
            currentMovie.Accessibility = MovieAccessibility;
            currentMovie.Actor = "";

            this.Hide();
            using (Form2 PopForm = new Form2(Movies, currentMovie))
            {
                PopForm.ShowDialog();
            }
            this.Show();

            TitleText.Text = "";
            GenreCheckBox.Checked = false;
            ComedyButton.Checked = false;
            HorrorButton.Checked = false;
            OtherButton.Checked = false;
            OtherTextBox.Text = "";
            PrivateButton.Checked = false;
            PublicButton.Checked = false;
        }
    }
}