using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class CarDealership
    {
        public CarDealership()
        {
            Cars = new HashSet<Car>();
            Workers = new HashSet<Worker>();
        }

        public int Id { get; set; }
        public int TownId { get; set; }
        public string Name { get; set; }

        public virtual Town Town { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }
    }
}
