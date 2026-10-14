using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplyModernStyle();

            Text = "Login";
            this.MinimumSize = new Size(800, 550);

            this.AcceptButton = LoginButton; // Triggers `Click` Event (not MouseClick)

            AllContainer.Location = new Point((ClientSize.Width - AllContainer.Width) / 2, (ClientSize.Height - AllContainer.Height) / 2);
            PasswordTextBox.PasswordChar = '*';
        }

        private void ApplyModernStyle()
        {

            this.BackColor = ColorTranslator.FromHtml("#F0F2F5");
            AllContainer.BackColor = Color.White;
            AllContainer.BorderStyle = BorderStyle.FixedSingle;


            Font mainFont = new Font("Segoe UI", 12, FontStyle.Regular);
            Font titleFont = new Font("Segoe UI", 14, FontStyle.Bold);

            UsernameLabel.Font = mainFont;
            PasswordLabel.Font = mainFont;
            ShowCheckBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            msgLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);


            StyleTextBox(UsernameTextBox);
            StyleTextBox(PasswordTextBox);


            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.BackColor = ColorTranslator.FromHtml("#007BFF");
            LoginButton.ForeColor = Color.White;
            LoginButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            LoginButton.Cursor = Cursors.Hand;
        }

        private void StyleTextBox(TextBox tb)
        {
            tb.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.BackColor = ColorTranslator.FromHtml("#F8F9FA");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AllContainer.Location = new Point((ClientSize.Width - AllContainer.Width) / 2, (ClientSize.Height - AllContainer.Height) / 2);
        }

        private void ShowCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (ShowCheckBox.Checked == true)
                PasswordTextBox.PasswordChar = '\0';
            else
                PasswordTextBox.PasswordChar = '*';
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(username) || PasswordTextBox.Text != "123")
            {
                msgLabel.Text = "Wrong username or password";
                msgLabel.ForeColor = Color.Red;
            }
            else
            {
                msgLabel.Text = "";
                MessageBox.Show($"Hello, {username}");
                Form2 NewForm = new Form2(username);
                NewForm.Show();
                this.Hide();
            }
        }
    }
}
