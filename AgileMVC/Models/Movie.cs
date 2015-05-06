using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AgileMVC.Models
{
    public class Movie
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        //public DateTime ReleaseDate { get; set; }
        public string ForeignName { get; set; }
        public string SecondName { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}