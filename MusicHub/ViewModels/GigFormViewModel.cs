﻿using MusicHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicHub.ViewModels
{
    public class GigFormViewModel
    {

        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public DateTime DateTime { get { return DateTime.Parse(string.Format("{0} {1}", Date, Time)); } }
        public IEnumerable<Genre> Genres { get; set; }
        
    }
}