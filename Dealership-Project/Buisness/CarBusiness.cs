using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Business
{
    public class CarBusiness
    {
        private CarDealershipContext carContext;

        public List<Car> GetAllCars()
        {
            using (carContext = new CarDealershipContext())
            {
                return carContext.Cars.ToList();
            }
        }

        public Car GetCar(int id)
        {
            using (carContext = new CarDealershipContext())
            {
                return carContext.Cars.Find(id);
            }
        }

        public void Add(Car car)
        {
            using (carContext = new CarDealershipContext())
            {
                carContext.Cars.Add(car);
                carContext.SaveChanges();
            }              
        }

        public void Update(Car car)
        {
            using (carContext = new CarDealershipContext())
            {
                var item = carContext.Cars.Find(car.Id);
                if (item != null)
                {
                    carContext.Entry(item).CurrentValues.SetValues(car);
                    carContext.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (carContext = new CarDealershipContext())
            {
                var car = carContext.Cars.Find(id);
                if (car != null)
                {
                    carContext.Cars.Remove(car);
                    carContext.SaveChanges();
                }
            }
        }
    }
}
