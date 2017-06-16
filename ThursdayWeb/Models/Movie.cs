using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ThursdayWeb.Models
{
    public class Movie
    {

        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public String Title { get; set; }


        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:yyyy-MM-dd}")]
        public DateTime ReleaseDate { get; set; }

        [Range(1,100)]
        [DataType(DataType.Currency)]
        public Decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }


}