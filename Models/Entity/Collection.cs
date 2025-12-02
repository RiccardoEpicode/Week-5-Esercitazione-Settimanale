using System.ComponentModel.DataAnnotations;

namespace Library.Models.Entity
{
    public class Collection
    {
        [Key]
        public int CollectionId { get; set; }

        [Required]
        public string CollectionName { get; set; }

        // Navigation
        public ICollection<Book> Books { get; set; }
    }
}
