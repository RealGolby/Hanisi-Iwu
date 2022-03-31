namespace Hanisi_Iwu
{
    public partial class Main : Form
    {
        AddMovie addMovie;
        public Main()
        {
            addMovie = new AddMovie();
            InitializeComponent();
        }


        private void ShowMoviesBtn_Click(object sender, EventArgs e)
        {
            //label2.Text = m.Name;
        }

        private void AddMovieBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Add(addMovie);
            addMovie.Dock = DockStyle.Fill;
            addMovie.Show();
        }
    }
}