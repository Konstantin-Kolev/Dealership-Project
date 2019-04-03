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
        /// <summary>
        /// Creates a new instance of the class with an entirely new context
        /// </summary>
        public CarBusiness()
        {
            this.carContext = new CarDealershipContext();
        }
        /// <summary>
        /// Creates a new instance of the class with an existing context
        /// </summary>
        /// <param name="carDealershipContext">An existing context to be used by the instance of the class</param>
        public CarBusiness(CarDealershipContext carDealershipContext)
        {
            this.carContext = carDealershipContext;
        }

        //Basic operations//
        /// <summary>
        /// Function that adds a new car to the database
        /// </summary>
        /// <param name="car">The car that needs to be added to the database</param>
        public void Add(Car car)
        {
            using (carContext)
            {
                carContext.Cars.Add(car);
                carContext.SaveChanges();
            }
        }
        /// <summary>
        /// Changes the information about one of the cars
        /// </summary>
        /// <param name="car">A car with the new information and the same id as the old one</param>
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
        /// <summary>
        /// Removes a car from the database
        /// </summary>
        /// <param name="id">The id of the car that needs to be removed</param>
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
        /// <summary>
        /// Get all cars in the database
        /// </summary>
        /// <returns>Returns a list of all cars in the database</returns>
        public List<Car> GetAllCars()
        {
            using (carContext)
            {
                return carContext.Cars.ToList();
            }
        }
        /// <summary>
        /// Find a car by a given id
        /// </summary>
        /// <param name="id">The id of the car you are looking for</param>
        /// <returns>Returns the car that matches the given id</returns>
        public Car GetCarById(int id)
        {
            using (carContext)
            {
                return carContext.Cars.Find(id);
            }
        }
        /// <summary>
        /// Find all cars from a given manufacturer
        /// </summary>
        /// <param name="manufacturer">The name of the manufaturer you are searching for</param>
        /// <returns>Return a list of all the cars from the given manufacturer</returns>
        public List<Car> GetCarsByManufacturer(string manufacturer)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.Manufacturer == manufacturer).ToList();
            }
        }
        /// <summary>
        /// Find all cars of a given model
        /// </summary>
        /// <param name="model">The name of the model you are searching for</param>
        /// <returns>Returns a list of all the cars of the given model</returns>
        public List<Car> GetCarsByModel(string model)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.Model == model).ToList();
            }
        }
        /// <summary>
        /// Find all cars from a given dealership
        /// </summary>
        /// <param name="dealershipId">The id of the dealership you are searching for</param>
        /// <returns>Returns a list of all cars sold by the given dealership</returns>
        public List<Car> GetCarsByCarDealership(int dealershipId)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.CarDealershipId == dealershipId).ToList();
            }
        }
        /// <summary>
        /// Find all cars with a given color
        /// </summary>
        /// <param name="color">The color you want ot search for</param>
        /// <returns>Returns a list of all cars with the given color</returns>
        public List<Car> GetCarsByColor(string color)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.Color == color).ToList();
            }
        }
        /// <summary>
        /// Find all cars with a given transmition type
        /// </summary>
        /// <param name="transmissionType">The transmition type you are searching for</param>
        /// <returns>Returs a list of a ll cars with the given tranmition type</returns>
        public List<Car> GetCarsByTransmissionType(string transmissionType)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.TransmissionType == transmissionType).ToList();
            }
        }
        /// <summary>
        /// Find all cars with a given price
        /// </summary>
        /// <param name="price">The price of car you are searching for</param>
        /// <returns>Returns a list of all cars with the given price</returns>
        public List<Car> GetCarsByPrice(decimal price)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.Price == price).ToList();
            }
        }
        /// <summary>
        /// Find all cars with a given number of transmition gears
        /// </summary>
        /// <param name="transmissionGears">The number of transmition gears you are searching for</param>
        /// <returns>Returns a list of all cars with the given number of transmition gears</returns>
        public List<Car> GetCarsTransmissionGears(int transmissionGears)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.TransmissionGears == transmissionGears).ToList();
            }
        }
        /// <summary>
        /// Find all cars with a given amount of horse power
        /// </summary>
        /// <param name="power">The amount of horse power you are serching for</param>
        /// <returns>Returns a list of all cars with the given amount of horse power</returns>
        public List<Car> GetCarsByPower(int power)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.Engine.Power == power).ToList();
            }
        }
        /// <summary>
        /// Find all cars with a given engine displacement
        /// </summary>
        /// <param name="displacement">The engine displacemnt you are searching for</param>
        /// <returns>Returns a list of all cars with the given engine displacement</returns>
        public List<Car> GetCarsByDisplacement(int displacement)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.Engine.Displacement == displacement).ToList();
            }
        }
        /// <summary>
        /// Find all cars that are owned
        /// </summary>
        /// <returns>Returns a list of all cars that have an owner</returns>
        public List<Car> GetOwnedCars()
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.OwnerId != null).ToList();
            }
        }
        /// <summary>
        /// Find all cars with a given fuel tyoe
        /// </summary>
        /// <param name="fuelType">The fuel type you are searching for</param>
        /// <returns>Returns a list of all cars with the given fuel type</returns>
        public List<Car> GetCarsByFuelType(string fuelType)
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.Engine.FuelType == fuelType).ToList();
            }
        }
        /// <summary>
        /// Find all cars for sale
        /// </summary>
        /// <returns>Returns a list of all cars currently for sale</returns>
        public List<Car> GetCarsForSale()
        {
            using (carContext)
            {
                return carContext.Cars.Where(x => x.OwnerId == null).ToList();
            }
        }
        /// <summary>
        /// Find the name of a dealership from its id
        /// </summary>
        /// <param name="dealershipId">The id of the dealership you want the name of</param>
        /// <returns>Returns the name of the dealership as a string</returns>
        public string GetDealershipName(int dealershipId)
        {
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            var dealership = carDealershipBusiness.GetCarDealershipById(dealershipId);
            return dealership.Name;
        }
        /// <summary>
        /// Find the name of an engine from its id
        /// </summary>
        /// <param name="engineId">The id of the engine you want the name of</param>
        /// <returns>Returns the name of the engine as a string</returns>
        public string GetEngineName(int engineId)
        {
            EngineBusiness engineBusiness = new EngineBusiness();
            var engine = engineBusiness.GetEngineById(engineId);
            return engine.Name;
        }
        /// <summary>
        /// Find the name of an owner by his id
        /// </summary>
        /// <param name="ownerId">The id of the owner you are looking for</param>
        /// <returns></returns>
        public string GetOwnerName(int? ownerId)
        {
            CustomerBusiness customerBusiness = new CustomerBusiness();
            var customer = customerBusiness.GetCustomerById(ownerId);
            if (customer == null)
            {
                return "For Sale";
            }
            else
            {
                return customer.FirstName + ' ' + customer.LastName;
            }
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
