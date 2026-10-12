namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AllContainer = new Panel();
            msgLabel = new Label();
            LoginButton = new Button();
            ShowCheckBox = new CheckBox();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            UsernameLabel = new Label();
            UsernameTextBox = new TextBox();
            AllContainer.SuspendLayout();
            SuspendLayout();
            // 
            // AllContainer
            // 
            AllContainer.Controls.Add(msgLabel);
            AllContainer.Controls.Add(LoginButton);
            AllContainer.Controls.Add(ShowCheckBox);
            AllContainer.Controls.Add(PasswordLabel);
            AllContainer.Controls.Add(PasswordTextBox);
            AllContainer.Controls.Add(UsernameLabel);
            AllContainer.Controls.Add(UsernameTextBox);
            AllContainer.Font = new Font("Segoe UI", 14F);
            AllContainer.Location = new Point(101, 67);
            AllContainer.Name = "AllContainer";
            AllContainer.Size = new Size(598, 347);
            AllContainer.TabIndex = 0;
            // 
            // msgLabel
            // 
            msgLabel.AutoSize = true;
            msgLabel.Location = new Point(159, 286);
            msgLabel.Name = "msgLabel";
            msgLabel.Size = new Size(0, 25);
            msgLabel.TabIndex = 6;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(229, 230);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(111, 37);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // ShowCheckBox
            // 
            ShowCheckBox.AutoSize = true;
            ShowCheckBox.Location = new Point(61, 180);
            ShowCheckBox.Name = "ShowCheckBox";
            ShowCheckBox.Size = new Size(161, 29);
            ShowCheckBox.TabIndex = 4;
            ShowCheckBox.Text = "Show Password";
            ShowCheckBox.UseVisualStyleBackColor = true;
            ShowCheckBox.CheckStateChanged += ShowCheckBox_CheckStateChanged;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(61, 109);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(91, 25);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(195, 106);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(265, 32);
            PasswordTextBox.TabIndex = 2;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(61, 54);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(97, 25);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(195, 51);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(265, 32);
            UsernameTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(AllContainer);
            Name = "Form1";
            Text = "Form1";
            Resize += Form1_Resize;
            AllContainer.ResumeLayout(false);
            AllContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AllContainer;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Button LoginButton;
        private CheckBox ShowCheckBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Label msgLabel;
    }
}
