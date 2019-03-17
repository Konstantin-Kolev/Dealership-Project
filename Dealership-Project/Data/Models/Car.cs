using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Car
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int CarDealershipId { get; set; }
        public int EngineId { get; set; }
        public string TransmissionType { get; set; }
        public int TransmissionGears { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int? OwnerId { get; set; }

        public virtual CarDealership CarDealership { get; set; }
        public virtual Engine Engine { get; set; }
        public virtual Customer Owner { get; set; }
    }
}
