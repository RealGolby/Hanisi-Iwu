using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanisi_Iwu
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void LoadMovie_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text.StartsWith("https://www.csfd.cz/film/"))
            {
                Movie movie = MovieAdder.GetMovie(textBox1.Text);
                MovieName.Text = movie.Name;
                Rating.Text = movie.Rating.ToString() + "%";
            }
                
        }

        private void SaveMovie_Click(object sender, EventArgs e)
        {

        }
    }
}
