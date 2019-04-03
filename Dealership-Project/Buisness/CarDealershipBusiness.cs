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

        public CarDealershipBusiness()
        {
            this.carDealershipContext = new CarDealershipContext();
        }

        public CarDealershipBusiness(CarDealershipContext carDealershipContext)
        {
            this.carDealershipContext = carDealershipContext;
        }

        //Basic operations//
        public void Add(CarDealership carDealership)
        {
            using (carDealershipContext)
            {
                carDealershipContext.CarDealerships.Add(carDealership);
                carDealershipContext.SaveChanges();
            }
        }

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
        public List<CarDealership> GetAllCarDealerships()
        {
            using (carDealershipContext)
            {
                return carDealershipContext.CarDealerships.ToList();
            }
        }

        public CarDealership GetCarDealershipById(int id)
        {
            using (carDealershipContext)
            {
                return carDealershipContext.CarDealerships.Find(id);
            }
        }

        public CarDealership GetCarDealershipByName(string name)
        {
            using (carDealershipContext)
            {
                return carDealershipContext.CarDealerships.Find(name);
            }
        }

        public List<CarDealership> GetDealershipsByTown(string townName)
        {
            using (carDealershipContext)
            {
                return carDealershipContext.CarDealerships.Where(x => x.Town.Name == townName).ToList();
            }
        }

        public string GetTownName(int townId)
        {
            TownBusiness townBusiness = new TownBusiness();
            var town = townBusiness.GetTownById(townId);
            return town.Name;
        }

        public string GetTownId(int townId)
        {
            TownBusiness townBusiness = new TownBusiness();
            var town = townBusiness.GetTownById(townId);
            return town.Id.ToString();
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
