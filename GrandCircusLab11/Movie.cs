using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab11
{


    class Movie
    {
        private string Title;
        private string Genre;


        public Movie(string title, string genre)
        {
        Title = title;
        Genre = genre;
        }
    
        public string GetTitle()
        {
            return Title;
        }

        public string GetGenre()
        {
            return Genre;
        }


    }
}
