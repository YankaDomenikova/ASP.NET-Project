namespace Application.Services.Interfaces
{
    using System.Collections.Generic;

    using Application.Models.ViewModels;

    public interface IGenreService
    {
        List<GenreViewModel> GetAllGenres();

        List<BookViewModel> GetBooksByGenre(string title);
    }
}
