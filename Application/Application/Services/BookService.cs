namespace Application.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using Application.Data;
    using Application.Models;
    using Application.Models.ViewModels;
    using Application.Services.Interfaces;

    public class BookService : IBookService
    {
        private readonly ApplicationDbContext dbContext;
        public BookService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<BookViewModel> GetAllBooks()
        {
            var res = dbContext.Books.Select(x => new BookViewModel()
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

        public BookViewModel GetIndividualBook(string id)
        {
            var res = dbContext.Books.Where(x => x.Id == id).Select(x => new BookViewModel()
            {
                Id = x.Id,
                Title = x.Title.ToUpper(),
                Author = x.Author,
                Description = x.Description,
                Price = x.Price,
                ImageUrl = x.ImageUrl,
                Quantity = x.Quantity,
                Language = x.Language,
                Pages = x.Pages,
                PublicationDate = x.PublicationDate,
                Publisher = x.Publisher,
                Country = x.Country,
                BestsellerRank = x.BestsellerRank
            }).FirstOrDefault();

            return res;
        }

        public void AddBook(BookViewModel model)
        {
            Book book = new Book()
            {
                Title = model.Title,
                Author = model.Author,
                Description = model.Description,
                Price = model.Price,
                Quantity = 0,
                Language = model.Language,
                Pages = model.Pages,
                PublicationDate = model.PublicationDate,
                Publisher = model.Publisher,
                Country = model.Country,
                BestsellerRank = model.BestsellerRank,
                GenreTitle = model.GenreTitle
            };

            dbContext.Add(book);
            dbContext.SaveChanges();
        }
    }
}
