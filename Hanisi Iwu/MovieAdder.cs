using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanisi_Iwu
{
    internal class MovieAdder
    {
        public static Movie GetMovie(string siteAdress)
        {
            Movie movie = new();
            HtmlAgilityPack.HtmlWeb web = new();
            HtmlAgilityPack.HtmlDocument doc = web.Load(siteAdress);

            movie.Name = doc.DocumentNode.SelectSingleNode(@"//*[@id=""page-wrapper""]/div/div[1]/div/div[1]/div[2]/div/header/div/h1").InnerText;

            return movie;
        }
    }
}
