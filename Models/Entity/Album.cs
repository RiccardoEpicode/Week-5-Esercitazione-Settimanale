using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models.Entity
{
    public class Album
    {
       [Key]
       public int AlbumId { get; set; }
       public string AlbumName { get; set; }
       public DateOnly AlbumYear { get; set; }
       public string AlbumArtist { get; set; }
       public int SongId { get; set; }
       public int GenreId { get; set; }  

    }
}
