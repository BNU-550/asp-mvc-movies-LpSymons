using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_movies
{
    public enum Genres
    {
        Comedy, Drama, Horror, Thriller,
    }

    /// <summary>
    /// 
    /// </summary>
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60), Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public Genres Genre { get; set; } = Genres.Comedy;

        [Range(5.99, 18.99),Required]
        public decimal Price { get; set; }
    }
}
