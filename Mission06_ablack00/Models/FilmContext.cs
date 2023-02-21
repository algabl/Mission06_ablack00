using Microsoft.EntityFrameworkCore;

namespace Mission06_ablack00.Models
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options) : base(options)
        {
            
        }
        
        public DbSet<Film> Films { get; set; }
        
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Action"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Adventure"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Animation"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Comedy"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Drama"
                },
                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Horror"
                },
                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Science Fiction"
                },
                new Category
                {
                    CategoryId = 8,
                    CategoryName = "Western"
                },
                new Category
                {
                    CategoryId = 9,
                    CategoryName = "Other"
                }
            );
            mb.Entity<Film>().HasData(
                new Film
                {
                    FilmId = 1,
                    CategoryId = 3,
                    Title = "Inside Out",
                    Year = 2015,
                    Director = "Pete Docter",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Robert Parr",
                    Notes = "Will make you cry"
                },
                new Film
                {
                    FilmId = 2,
                    CategoryId = 5,
                    Title = "Knives Out",
                    Year = 2019,
                    Director = "Rian Johnson",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Benoit Blanc",
                    Notes = "You did this!"
                },
                new Film
                {
                    FilmId = 3,
                    CategoryId = 4,
                    Title = "Zoolander",
                    Year = 2001,
                    Director = "Ben Stiller",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Owen Wilson",
                    Notes = "Wow."
                }
            );
        }
    }
}