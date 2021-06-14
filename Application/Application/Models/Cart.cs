namespace Application.Models
{
    using System.Collections.Generic;

    public class Cart : BaseModel
    {
        public List<CartItem> CartItems { get; set; }
    }
}
