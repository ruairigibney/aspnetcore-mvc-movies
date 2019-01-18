using System;

namespace Sample.MovieCatalogue.Data.Models
{
    public class Movie
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public int ReleaseYear {get; set; }

        public Movie()
        {
            ID = Guid.NewGuid();
        }
    }
}