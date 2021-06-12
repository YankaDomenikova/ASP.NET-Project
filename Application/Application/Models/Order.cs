using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models
{
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
