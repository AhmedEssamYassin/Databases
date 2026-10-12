using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Movie receivedMovie;
        List<Movie> listOfMovies;

        public Form2(List<Movie> listOfMovies, Movie currentMovie)
        {
            InitializeComponent();
            ApplyModernStyle();

            Text = "Movie List";
            this.MinimumSize = new Size(1000, 700);
            AllContainer.Location = new Point((ClientSize.Width - AllContainer.Width) / 2, (ClientSize.Height - AllContainer.Height) / 2);

            ActorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (ActorBox.Items.Count > 0)
            {
                ActorBox.SelectedIndex = 0;
            }

            MovieListGrid.Columns[0].Width = 200;
            MovieListGrid.Columns[1].Width = 200;
            MovieListGrid.Columns[2].Width = 200;
            MovieListGrid.Columns[3].Width = 200;
            MovieListGrid.Width = 843;

            receivedMovie = currentMovie;
            this.listOfMovies = listOfMovies;

            for (int i = 0; i < listOfMovies.Count; i++)
            {
                string MovieTitle = listOfMovies[i].Title;
                string MovieGenre = listOfMovies[i].Genre;
                string MovieAccessibility = listOfMovies[i].Accessibility;
                string MovieActor = listOfMovies[i].Actor;
                MovieListGrid.Rows.Add(MovieTitle, MovieActor, MovieGenre, MovieAccessibility);
            }
        }

        private void ApplyModernStyle()
        {
            this.BackColor = ColorTranslator.FromHtml("#F0F2F5");
            AllContainer.BackColor = Color.White;


            MovieListGrid.BackgroundColor = Color.White;
            MovieListGrid.BorderStyle = BorderStyle.None;
            MovieListGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            MovieListGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            MovieListGrid.EnableHeadersVisualStyles = false;
            MovieListGrid.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#343A40");
            MovieListGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            MovieListGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            MovieListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            MovieListGrid.ColumnHeadersHeight = 40;

            MovieListGrid.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#D6EAF8");
            MovieListGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            MovieListGrid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            MovieListGrid.DefaultCellStyle.Padding = new Padding(5);
            MovieListGrid.RowTemplate.Height = 35;

            MovieListGrid.RowHeadersVisible = false;
            MovieListGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MovieListGrid.AllowUserToAddRows = false;
            MovieListGrid.ReadOnly = true;


            ActorsLabel.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            ActorBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            MessageLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);


            StyleButton(AddActorButton, ColorTranslator.FromHtml("#28A745"));
            StyleButton(AddMovieButton, ColorTranslator.FromHtml("#6C757D"));
        }

        private void StyleButton(Button btn, Color color)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            AllContainer.Location = new Point((ClientSize.Width - AllContainer.Width) / 2, (ClientSize.Height - AllContainer.Height) / 2);
        }

        private void AddActorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ActorBox.Text))
            {
                MessageLabel.Text = "Please choose or write an actor";
                MessageLabel.ForeColor = Color.Red;
                MessageLabel.Visible = true;
            }
            else
            {
                Movie newMovie;
                newMovie.Title = receivedMovie.Title;
                newMovie.Genre = receivedMovie.Genre;
                newMovie.Accessibility = receivedMovie.Accessibility;
                newMovie.Actor = ActorBox.Text;

                listOfMovies.Add(newMovie);
                MovieListGrid.Rows.Add(newMovie.Title, newMovie.Actor, newMovie.Genre, newMovie.Accessibility);
                MessageLabel.Text = "Actor is added";
                MessageLabel.ForeColor = Color.Green;
                MessageLabel.Visible = true;
            }
        }

        private void ActorBox_TextChanged(object sender, EventArgs e)
        {
            MessageLabel.Visible = false;
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}