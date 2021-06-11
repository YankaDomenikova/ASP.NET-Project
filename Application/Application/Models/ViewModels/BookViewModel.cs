using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class BookViewModel
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }


        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public int Quantity { get; set; }

        public string Language { get; set; }

        public int Pages { get; set; }

        public string PublicationDate { get; set; }

        public string Publisher { get; set; }

        public string Country { get; set; }

        public int BestsellerRank { get; set; }

        public string GenreId { get; set; }

        public string GenreTitle { get; set; }
    }
}
