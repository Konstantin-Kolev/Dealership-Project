using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Business
{
    public class CarDealershipBusiness
    {
        private CarDealershipContext carDealershipContext;

        public CarDealershipBusiness(CarDealershipContext carDealershipContext)
        {
            this.carDealershipContext = carDealershipContext;
        }

        public List<CarDealership> GetAllCarDealerships()
        {
            using (carDealershipContext = new CarDealershipContext())
            {
                return carDealershipContext.CarDealerships.ToList();
            }
        }

        public CarDealership GetCarDealershipById(int id)
        {
            using (carDealershipContext = new CarDealershipContext())
            {
                return carDealershipContext.CarDealerships.Find(id);
            }
        }

        public CarDealership GetCarDealershipByName(string name)
        {
            using (carDealershipContext = new CarDealershipContext())
            {
                return carDealershipContext.CarDealerships.Find(name);
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

        public List<CarDealership> GetDealershipsByTown(string townName)
        {
            using (carDealershipContext=new CarDealershipContext())
            {
                return carDealershipContext.CarDealerships.Where(x => x.Town.Name == townName).ToList();
            }
        }

        public List<CarDealership> SortDealershipsByName()
        {
            using (carDealershipContext=new CarDealershipContext())
            {
                return carDealershipContext.CarDealerships.OrderBy(x => x.Name).ToList();
            }
        }

        public List<CarDealership> SortDealershipsByTownName()
        {
            using (carDealershipContext=new CarDealershipContext())
            {
                return carDealershipContext.CarDealerships.OrderBy(x => x.Town.Name).ToList();
            }
        }
    }
}
