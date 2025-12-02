using System.ComponentModel.DataAnnotations;

namespace Library.Models.Entity
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        public string GenreName { get; set; }

        // Navigation
        public ICollection<Book> Books { get; set; }
    }
}
