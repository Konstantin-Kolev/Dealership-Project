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

        public Car GetCarById(int id)
        {
            using (carContext = new CarDealershipContext())
            {
                return carContext.Cars.Find(id);
            }
        }

        public List<Car> GetCarsByManufacturer(string manufacturer)
        {
            using (carContext = new CarDealershipContext())
            {
                return carContext.Cars.Where(x => x.Manufacturer == manufacturer).ToList();
            }
        }

        public List<Car> GetCarsByModel(string model)
        {
            using (carContext = new CarDealershipContext())
            {
                return carContext.Cars.Where(x => x.Model == model).ToList();
            }
        }

        public List<Car> GetCarsByCarDealership(int dealershipId)
        {
            using (carContext = new CarDealershipContext())
            {
                return carContext.Cars.Where(x => x.CarDealershipId == dealershipId).ToList(); 
            }
        }

        public List<Car> GetCarsByColor(string color)
        {
            using (carContext = new CarDealershipContext())
            {
                return carContext.Cars.Where(x => x.Color == color).ToList();
            }
        }

        public List<Car> GetCarsByTransmissionType(string transmissionType)
        {
            using (carContext = new CarDealershipContext())
            {
                return carContext.Cars.Where(x => x.TransmissionType == transmissionType).ToList();
            }
        }

        public List<Car> GetCarsByPrice(decimal price)
        {
            using (carContext = new CarDealershipContext())
            {
                return carContext.Cars.Where(x => x.Price == price).ToList();
            }
        }

        public List<Car> GetCarsTransmissionGears(int transmissionGears)
        {
            using (carContext = new CarDealershipContext())
            {
                return carContext.Cars.Where(x => x.TransmissionGears == transmissionGears).ToList();
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

        public List<Car> SortCarsByPower()
        {
            using (carContext=new CarDealershipContext())
            {
                return carContext.Cars.OrderByDescending(x => x.Engine.Power).ToList();
            }
        }
    }
}
