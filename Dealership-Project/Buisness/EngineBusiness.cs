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
        /// <summary>
        /// Create a new instance of the class with a new context
        /// </summary>
        public EngineBusiness()
        {
            this.engineContext = new CarDealershipContext();
        }
        /// <summary>
        /// Create a new instance of the class with an existing context
        /// </summary>
        /// <param name="carDealershipContext">An existing context to be used by the instance of the class</param>
        public EngineBusiness(CarDealershipContext carDealershipContext)
        {
            this.engineContext = carDealershipContext;
        }

        //Basic operations//
        /// <summary>
        /// Add a new engine to the database
        /// </summary>
        /// <param name="engine">The engine that needs to be added to the database</param>
        public void Add(Engine engine)
        {
            using (engineContext)
            {
                engineContext.Engines.Add(engine);
                engineContext.SaveChanges();

            }
        }
        /// <summary>
        /// Change the information about on of the engines
        /// </summary>
        /// <param name="engine">An engine with the new information and the same id as the old one</param>
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
        /// <summary>
        /// Remove an engine from the database
        /// </summary>
        /// <param name="id">The id of the engine that needs to be removed</param>
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
        /// <summary>
        /// Find all engines in the database
        /// </summary>
        /// <returns>Returns a list of all engines in the database</returns>
        public List<Engine> GetAllEngines()
        {
            using (engineContext)
            {
                return engineContext.Engines.ToList();
            }
        }
        /// <summary>
        /// Find an engine by a given id
        /// </summary>
        /// <param name="id">The id of the engine you are searching for</param>
        /// <returns>Returns the engine that matches the given id</returns>
        public Engine GetEngineById(int id)
        {
            using (engineContext)
            {
                return engineContext.Engines.Find(id);
            }
        }
        /// <summary>
        /// Find all engines with a given fuel type
        /// </summary>
        /// <param name="fuelType">The fuel type you are searchign for</param>
        /// <returns>Returns a list of all engines with the given fueal type</returns>
        public List<Engine> GetEnginesByFuelType(string fuelType)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.FuelType == fuelType).ToList();
            }
        }
        /// <summary>
        /// Find all engine with a given displacement
        /// </summary>
        /// <param name="displacement">The displacement you are searching for</param>
        /// <returns>Returns a list of all engines with the given displacement</returns>
        public List<Engine> GetEnginesByDisplacement(int displacement)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.Displacement == displacement).ToList();
            }
        }
        /// <summary>
        /// Find all engines with a given power
        /// </summary>
        /// <param name="power">The power you are searching for</param>
        /// <returns>Returns a list of all engines with the given power</returns>
        public List<Engine> GetEnginesByPower(int power)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.Power == power).ToList();
            }
        }
        /// <summary>
        /// Find all engines with a given economy
        /// </summary>
        /// <param name="economyPerHundredKm">The economy you are searching for</param>
        /// <returns>Returns a list of all engines with the given economy</returns>
        public List<Engine> GetEnginesByEconomyPerHundredKm(decimal economyPerHundredKm)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.EconomyPerHundredKm == economyPerHundredKm).ToList();
            }
        }
        /// <summary>
        /// Find an engine by a given name
        /// </summary>
        /// <param name="name">The name you are searching for</param>
        /// <returns>Returns the engine that matches the given name</returns>
        public Engine GetEnginesByName(string name)
        {
            using (engineContext)
            {
                
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
