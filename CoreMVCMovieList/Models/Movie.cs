using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMVCMovieList.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength =3)]
        [Display(Name = "電影名稱")]
        public string Title { get; set; }

        [Display(Name = "放映日期")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Display(Name = "類型")]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Display(Name = "價格")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}

