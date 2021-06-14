namespace Application.Controllers
{
    using Application.Services.Interfaces;

    using Microsoft.AspNetCore.Mvc;

    public class GenreController : Controller
    {
        private readonly IGenreService genreService;
        public GenreController(IGenreService genreService)
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
