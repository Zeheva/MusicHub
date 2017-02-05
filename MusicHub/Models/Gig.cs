using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicHub.Models
{
    public class Gig
    {
        public ApplicationUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        public string Venue { get; set; }
        public Genre Genre { get; set; }





    }

    public class Genre
    {
        public byte  Id { get; set; }
        public string Name { get; set;  }


    }
}