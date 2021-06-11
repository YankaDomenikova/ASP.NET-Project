using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Application.Models.ViewModels;

namespace Application.Services.Interfaces
{
    public interface IGenreService
    {
        List<GenreViewModel> GetAllGenres();

        List<BookViewModel> GetBooksByGenre(string title);
    }
}
