using Library.Models.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models.Entity
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
        public string CoverImg { get; set; }

        // Foreign Keys
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public int CollectionId { get; set; }

        // Navigation properties
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public Collection Collection { get; set; }
    }
}
