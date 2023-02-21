using System.ComponentModel.DataAnnotations;

namespace Mission06_ablack00.Models
{
    public class Film
    {
        [Key]
        [Required(ErrorMessage = "Why.")]
        public int FilmId { get; set; }
        
        [Required(ErrorMessage = "You must give the movie a title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You must give the movie a year.")]
        public int Year { get; set; }
        [Required(ErrorMessage = "You must give the movie a director.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "You must give the movie a rating.")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [StringLength(25)]
        public string Notes { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}