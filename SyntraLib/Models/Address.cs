using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra.Models
{
    public class Address : BaseEntity
    {
        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public string Appartment { get; set; }

        public string Zipcode { get; set; }

        public string City { get; set; }

        public Country Country { get; set; }




    }
}
