using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Town
    {
        public Town()
        {
            CarDealership = new HashSet<CarDealership>();
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CarDealership> CarDealership { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
