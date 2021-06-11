using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BookStore.Services;
using BookStore.Services.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class GenreController : Controller
    {
        private readonly GenreService genreService;
        public GenreController(GenreService genreService)
        {
            this.genreService = genreService;
        }


        public IActionResult SearchByGenres()
        {
            var res = genreService.GetAllGenres();
            return View(res);
        }

        public IActionResult GetBookByGenre(string title)
        {
            var res = genreService.GetBooksByGenre(title);
            return View(res);
        }
    }
}
