using System.ComponentModel.DataAnnotations;

namespace Library.Models.Entity
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        public string FullName { get; set; }

        public string? PhotoUrl { get; set; }

        // Navigation: One Author → Many Books
        public ICollection<Book> Books { get; set; }
    }
}
