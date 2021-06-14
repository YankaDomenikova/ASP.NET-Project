namespace Application.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Order : BaseModel
    {

        [MaxLength(75)]
        public string Address { get; set; }

        [MaxLength(55)]
        public string State { get; set; }

        [MaxLength(55)]
        public string Country { get; set; }

        public double OrderTotal { get; set; }

        public User User { get; set; }
    }
}
