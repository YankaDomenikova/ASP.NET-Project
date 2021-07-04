namespace Application.Models.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class BookViewModel
    {
        public string Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(65)]
        [Display(Name = "Author")]
        public string Author { get; set; }

        [Required]
        [MaxLength(1750)]
        public string Description { get; set; }

        [Required]
        [Range(0, 100)]
        public double Price { get; set; }

        //[Required]
        //[Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Language { get; set; }

        [Required]
        [Range(1, 2000)]
        public int Pages { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        [Display(Name = "Publication date")]
        public string PublicationDate { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Publisher { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Country { get; set; }

        [Required]
        [Range(1, 3000)]
        [Display(Name = "Bestsellers rank")]
        public int BestsellerRank { get; set; }

        public string GenreId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(75)]
        [Display(Name = "Genre")]
        public string GenreTitle { get; set; }
    }
}
