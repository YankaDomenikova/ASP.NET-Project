using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models
{
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
