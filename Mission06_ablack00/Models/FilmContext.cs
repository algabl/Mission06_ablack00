using Microsoft.EntityFrameworkCore;

namespace Mission06_ablack00.Models
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options) : base(options)
        {
            
        }
        
        public DbSet<Film> Films { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Film>().HasData(
                new Film
                {
                    FilmId = 1,
                    Category = "Animation" ,
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
                    Category = "Murder Mystery",
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
                    Category = "Comedy",
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