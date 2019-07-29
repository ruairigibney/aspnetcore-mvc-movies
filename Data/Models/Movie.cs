using System;
using System.ComponentModel.DataAnnotations;

namespace Sample.MovieCatalogue.Data.Models
{
    public class Movie
    {
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Title is a mandatory field.")]
        public string Title { get; set; }

        [RangeUntilCurrentYear(1900, ErrorMessage = "Please enter a valid year.")]
        public int ReleaseYear {get; set; }

        public Movie()
        {
            ID = Guid.NewGuid();
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class RangeUntilCurrentYearAttribute : RangeAttribute
    {
        public RangeUntilCurrentYearAttribute(int minimum) : base(minimum, DateTime.Now.Year)
        {
        }
    }
}
