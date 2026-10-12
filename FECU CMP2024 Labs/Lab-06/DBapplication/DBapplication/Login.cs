using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace DBapplication
{
    public partial class Login : MaterialForm
    {
        private Controller controllerObj;

        public Login()
        {
            InitializeComponent();
            controllerObj = new Controller();

            UserName.KeyDown += new KeyEventHandler(EnterKey_KeyDown);
            Password.KeyDown += new KeyEventHandler(EnterKey_KeyDown);

            MaterialThemeManager.Initialize(this);
        }

        private void EnterKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Stop the "ding" sound
                AttemptLogin();
            }
        }

        private void AttemptLogin()
        {
            if (string.IsNullOrWhiteSpace(UserName.Text) || string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Please enter a valid username and password.");
                return;
            }

            if (controllerObj.CheckAdmin(UserName.Text, Password.Text) > 0)
            {
                controllerObj.TerminateConnection();
                Form FormToApp = new Dashboard(this);
                FormToApp.Show();
                this.Hide();
            }
            else
            {
                UserName.Text = "";
                Password.Text = "";
                MessageBox.Show("Wrong Username or Password!");
            }
        }

        private void ShowPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            Password.Password = !ShowPasswordCheck.Checked;
        }

        private void LogButton_MouseClick(object sender, MouseEventArgs e)
        {
            AttemptLogin();
        }
      
        private void Exit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            LogButton.Focus();
        }

        public void ResetLoginFields()
        {
            UserName.Text = "";
            Password.Text = "";
            LogButton.Focus();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            controllerObj.TerminateConnection();
            base.OnFormClosed(e);
        }
    }
}