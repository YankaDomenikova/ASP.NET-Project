namespace Application.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Genre : BaseModel
    {
        [MinLength(1)]
        [MaxLength(70)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public List<Book> Books { get; set; }
    }
}
