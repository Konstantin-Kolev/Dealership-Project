using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Business;

namespace Business
{
    public class CarDealershipBusiness
    {
        private CarDealershipContext carDealershipContext;
        /// <summary>
        /// Create a new instance of the class with a new context
        /// </summary>
        public CarDealershipBusiness()
        {
            this.carDealershipContext = new CarDealershipContext();
        }
        /// <summary>
        /// Create a new instance of the class with an existing context
        /// </summary>
        /// <param name="carDealershipContext">An existing context to be used by the instance of the class</param>
        public CarDealershipBusiness(CarDealershipContext carDealershipContext)
        {
            this.carDealershipContext = carDealershipContext;
        }

        //Basic operations//
        /// <summary>
        /// Add a new dealership to the database
        /// </summary>
        /// <param name="carDealership">The dealership thta needs to be added to the database</param>
        public void Add(CarDealership carDealership)
        {
            using (carDealershipContext)
            {
                carDealershipContext.CarDealerships.Add(carDealership);
                carDealershipContext.SaveChanges();
            }
        }
        /// <summary>
        /// Change the information about one of the dealerships
        /// </summary>
        /// <param name="carDealership">A dealership with the new information and the same id as the old one</param>
        public void Update(CarDealership carDealership)
        {
            using (carDealershipContext)
            {
                var item = carDealershipContext.CarDealerships.Find(carDealership.Id);
                if (item != null)
                {
                    carDealershipContext.Entry(item).CurrentValues.SetValues(carDealership);
                    carDealershipContext.SaveChanges();
                }
            }

        }
        /// <summary>
        /// Remove a dealership from the database
        /// </summary>
        /// <param name="id">The id of the dealerships that needs to be removed</param>
        public void Delete(int id)
        {
            using (carDealershipContext)
            {
                var carDealership = carDealershipContext.CarDealerships.Find(id);
                if (carDealership != null)
                {
                    carDealershipContext.CarDealerships.Remove(carDealership);
                    carDealershipContext.SaveChanges();
                }
            }
        }
        //Basic operations//

        //Get operations//
        /// <summary>
        /// Find all dealerships in the database
        /// </summary>
        /// <returns>Returns a list of all dealerships in the database</returns>
        public List<CarDealership> GetAllCarDealerships()
        {
            using (carDealershipContext)
            {
                return carDealershipContext.CarDealerships.ToList();
            }
        }
        /// <summary>
        /// Find a dealership by a given id
        /// </summary>
        /// <param name="id">The id of the dealership you are searching for</param>
        /// <returns>Returns the dealership that matches the given id</returns>
        public CarDealership GetCarDealershipById(int id)
        {
            using (carDealershipContext)
            {
                return carDealershipContext.CarDealerships.Find(id);
            }
        }
        /// <summary>
        /// Find a dealership by a given name
        /// </summary>
        /// <param name="name">The name of the dealership you are searching for</param>
        /// <returns>Returns the dealrship that matches the given name</returns>
        public CarDealership GetCarDealershipByName(string name)
        {
            using (carDealershipContext)
            {
                var list = carDealershipContext.CarDealerships.Where(x => x.Name == name).ToList();
                return list[0];
            }
        }
        /// <summary>
        /// Find all dealerships in a given town
        /// </summary>
        /// <param name="townName">The town you are searching for</param>
        /// <returns>Returns a list of all dealerships in the given town</returns>
        public List<CarDealership> GetDealershipsByTown(string townName)
        {
            using (carDealershipContext)
            {
                return carDealershipContext.CarDealerships.Where(x => x.Town.Name == townName).ToList();
            }
        }
        /// <summary>
        /// Find the name of a town by a dealership's TownId
        /// </summary>
        /// <param name="townId">The id of a dealership's town you want the name of</param>
        /// <returns>The name of the town as a string</returns>
        public string GetTownName(int townId)
        {
            TownBusiness townBusiness = new TownBusiness();
            var town = townBusiness.GetTownById(townId);
            return town.Name;
        }
        //Get operations//

        //Sort operations//
        public List<CarDealership> SortDealershipsByNameAscending()
        {
            using (carDealershipContext)
            {
                return carDealershipContext.CarDealerships.OrderBy(x => x.Name).ToList();
            }
        }

        public List<CarDealership> SortDealershipsByNameDescending()
        {
            using (carDealershipContext)
            {
                return carDealershipContext.CarDealerships.OrderByDescending(x => x.Name).ToList();
            }
        }

        public List<CarDealership> SortDealershipsByTownNameAscending()
        {
            using (carDealershipContext)
            {
                return carDealershipContext.CarDealerships.OrderBy(x => x.Town.Name).ToList();
            }
        }

        public List<CarDealership> SortDealershipsByTownNameDescending()
        {
            using (carDealershipContext)
            {
                return carDealershipContext.CarDealerships.OrderByDescending(x => x.Town.Name).ToList();
            }
        }
        //Sort operations//
    }
}
