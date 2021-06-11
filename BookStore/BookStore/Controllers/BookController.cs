using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BookStore.Services;
using BookStore.Services.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService bookService;
        public BookController(BookService bookService)
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
    }
}
