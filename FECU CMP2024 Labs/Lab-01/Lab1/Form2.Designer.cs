namespace WindowsFormsApp1
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
            components = new System.ComponentModel.Container();
            AllContainer = new Panel();
            AddMovieButton = new Button();
            MessageLabel = new Label();
            AddActorButton = new Button();
            ActorBox = new ComboBox();
            ActorsLabel = new Label();
            MovieListGrid = new DataGridView();
            MovieCol = new DataGridViewTextBoxColumn();
            ActorCol = new DataGridViewTextBoxColumn();
            GenreCol = new DataGridViewTextBoxColumn();
            AccessibilityCol = new DataGridViewTextBoxColumn();
            form1BindingSource = new BindingSource(components);
            AllContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MovieListGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            SuspendLayout();
            // 
            // AllContainer
            // 
            AllContainer.Controls.Add(AddMovieButton);
            AllContainer.Controls.Add(MessageLabel);
            AllContainer.Controls.Add(AddActorButton);
            AllContainer.Controls.Add(ActorBox);
            AllContainer.Controls.Add(ActorsLabel);
            AllContainer.Controls.Add(MovieListGrid);
            AllContainer.Font = new Font("Tahoma", 10F);
            AllContainer.Location = new Point(111, 53);
            AllContainer.Margin = new Padding(4, 3, 4, 3);
            AllContainer.Name = "AllContainer";
            AllContainer.Size = new Size(900, 566);
            AllContainer.TabIndex = 0;
            // 
            // AddMovieButton
            // 
            AddMovieButton.Font = new Font("Tahoma", 14F);
            AddMovieButton.Location = new Point(23, 449);
            AddMovieButton.Margin = new Padding(4, 3, 4, 3);
            AddMovieButton.Name = "AddMovieButton";
            AddMovieButton.Size = new Size(227, 38);
            AddMovieButton.TabIndex = 5;
            AddMovieButton.Text = "Add New Movie";
            AddMovieButton.UseVisualStyleBackColor = true;
            AddMovieButton.Click += AddMovieButton_Click;
            // 
            // MessageLabel
            // 
            MessageLabel.BackColor = Color.Transparent;
            MessageLabel.Location = new Point(513, 76);
            MessageLabel.Margin = new Padding(4, 3, 4, 3);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(295, 17);
            MessageLabel.TabIndex = 4;
            MessageLabel.Visible = false;
            // 
            // AddActorButton
            // 
            AddActorButton.Font = new Font("Tahoma", 14F);
            AddActorButton.Location = new Point(513, 32);
            AddActorButton.Margin = new Padding(4, 3, 4, 3);
            AddActorButton.Name = "AddActorButton";
            AddActorButton.Size = new Size(117, 38);
            AddActorButton.TabIndex = 3;
            AddActorButton.Text = "Add Actor";
            AddActorButton.UseVisualStyleBackColor = true;
            AddActorButton.Click += AddActorButton_Click;
            // 
            // ActorBox
            // 
            ActorBox.FormattingEnabled = true;
            ActorBox.Items.AddRange(new object[] { "Tom Cruise", "Matt Damon", "Brad Pitt", "Leonardo DiCaprio", "Angelina Jolie", "Daniel Craig" });
            ActorBox.Location = new Point(187, 42);
            ActorBox.Margin = new Padding(4, 3, 4, 3);
            ActorBox.Name = "ActorBox";
            ActorBox.Size = new Size(140, 24);
            ActorBox.TabIndex = 2;
            ActorBox.TextChanged += ActorBox_TextChanged;
            // 
            // ActorsLabel
            // 
            ActorsLabel.AutoSize = true;
            ActorsLabel.Font = new Font("Tahoma", 14F);
            ActorsLabel.Location = new Point(19, 38);
            ActorsLabel.Margin = new Padding(4, 0, 4, 0);
            ActorsLabel.Name = "ActorsLabel";
            ActorsLabel.Size = new Size(61, 23);
            ActorsLabel.TabIndex = 1;
            ActorsLabel.Text = "Actors";
            // 
            // MovieListGrid
            // 
            MovieListGrid.AllowUserToOrderColumns = true;
            MovieListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MovieListGrid.Columns.AddRange(new DataGridViewColumn[] { MovieCol, ActorCol, GenreCol, AccessibilityCol });
            MovieListGrid.Location = new Point(23, 110);
            MovieListGrid.Margin = new Padding(4, 3, 4, 3);
            MovieListGrid.Name = "MovieListGrid";
            MovieListGrid.Size = new Size(444, 300);
            MovieListGrid.TabIndex = 0;
            // 
            // MovieCol
            // 
            MovieCol.HeaderText = "Movie";
            MovieCol.Name = "MovieCol";
            // 
            // ActorCol
            // 
            ActorCol.HeaderText = "Actor";
            ActorCol.Name = "ActorCol";
            // 
            // GenreCol
            // 
            GenreCol.HeaderText = "Genre";
            GenreCol.Name = "GenreCol";
            // 
            // AccessibilityCol
            // 
            AccessibilityCol.HeaderText = "Accessibility";
            AccessibilityCol.Name = "AccessibilityCol";
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(Form1);
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 650);
            Controls.Add(AllContainer);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Form2";
            Resize += Form2_Resize;
            AllContainer.ResumeLayout(false);
            AllContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MovieListGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel AllContainer;
        private System.Windows.Forms.DataGridView MovieListGrid;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Label ActorsLabel;
        private System.Windows.Forms.ComboBox ActorBox;
        private System.Windows.Forms.Button AddActorButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessibilityCol;
        private System.Windows.Forms.Button AddMovieButton;
    }
}