using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models
{
    public class Cart : BaseModel
    {
        public List<CartItem> CartItems { get; set; }
    }
}
