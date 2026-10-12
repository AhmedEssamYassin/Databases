namespace DBapplication
{
    partial class Login
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
            this.panelLoginCard = new System.Windows.Forms.Panel();
            this.ShowPasswordCheck = new MaterialSkin.Controls.MaterialCheckbox();
            this.labelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.LogButton = new MaterialSkin.Controls.MaterialButton();
            this.ExitButton = new MaterialSkin.Controls.MaterialButton();
            this.Password = new MaterialSkin.Controls.MaterialTextBox();
            this.UserName = new MaterialSkin.Controls.MaterialTextBox();
            this.AllContainer.SuspendLayout();
            this.panelLoginCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllContainer
            // 
            this.AllContainer.BackColor = System.Drawing.Color.Transparent;
            this.AllContainer.Controls.Add(this.panelLoginCard);
            this.AllContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllContainer.Location = new System.Drawing.Point(3, 64);
            this.AllContainer.Name = "AllContainer";
            this.AllContainer.Size = new System.Drawing.Size(394, 483);
            this.AllContainer.TabIndex = 0;
            // 
            // panelLoginCard
            // 
            this.panelLoginCard.BackColor = System.Drawing.Color.Transparent;
            this.panelLoginCard.Controls.Add(this.ShowPasswordCheck);
            this.panelLoginCard.Controls.Add(this.labelTitle);
            this.panelLoginCard.Controls.Add(this.LogButton);
            this.panelLoginCard.Controls.Add(this.Password);
            this.panelLoginCard.Controls.Add(this.ExitButton);
            this.panelLoginCard.Controls.Add(this.UserName);
            this.panelLoginCard.Location = new System.Drawing.Point(47, 41);
            this.panelLoginCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLoginCard.Name = "panelLoginCard";
            this.panelLoginCard.Size = new System.Drawing.Size(300, 400);
            this.panelLoginCard.TabIndex = 3;
            // 
            // ShowPasswordCheck
            // 
            this.ShowPasswordCheck.AutoSize = true;
            this.ShowPasswordCheck.Depth = 0;
            this.ShowPasswordCheck.Location = new System.Drawing.Point(30, 210);
            this.ShowPasswordCheck.Margin = new System.Windows.Forms.Padding(0);
            this.ShowPasswordCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ShowPasswordCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowPasswordCheck.Name = "ShowPasswordCheck";
            this.ShowPasswordCheck.Ripple = true;
            this.ShowPasswordCheck.Size = new System.Drawing.Size(149, 37);
            this.ShowPasswordCheck.TabIndex = 6;
            this.ShowPasswordCheck.Text = "Show Password";
            this.ShowPasswordCheck.UseVisualStyleBackColor = true;
            this.ShowPasswordCheck.CheckedChanged += new System.EventHandler(this.ShowPasswordCheck_CheckedChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Depth = 0;
            this.labelTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.Location = new System.Drawing.Point(95, 20);
            this.labelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(102, 29);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Welcome";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogButton
            // 
            this.LogButton.AutoSize = false;
            this.LogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LogButton.Depth = 0;
            this.LogButton.HighEmphasis = true;
            this.LogButton.Icon = null;
            this.LogButton.Location = new System.Drawing.Point(30, 265);
            this.LogButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LogButton.Name = "LogButton";
            this.LogButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LogButton.Size = new System.Drawing.Size(240, 45);
            this.LogButton.TabIndex = 2;
            this.LogButton.Text = "LOGIN";
            this.LogButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LogButton.UseAccentColor = false;
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogButton_MouseClick);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = false;
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ExitButton.Depth = 0;
            this.ExitButton.HighEmphasis = false;
            this.ExitButton.Icon = null;
            this.ExitButton.Location = new System.Drawing.Point(30, 325);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ExitButton.Size = new System.Drawing.Size(240, 45);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.ExitButton.UseAccentColor = false;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseClick);
            // 
            // Password
            // 
            this.Password.AnimateReadOnly = false;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Depth = 0;
            this.Password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Password.Hint = "Password";
            this.Password.LeadingIcon = null;
            this.Password.Location = new System.Drawing.Point(30, 140);
            this.Password.MaxLength = 50;
            this.Password.MouseState = MaterialSkin.MouseState.OUT;
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.Password = true;
            this.Password.Size = new System.Drawing.Size(240, 50);
            this.Password.TabIndex = 1;
            this.Password.Text = "";
            this.Password.TrailingIcon = null;
            // 
            // UserName
            // 
            this.UserName.AnimateReadOnly = false;
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName.Depth = 0;
            this.UserName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserName.Hint = "Username";
            this.UserName.LeadingIcon = null;
            this.UserName.Location = new System.Drawing.Point(30, 75);
            this.UserName.MaxLength = 50;
            this.UserName.MouseState = MaterialSkin.MouseState.OUT;
            this.UserName.Multiline = false;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(240, 50);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "";
            this.UserName.TrailingIcon = null;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.AllContainer);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Portal Login";
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.AllContainer.ResumeLayout(false);
            this.panelLoginCard.ResumeLayout(false);
            this.panelLoginCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AllContainer;
        private System.Windows.Forms.Panel panelLoginCard;
        private MaterialSkin.Controls.MaterialTextBox UserName;
        private MaterialSkin.Controls.MaterialTextBox Password;
        private MaterialSkin.Controls.MaterialButton LogButton;
        private MaterialSkin.Controls.MaterialButton ExitButton;
        private MaterialSkin.Controls.MaterialLabel labelTitle;
        private MaterialSkin.Controls.MaterialCheckbox ShowPasswordCheck;
    }
}