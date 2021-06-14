namespace Application.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using Application.Data;
    using Application.Models.ViewModels;
    using Application.Services.Interfaces;

    using Microsoft.EntityFrameworkCore;

    public class GenreService : IGenreService
    {
        private readonly ApplicationDbContext dbContext;

        public GenreService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<GenreViewModel> GetAllGenres()
        {
            var res = dbContext.Genres.Select(x => new GenreViewModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description
            }).ToList();

            return res;
        }

        public List<BookViewModel> GetBooksByGenre(string title)
        {
            var res = dbContext.Books.Where(x => x.GenreTitle == title).Include(x=>x.Genre).Select(x => new BookViewModel()
            {
                Id = x.Id,
                Title = x.Title.ToUpper(),
                Author = x.Author,
                Price = x.Price,
                ImageUrl = x.ImageUrl,
                Quantity = x.Quantity,
               
            }).ToList();

            return res;
        }
    }
}
