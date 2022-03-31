using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanisi_Iwu
{
    public enum Genres
    {

    }
    internal class Movie
    {
        public string ?Name { get; set; }
        public int Rating { get; set; }
        public Genres Genres { get; set; }
        public int Lenght { get; set; }
        public string ?ReleaseDate { get; set; }
        public string ?Director { get; set; }

        public int PersonalRating { get; set; }
        public string ?Notes { get; set; }
        public string ?SpecialAward { get; set; }
    }
}
