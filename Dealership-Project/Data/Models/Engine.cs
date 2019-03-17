using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Engine
    {
        public Engine()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string FuelType { get; set; }
        public int Displacement { get; set; }
        public int Power { get; set; }
        public decimal EconomyPerHundredKm { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
