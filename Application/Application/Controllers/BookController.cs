namespace Application.Controllers
{
    using Application.Models.ViewModels;
    using Application.Services.Interfaces;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class BookController : Controller
    {
        private readonly IBookService bookService;
        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        public IActionResult AllBooks()
        {
            var res = bookService.GetAllBooks();
            return View(res);
        }

        public IActionResult ReadMore(string id)
        {
            if (id != null)
            {
                var res = bookService.GetIndividualBook(id);
                return View(res);
            }
            return View("BookNotFound");
        }

        [Authorize]
        public IActionResult SellBook()
        {

            return View();
        }

        public IActionResult AddBook(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                bookService.AddBook(model);
                return View("Success");
            }
            else
            {
                return View("SellBook");
            }
        }
    }
}
