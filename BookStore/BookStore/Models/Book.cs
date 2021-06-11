using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book : BaseModel
    {
        [MinLength(1)]
        [MaxLength(70)]
        public string Title { get; set; }

        [MinLength(2)]
        [MaxLength(65)]
        public string Author { get; set; }

        [MaxLength(1100)]
        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public int Quantity { get; set; }

        public string Language { get; set; }

        public int Pages { get; set; }

        public string PublicationDate { get; set; }

        [MaxLength(75)]
        public string Publisher { get; set; }

        [MaxLength(65)]
        public string Country { get; set; }

        public int BestsellerRank { get; set; }

        public string GenreId { get; set; }

        public string GenreTitle { get; set; }

        public Genre Genre { get; set; }
    }
}
