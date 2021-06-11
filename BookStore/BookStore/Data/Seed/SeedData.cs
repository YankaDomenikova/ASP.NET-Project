using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BookStore.Models;

using Microsoft.EntityFrameworkCore;

namespace BookStore.Data.Seed
{
    public class SeedData
    {
        public ModelBuilder GenerateModels(ModelBuilder modelBuilder)
        {
            List<Genre> genres = new List<Genre>()
            {
                //new Genre { Title=" ", Description="All * Books"},
                new Genre { Title="Fiction ", Description="All Fiction Books"},
                new Genre { Title="Fantasy ", Description="All Fantasy Books"},
                new Genre { Title="Romance  ", Description="All Romance Books"},
                new Genre { Title="Horror  ", Description="All Horror  Books"}
            };

            List<Book> books = new List<Book>()
            {
                //new Book {
                //    Title="",
                //    Author="",
                //    Description="",
                //    Price=, 
                //    Quantity=, 
                //    ImageUrl="https://localhost:5001/images/", 
                //    Language="", 
                //    Pages=, 
                //    PublicationDate="", 
                //    Publisher="", 
                //    Country="", 
                //    BestsellerRank=,
                //    GenreTitle = ""
                //    },
                
            };

            modelBuilder.Entity<Genre>().HasData(genres);
            modelBuilder.Entity<Book>().HasData(books);

            return modelBuilder;
        }
    }
}
