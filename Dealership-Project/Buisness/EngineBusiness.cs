using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Buisness
{
    public class EngineBusiness
    {
        private CarDealershipContext engineContext;

        public List<Engine> GetAllEngines()
        {
            using (engineContext = new CarDealershipContext())
            {
                return engineContext.Engines.ToList();
            }
        }

        public Engine GetEngineBy(int id)
        {
            using (engineContext = new CarDealershipContext())
            {
                return engineContext.Engines.Find(id);
            }
        }

        public List<Engine> GetEnginesByFuelType(string fuelType)
        {
            using (engineContext = new CarDealershipContext())
            {
                return engineContext.Engines.Where(x => x.FuelType == fuelType).ToList();
            }
        }

        public List<Engine> GetEnginesByDisplacement(int displacement)
        {
            using (engineContext = new CarDealershipContext())
            {
                return engineContext.Engines.Where(x => x.Displacement == displacement).ToList();
            }
        }

        public List<Engine> GetEnginesByPower(int power)
        {
            using (engineContext = new CarDealershipContext())
            {
                return engineContext.Engines.Where(x => x.Power == power).ToList();
            }
        }

        public List<Engine> GetEnginesByDisplacement(decimal economyPerHundredKm)
        {
            using (engineContext = new CarDealershipContext())
            {
                return engineContext.Engines.Where(x => x.EconomyPerHundredKm == economyPerHundredKm).ToList();
            }
        }

        public List<Engine> GetEnginesByName(string name)
        {
            using (engineContext = new CarDealershipContext())
            {
                return engineContext.Engines.Where(x => x.Name == name).ToList();
            }
        }

        public void Add(Engine engine)
        {
            using (engineContext = new CarDealershipContext())
            {
                engineContext.Engines.Add(engine);
                engineContext.SaveChanges();

            }
        }

        public void Update(Engine engine)
        {
            using (engineContext = new CarDealershipContext())
            {
                var item = engineContext.Engines.Find(engine.Id);
                if (item != null)
                {
                    engineContext.Entry(item).CurrentValues.SetValues(engine);
                }
            }
        }

        public void Delete(int id)
        {
            using (engineContext = new CarDealershipContext())
            {
                var engine = engineContext.Engines.Find(id);
                if (engine != null)
                {
                    engineContext.Engines.Remove(engine);
                    engineContext.SaveChanges();
                }
            }
        }
    }
}
