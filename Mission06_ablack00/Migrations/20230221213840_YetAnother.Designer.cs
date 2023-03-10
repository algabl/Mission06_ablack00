// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_ablack00.Models;

namespace Mission06_ablack00.Migrations
{
    [DbContext(typeof(FilmContext))]
    [Migration("20230221213840_YetAnother")]
    partial class YetAnother
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_ablack00.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("FilmId");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            FilmId = 1,
                            Category = "Animation",
                            Director = "Pete Docter",
                            Edited = false,
                            LentTo = "Robert Parr",
                            Notes = "Literally the best movie ever",
                            Rating = "PG",
                            Title = "Inside Out",
                            Year = 2015
                        },
                        new
                        {
                            FilmId = 2,
                            Category = "Murder Mystery",
                            Director = "Rian Johnson",
                            Edited = false,
                            LentTo = "Benoit Blanc",
                            Notes = "You did this!",
                            Rating = "PG-13",
                            Title = "Knives Out",
                            Year = 2019
                        },
                        new
                        {
                            FilmId = 3,
                            Category = "Comedy",
                            Director = "Ben Stiller",
                            Edited = false,
                            LentTo = "Owen Wilson",
                            Notes = "Wow.",
                            Rating = "PG-13",
                            Title = "Zoolander",
                            Year = 2001
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
