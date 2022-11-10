using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public enum Genres
    {
        Comedy, 
        Drama,
        Animated,
        Horror
    }
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60)]
        public string Title { get; set; } = String.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Genres Genre { get; set; }

        [Range(2.99, 7.99)]
        public decimal Price { get; set; }
    }
}
