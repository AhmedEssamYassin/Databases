namespace WindowsFormsApp1
{
    partial class Form1
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
            AccessibilityGroupBox = new GroupBox();
            PrivateButton = new RadioButton();
            PublicButton = new RadioButton();
            GenreGroupBox = new GroupBox();
            OtherTextBox = new TextBox();
            OtherButton = new RadioButton();
            HorrorButton = new RadioButton();
            ComedyButton = new RadioButton();
            GenreCheckBox = new CheckBox();
            AddActorsButton = new Button();
            TitleText = new TextBox();
            TitleLabel = new Label();
            AllContainer.SuspendLayout();
            AccessibilityGroupBox.SuspendLayout();
            GenreGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AllContainer
            // 
            AllContainer.Controls.Add(AccessibilityGroupBox);
            AllContainer.Controls.Add(GenreGroupBox);
            AllContainer.Controls.Add(GenreCheckBox);
            AllContainer.Controls.Add(AddActorsButton);
            AllContainer.Controls.Add(TitleText);
            AllContainer.Controls.Add(TitleLabel);
            AllContainer.Location = new Point(68, 50);
            AllContainer.Margin = new Padding(4, 3, 4, 3);
            AllContainer.Name = "AllContainer";
            AllContainer.Size = new Size(652, 459);
            AllContainer.TabIndex = 10;
            // 
            // AccessibilityGroupBox
            // 
            AccessibilityGroupBox.Controls.Add(PrivateButton);
            AccessibilityGroupBox.Controls.Add(PublicButton);
            AccessibilityGroupBox.Font = new Font("Tahoma", 14F);
            AccessibilityGroupBox.Location = new Point(348, 177);
            AccessibilityGroupBox.Margin = new Padding(4, 3, 4, 3);
            AccessibilityGroupBox.Name = "AccessibilityGroupBox";
            AccessibilityGroupBox.Padding = new Padding(4, 3, 4, 3);
            AccessibilityGroupBox.Size = new Size(289, 159);
            AccessibilityGroupBox.TabIndex = 15;
            AccessibilityGroupBox.TabStop = false;
            AccessibilityGroupBox.Text = "Accessibility";
            // 
            // PrivateButton
            // 
            PrivateButton.AutoSize = true;
            PrivateButton.Location = new Point(7, 33);
            PrivateButton.Margin = new Padding(4, 3, 4, 3);
            PrivateButton.Name = "PrivateButton";
            PrivateButton.Size = new Size(84, 27);
            PrivateButton.TabIndex = 13;
            PrivateButton.TabStop = true;
            PrivateButton.Text = "Private";
            PrivateButton.UseVisualStyleBackColor = true;
            // 
            // PublicButton
            // 
            PublicButton.AutoSize = true;
            PublicButton.Location = new Point(7, 72);
            PublicButton.Margin = new Padding(4, 3, 4, 3);
            PublicButton.Name = "PublicButton";
            PublicButton.Size = new Size(77, 27);
            PublicButton.TabIndex = 14;
            PublicButton.TabStop = true;
            PublicButton.Text = "Public";
            PublicButton.UseVisualStyleBackColor = true;
            // 
            // GenreGroupBox
            // 
            GenreGroupBox.Controls.Add(OtherTextBox);
            GenreGroupBox.Controls.Add(OtherButton);
            GenreGroupBox.Controls.Add(HorrorButton);
            GenreGroupBox.Controls.Add(ComedyButton);
            GenreGroupBox.Font = new Font("Tahoma", 14F);
            GenreGroupBox.Location = new Point(22, 177);
            GenreGroupBox.Margin = new Padding(4, 3, 4, 3);
            GenreGroupBox.Name = "GenreGroupBox";
            GenreGroupBox.Padding = new Padding(4, 3, 4, 3);
            GenreGroupBox.Size = new Size(290, 159);
            GenreGroupBox.TabIndex = 14;
            GenreGroupBox.TabStop = false;
            GenreGroupBox.Text = "Genre";
            // 
            // OtherTextBox
            // 
            OtherTextBox.Location = new Point(102, 103);
            OtherTextBox.Margin = new Padding(4, 3, 4, 3);
            OtherTextBox.Name = "OtherTextBox";
            OtherTextBox.Size = new Size(173, 30);
            OtherTextBox.TabIndex = 13;
            // 
            // OtherButton
            // 
            OtherButton.AutoSize = true;
            OtherButton.Location = new Point(7, 103);
            OtherButton.Margin = new Padding(4, 3, 4, 3);
            OtherButton.Name = "OtherButton";
            OtherButton.Size = new Size(75, 27);
            OtherButton.TabIndex = 12;
            OtherButton.TabStop = true;
            OtherButton.Text = "Other";
            OtherButton.UseVisualStyleBackColor = true;
            // 
            // HorrorButton
            // 
            HorrorButton.AutoSize = true;
            HorrorButton.Location = new Point(7, 65);
            HorrorButton.Margin = new Padding(4, 3, 4, 3);
            HorrorButton.Name = "HorrorButton";
            HorrorButton.Size = new Size(82, 27);
            HorrorButton.TabIndex = 11;
            HorrorButton.TabStop = true;
            HorrorButton.Text = "Horror";
            HorrorButton.UseVisualStyleBackColor = true;
            // 
            // ComedyButton
            // 
            ComedyButton.AutoSize = true;
            ComedyButton.Location = new Point(7, 33);
            ComedyButton.Margin = new Padding(4, 3, 4, 3);
            ComedyButton.Name = "ComedyButton";
            ComedyButton.Size = new Size(95, 27);
            ComedyButton.TabIndex = 10;
            ComedyButton.TabStop = true;
            ComedyButton.Text = "Comedy";
            ComedyButton.UseVisualStyleBackColor = true;
            // 
            // GenreCheckBox
            // 
            GenreCheckBox.AutoSize = true;
            GenreCheckBox.Font = new Font("Tahoma", 14F);
            GenreCheckBox.Location = new Point(22, 118);
            GenreCheckBox.Margin = new Padding(4, 3, 4, 3);
            GenreCheckBox.Name = "GenreCheckBox";
            GenreCheckBox.Size = new Size(307, 27);
            GenreCheckBox.TabIndex = 13;
            GenreCheckBox.Text = "Choose the most matching genre";
            GenreCheckBox.UseVisualStyleBackColor = true;
            GenreCheckBox.CheckStateChanged += GenreCheckBox_CheckStateChanged;
            // 
            // AddActorsButton
            // 
            AddActorsButton.Font = new Font("Tahoma", 22F);
            AddActorsButton.Location = new Point(224, 377);
            AddActorsButton.Margin = new Padding(4, 3, 4, 3);
            AddActorsButton.Name = "AddActorsButton";
            AddActorsButton.Size = new Size(229, 53);
            AddActorsButton.TabIndex = 12;
            AddActorsButton.Text = "Add Actors";
            AddActorsButton.UseVisualStyleBackColor = true;
            AddActorsButton.Click += AddActorsButton_Click;
            // 
            // TitleText
            // 
            TitleText.Font = new Font("Tahoma", 22F);
            TitleText.Location = new Point(224, 30);
            TitleText.Margin = new Padding(4, 3, 4, 3);
            TitleText.Name = "TitleText";
            TitleText.Size = new Size(228, 43);
            TitleText.TabIndex = 11;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Tahoma", 22F);
            TitleLabel.Location = new Point(15, 32);
            TitleLabel.Margin = new Padding(4, 0, 4, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(159, 36);
            TitleLabel.TabIndex = 10;
            TitleLabel.Text = "Movie Title";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(798, 585);
            Controls.Add(AllContainer);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Resize += Form1_Resize;
            AllContainer.ResumeLayout(false);
            AllContainer.PerformLayout();
            AccessibilityGroupBox.ResumeLayout(false);
            AccessibilityGroupBox.PerformLayout();
            GenreGroupBox.ResumeLayout(false);
            GenreGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel AllContainer;
        private System.Windows.Forms.GroupBox AccessibilityGroupBox;
        private System.Windows.Forms.RadioButton PrivateButton;
        private System.Windows.Forms.RadioButton PublicButton;
        private System.Windows.Forms.GroupBox GenreGroupBox;
        private System.Windows.Forms.TextBox OtherTextBox;
        private System.Windows.Forms.RadioButton OtherButton;
        private System.Windows.Forms.RadioButton HorrorButton;
        private System.Windows.Forms.RadioButton ComedyButton;
        private System.Windows.Forms.CheckBox GenreCheckBox;
        private System.Windows.Forms.Button AddActorsButton;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.Label TitleLabel;
    }
}

