using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Application.Models.ViewModels;
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
                //return this.BadRequest();
                ModelState.AddModelError(string.Empty, "Invalid input.");
                return View("SellBook");
            }
        }
    }
}
