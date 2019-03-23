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
        
        public List<Town> GetAll()
        {
            using (townContext = new CarDealershipContext())
            {
                return townContext.Towns.ToList();
            }
        }

        public Town Get(int id)
        {
            using (townContext = new CarDealershipContext())
            {
                return townContext.Towns.Find(id);
            }
        }

        public List<Town> GetTownsByName(string name)
        {
            using (townContext = new CarDealershipContext())
            {
                return townContext.Towns.Where(x => x.Name == name).ToList();
            }
        }

        public void Add(Town town)
        {
            using (townContext = new CarDealershipContext())
            {
                townContext.Towns.Add(town);
                townContext.SaveChanges();
            }
        }

        public void Update(Town town)
        {
            using (townContext = new CarDealershipContext())
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
            using (townContext = new CarDealershipContext())
            {
                var town = townContext.Towns.Find(id);
                if (town != null)
                {
                    townContext.Towns.Remove(town);
                    townContext.SaveChanges();
                }
            }
        }
    }
}
