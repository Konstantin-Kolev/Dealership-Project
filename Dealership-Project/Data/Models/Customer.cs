using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TownId { get; set; }

        public virtual Town Town { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
