using Library.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Library.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Collection> Collections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ---------------------------------------------------------
            // 1️⃣ SEED GENRES, AUTHORS, COLLECTIONS (PRIMA DEI LIBRI)
            // ---------------------------------------------------------
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, GenreName = "Fantasy" },
                new Genre { GenreId = 2, GenreName = "Thriller" }
            );

            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, FullName = "J. K. Rowling", PhotoUrl = null },
                new Author { AuthorId = 2, FullName = "George Orwell", PhotoUrl = null }
            );

            modelBuilder.Entity<Collection>().HasData(
                new Collection { CollectionId = 1, CollectionName = "Harry Potter Series" }
            );

            // ---------------------------------------------------------
            // 2️⃣ BOOKS + RELAZIONI
            // ---------------------------------------------------------
            modelBuilder.Entity<Book>(e =>
            {
                e.HasKey(b => b.BookId);

                e.Property(b => b.BookId).ValueGeneratedOnAdd();

                e.HasOne(b => b.Author)
                 .WithMany(a => a.Books)
                 .HasForeignKey(b => b.AuthorId)
                 .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(b => b.Genre)
                 .WithMany(g => g.Books)
                 .HasForeignKey(b => b.GenreId)
                 .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(b => b.Collection)
                 .WithMany(c => c.Books)
                 .HasForeignKey(b => b.CollectionId)
                 .OnDelete(DeleteBehavior.Restrict);

                // ---------------------------------------------------------
                // BOOK SEED
                // ---------------------------------------------------------
                e.HasData(
                    new Book
                    {
                        BookId = 1,
                        Title = "Harry Potter and the Philosopher's Stone",
                        Description = "The first book in the Harry Potter saga, following the young wizard Harry Potter.",
                        CoverImg = "hp1.jpg",
                        AuthorId = 1,
                        GenreId = 1,
                        CollectionId = 1
                    },
                    new Book
                    {
                        BookId = 2,
                        Title = "Harry Potter and the Chamber of Secrets",
                        Description = "Harry returns to Hogwarts for his second year and faces new dangers.",
                        CoverImg = "hp2.jpg",
                        AuthorId = 1,
                        GenreId = 1,
                        CollectionId = 1
                    },
                    new Book
                    {
                        BookId = 3,
                        Title = "Harry Potter and the Prisoner of Azkaban",
                        Description = "Harry faces Sirius Black and uncovers a deeper mystery.",
                        CoverImg = "hp3.jpg",
                        AuthorId = 1,
                        GenreId = 1,
                        CollectionId = 1
                    },
                    new Book
                    {
                        BookId = 4,
                        Title = "1984",
                        Description = "A dystopian novel about totalitarianism and surveillance.",
                        CoverImg = "1984.jpg",
                        AuthorId = 2,
                        GenreId = 2,
                        CollectionId = 1 // Temporary to satisfy FK; we can create Orwell Collection
                    },
                    new Book
                    {
                        BookId = 5,
                        Title = "Animal Farm",
                        Description = "A political satire allegory with farm animals.",
                        CoverImg = "animalfarm.jpg",
                        AuthorId = 2,
                        GenreId = 2,
                        CollectionId = 1
                    },
                    new Book
                    {
                        BookId = 6,
                        Title = "Harry Potter and the Goblet of Fire",
                        Description = "Harry enters a dangerous magical tournament.",
                        CoverImg = "hp4.jpg",
                        AuthorId = 1,
                        GenreId = 1,
                        CollectionId = 1
                    }
                );
            });
        }
    }
}
