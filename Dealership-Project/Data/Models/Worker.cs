using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Worker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public int CarDealershipId { get; set; }

        public virtual CarDealership CarDealership { get; set; }
    }
}
