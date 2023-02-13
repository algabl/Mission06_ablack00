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
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Robert Parr",
                    Notes = "Literally the best movie ever"
                },
                new Film
                {
                    FilmId = 2,
                    Category = "Murder Mystery",
                    Title = "Knives Out",
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
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Owen Wilson",
                    Notes = "Wow."
                }
            );
        }
    }
}