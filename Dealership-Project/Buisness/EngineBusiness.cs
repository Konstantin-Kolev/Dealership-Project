using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Business
{
    public class EngineBusiness
    {
        private CarDealershipContext engineContext;

        public EngineBusiness()
        {
            this.engineContext = new CarDealershipContext();
        }

        public EngineBusiness(CarDealershipContext carDealershipContext)
        {
            this.engineContext = carDealershipContext;
        }

        //Basic operations//
        public void Add(Engine engine)
        {
            using (engineContext)
            {
                engineContext.Engines.Add(engine);
                engineContext.SaveChanges();

            }
        }

        public void Update(Engine engine)
        {
            using (engineContext)
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
            using (engineContext)
            {
                var engine = engineContext.Engines.Find(id);
                if (engine != null)
                {
                    engineContext.Engines.Remove(engine);
                    engineContext.SaveChanges();
                }
            }
        }
        //Basic operations//

        //Get operations//
        public List<Engine> GetAllEngines()
        {
            using (engineContext)
            {
                return engineContext.Engines.ToList();
            }
        }

        public Engine GetEngineBy(int id)
        {
            using (engineContext)
            {
                return engineContext.Engines.Find(id);
            }
        }

        public List<Engine> GetEnginesByFuelType(string fuelType)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.FuelType == fuelType).ToList();
            }
        }

        public List<Engine> GetEnginesByDisplacement(int displacement)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.Displacement == displacement).ToList();
            }
        }

        public List<Engine> GetEnginesByPower(int power)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.Power == power).ToList();
            }
        }

        public List<Engine> GetEnginesByEconomyPerHundredKm(decimal economyPerHundredKm)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.EconomyPerHundredKm == economyPerHundredKm).ToList();
            }
        }

        public List<Engine> GetEnginesByName(string name)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.Name == name).ToList();
            }
        }
        //Get operations//

        //Sort operations//
        public List<Engine> SortEnginesByFuelType()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderBy(x => x.FuelType).ToList();
            }
        }

        public List<Engine> SortEnginesByDisplacementAscending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderBy(x => x.Displacement).ToList();
            }
        }

        public List<Engine> SortEnginesByDisplacementDescending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderByDescending(x => x.Displacement).ToList();
            }
        }

        public List<Engine> SortEnginesByPowerAscending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderBy(x => x.Power).ToList();
            }
        }

        public List<Engine> SortEnginesByPowerDescending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderByDescending(x => x.Power).ToList();
            }
        }

        public List<Engine> SortEnginesByEconomyPerHundredKmAscending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderBy(x => x.EconomyPerHundredKm).ToList();
            }
        }

        public List<Engine> SortEnginesByEconomyPerHundredKmDescending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderByDescending(x => x.EconomyPerHundredKm).ToList();
            }
        }

        public List<Engine> SortEnginesByNameAscending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderBy(x => x.Name).ToList();
            }
        }

        public List<Engine> SortEnginesByNameDescending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderByDescending(x => x.Name).ToList();
            }
        }
        //Sort operations//
    }
}
