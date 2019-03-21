using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Buisness
{
    class CarDealershipBusiness
    {
        private CarDealershipContext carDealershipContext;

        public List<CarDealership> GetAllCarDealerships()
        {
            using (carDealershipContext = new CarDealershipContext())
            {
                return carDealershipContext.CarDealerships.ToList();
            }
        }

        public CarDealership GetCarDealership(int id)
        {
            using (carDealershipContext = new CarDealershipContext())
            {
                return carDealershipContext.CarDealerships.Find(id);
            }
        }

        public void Add(CarDealership carDealership)
        {
            using (carDealershipContext = new CarDealershipContext())
            {
                carDealershipContext.CarDealerships.Add(carDealership);
                carDealershipContext.SaveChanges();
            }
        }

        public void Update (CarDealership carDealership)
        {
            var item = carDealershipContext.CarDealerships.Find(carDealership.Id);
            if (item != null)
            {
                carDealershipContext.Entry(item).CurrentValues.SetValues(carDealership);
                carDealershipContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (carDealershipContext = new CarDealershipContext())
            {
                var carDealership = carDealershipContext.CarDealerships.Find(id);
                if (carDealership != null)
                {
                    carDealershipContext.CarDealerships.Remove(carDealership);
                    carDealershipContext.SaveChanges();
                }
            }
        }
    }
}
