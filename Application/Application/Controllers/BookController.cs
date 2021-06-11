using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Application.Services.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
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
    }
}
