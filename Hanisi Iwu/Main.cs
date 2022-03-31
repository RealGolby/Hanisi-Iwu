namespace Hanisi_Iwu
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void ShowMoviesBtn_Click(object sender, EventArgs e)
        {
            //label2.Text = m.Name;
        }

        private void AddMovieBtn_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.Show();
        }
    }
}