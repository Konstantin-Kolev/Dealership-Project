using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class CarBusiness
    {
        private CarDealershipContext carContext;

        public CarBusiness()
        {
            this.carContext = new CarDealershipContext();
        }

        public CarBusiness(CarDealershipContext carDealershipContext)
        {
            this.carContext = carDealershipContext;
        }

        //Basic operations//
        public void Add(Car car)
        {
            using (carContext)
            {
                carContext.Cars.Add(car);
                carContext.SaveChanges();
            }
        }

        public void Update(Car car)
        {
            using (carContext)
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
            using (carContext)
            {
                var car = carContext.Cars.Find(id);
                if (car != null)
                {
                    carContext.Cars.Remove(car);
                    carContext.SaveChanges();
                }
            }
        }
        //Basic operations//

        //Get operations//
        public List<Car> GetAllCars()
        {
            using (carContext)
            {
                return carContext.Cars.ToList();
            }
        }

        public Car GetCarById(int id)
        {
            using (carContext)
            {
                return carContext.Cars.Find(id);
            }
        }

        public List<Car> GetCarsByManufacturer(string manufacturer)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.Manufacturer == manufacturer).ToList();
            }
        }

        public List<Car> GetCarsByModel(string model)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.Model == model).ToList();
            }
        }

        public List<Car> GetCarsByCarDealership(int dealershipId)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.CarDealershipId == dealershipId).ToList();
            }
        }

        public List<Car> GetCarsByColor(string color)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.Color == color).ToList();
            }
        }

        public List<Car> GetCarsByTransmissionType(string transmissionType)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.TransmissionType == transmissionType).ToList();
            }
        }

        public List<Car> GetCarsByPrice(decimal price)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.Price == price).ToList();
            }
        }

        public List<Car> GetCarsTransmissionGears(int transmissionGears)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.TransmissionGears == transmissionGears).ToList();
            }
        }

        public List<Car> GetCarsByPower(int power)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.Engine.Power == power).ToList();
            }
        }

        public List<Car> GetCarsByDisplacement(int displacement)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.Engine.Displacement == displacement).ToList();
            }
        }

        public List<Car> GetOwnedCars()
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.OwnerId != null).ToList();
            }
        }

        public List<Car> GetCarsByFuelType(string fuelType)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.Engine.FuelType == fuelType).ToList();
            }
        }

        public List<Car> GetCarsForSale()
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.OwnerId == null).ToList();
            }
        }

        public string GetDealershipName(int dealershipId)
        {
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            var dealership = carDealershipBusiness.GetCarDealershipById(dealershipId);
            return dealership.Name;
        }
        //Get operations//

        //Sort operations//
        public List<Car> SortCarsByPowerAscending()
        {
            using (carContext)
            {
                return carContext.Cars.OrderBy(x => x.Engine.Power).ToList();
            }
        }

        public List<Car> SortCarsByPowerDescending()
        {
            using (carContext)
            {
                return carContext.Cars.OrderByDescending(x => x.Engine.Power).ToList();
            }
        }

        public List<Car> SortCarsByFuelEconomyAscending()
        {
            using (carContext)
            {
                return carContext.Cars.OrderBy(x => x.Engine.EconomyPerHundredKm).ToList();
            }
        }

        public List<Car> SortCarsByFuelEconomyDescending()
        {
            using (carContext)
            {
                return carContext.Cars.OrderByDescending(x => x.Engine.EconomyPerHundredKm).ToList();
            }
        }

        public List<Car> SortCarsByFuelType()
        {
            using (carContext)
            {
                return carContext.Cars.OrderBy(x => x.Engine.FuelType).ToList();
            }
        }

        public List<Car> SortCarsByDisplacementAscending()
        {
            using (carContext)
            {
                return carContext.Cars.OrderBy(x => x.Engine.Displacement).ToList();
            }
        }

        public List<Car> SortCarsByDisplacementDescending()
        {
            using (carContext)
            {
                return carContext.Cars.OrderByDescending(x => x.Engine.Displacement).ToList();
            }
        }

        public List<Car> SortCarsByTransmissionType()
        {
            using (carContext)
            {
                return carContext.Cars.OrderBy(x => x.TransmissionType).ToList();
            }
        }

        public List<Car> SortCarsByTransmissionGearsAscending()
        {
            using (carContext)
            {
                return carContext.Cars.OrderBy(x => x.TransmissionGears).ToList();
            }
        }

        public List<Car> SortCarsByTransmissionGearsDescending()
        {
            using (carContext)
            {
                return carContext.Cars.OrderByDescending(x => x.TransmissionGears).ToList();
            }
        }

        public List<Car> SortCarsByColor()
        {
            using (carContext)
            {
                return carContext.Cars.OrderBy(x => x.Color).ToList();
            }
        }

        public List<Car> SortCarsByPriceAscending()
        {
            using (carContext)
            {
                return carContext.Cars.OrderBy(x => x.Price).ToList();
            }
        }

        public List<Car> SortCarsByPriceDescending()
        {
            using (carContext)
            {
                return carContext.Cars.OrderByDescending(x => x.Price).ToList();
            }
        }

        public List<Car> SortCarsByManufacturerAndModelAscending()
        {
            using (carContext)
            {
                return carContext.Cars.OrderBy(x => x.Manufacturer).ThenBy(x => x.Model).ToList();
            }
        }

        public List<Car> SortCarsByManufacturerAndModelDescending()
        {
            using (carContext)
            {
                return carContext.Cars.OrderByDescending(x => x.Manufacturer).ThenBy(x => x.Model).ToList();
            }
        }

        public List<Car> SortCarsByDealershipNameAscending()
        {
            using (carContext)
            {
                return carContext.Cars.OrderBy(x => x.CarDealership.Name).ToList();
            }
        }

        public List<Car> SortCarsByDealershipNameDescending()
        {
            using (carContext)
            {
                return carContext.Cars.OrderByDescending(x => x.CarDealership.Name).ToList();
            }
        }
        //Sort operations//
    }
}
