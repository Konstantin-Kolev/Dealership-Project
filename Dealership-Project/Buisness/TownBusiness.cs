using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Business
{
    public class TownBusiness
    {
        private CarDealershipContext townContext;

        public TownBusiness()
        {
            this.townContext = new CarDealershipContext();
        }

        public TownBusiness(CarDealershipContext carDealershipContext)
        {
            this.townContext = carDealershipContext;
        }

        //Basic operations//
        public void Add(Town town)
        {
            using (townContext)
            {
                townContext.Towns.Add(town);
                townContext.SaveChanges();
            }
        }

        public void Update(Town town)
        {
            using (townContext)
            {
                var item = townContext.Towns.Find(town.Id);
                if (item != null)
                {
                    townContext.Entry(item).CurrentValues.SetValues(town);
                    townContext.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (townContext)
            {
                var town = townContext.Towns.Find(id);
                if (town != null)
                {
                    townContext.Towns.Remove(town);
                    townContext.SaveChanges();
                }
            }
        }
        //Basic operations//

        //Get operations//
        public List<Town> GetAllTowns()
        {
            using (townContext)
            {
                return townContext.Towns.ToList();
            }
        }

        public Town GetTownById(int id)
        {
            using (townContext)
            {
                return townContext.Towns.Find(id);
            }
        }

        public List<Town> GetTownsByName(string name)
        {
            using (townContext)
            {
                return townContext.Towns.Where(x => x.Name == name).ToList();
            }
        }
        //Get operations//
        
        //Sort operations//
        public List<Town> SortTownsByNameAscending()
        {
            using (townContext)
            {
                return townContext.Towns.OrderBy(x => x.Name).ToList();
            }
        }

        public List<Town> SortTownsByNameDescending()
        {
            using (townContext)
            {
                return townContext.Towns.OrderByDescending(x => x.Name).ToList();
            }
        }
        //Sort operations//
    }
}
