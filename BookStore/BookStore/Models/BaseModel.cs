using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            Id = Guid.NewGuid().ToString().Substring(0, 20);
        }

        public string Id { get; set; }
    }
}
