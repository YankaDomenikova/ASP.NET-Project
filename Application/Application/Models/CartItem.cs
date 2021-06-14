namespace Application.Models
{
    public class CartItem : BaseModel
    {
        public int Amount { get; set; }

        public Book Book { get; set; }

        public string CartId { get; set; }

        public Cart Cart { get; set; }
    }
}
