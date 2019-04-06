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
                    engineContext.SaveChanges();
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
        /// Find all engines with engine displacement higher than given
        /// </summary>
        /// <param name="displacement">The smallest engine displacement for which engines will be shown</param>
        /// <returns>Returns a list of all engines with displacement larger than given</returns>
        public List<Engine> GetEnginesWithHigherDisplacement(int displacement)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.Displacement >= displacement).ToList();
            }
        }

        /// <summary>
        /// Find all engines with engine displacement lower than given
        /// </summary>
        /// <param name="displacement">The largest engine displacement for which engines will be shown</param>
        /// <returns>Returns a list of all engines with displacement lower than given</returns>
        public List<Engine> GetEnginesWithLowerDisplacement(int displacement)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.Displacement <= displacement).ToList();
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
        /// Find all engines with horsepower lower than given
        /// </summary>
        /// <param name="displacement">The most power for which engines will be shown</param>
        /// <returns>Returns a list of all engines with less power than given</returns>
        public List<Engine> GetEnginesWithLowerPower(int power)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.Power <= power).ToList();
            }
        }

        /// <summary>
        /// Find all engines with horsepower higher than given
        /// </summary>
        /// <param name="displacement">The least power for which engines will be shown</param>
        /// <returns>Returns a list of all engines with more power than given</returns>
        public List<Engine> GetEnginesWithHigherPower(int power)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.Power >= power).ToList();
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
        /// Find all engines with economy lower than given
        /// </summary>
        /// <param name="economyPerHundredKm">The worst economy for which engines will be shown</param>
        /// <returns>Returns a list of all engines with economy better than given</returns>
        public List<Engine> GetEnginesWithLowerEconomyPerHundredKm(decimal economyPerHundredKm)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.EconomyPerHundredKm <= economyPerHundredKm).ToList();
            }
        }
        /// <summary>
        /// Find all engines with economy higher than given
        /// </summary>
        /// <param name="economyPerHundredKm">The best economy for which engines will be shown</param>
        /// <returns>Returns a list of all engines with economy worse than given</returns>
        public List<Engine> GetEnginesWithHigherEconomyPerHundredKm(decimal economyPerHundredKm)
        {
            using (engineContext)
            {
                return engineContext.Engines.Where(x => x.EconomyPerHundredKm >= economyPerHundredKm).ToList();
            }
        }
        /// <summary>
        /// Find an engine by a given name
        /// </summary>
        /// <param name="name">The name you are searching for</param>
        /// <returns>Returns the engine that matches the given name</returns>
        public Engine GetEngineByName(string name)
        {
            using (engineContext)
            {
                var list= engineContext.Engines.Where(x => x.Name == name).ToList();
                return list[0];
            }
        }
        //Get operations//

        //Sort operations//
        
        /// <summary>
        /// Sorts engines
        /// </summary>
        /// <returns>List of sorted engines by fuel type in ascending order</returns>
        public List<Engine> SortEnginesByFuelType()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderBy(x => x.FuelType).ToList();
            }
        }

        /// <summary>
        /// Sorts engines
        /// </summary>
        /// <returns>List of sorted engines by displacement in ascending order</returns>
        public List<Engine> SortEnginesByDisplacementAscending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderBy(x => x.Displacement).ToList();
            }
        }

        /// <summary>
        /// Sorts engines
        /// </summary>
        /// <returns>List of sorted engines by displacement in ascending order</returns>
        public List<Engine> SortEnginesByDisplacementDescending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderByDescending(x => x.Displacement).ToList();
            }
        }

        /// <summary>
        /// Sorts engines
        /// </summary>
        /// <returns>List of sorted engines by power in ascending order</returns>
        public List<Engine> SortEnginesByPowerAscending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderBy(x => x.Power).ToList();
            }
        }

        /// <summary>
        /// Sorts engines
        /// </summary>
        /// <returns>List of sorted engines by power in descending order order</returns>
        public List<Engine> SortEnginesByPowerDescending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderByDescending(x => x.Power).ToList();
            }
        }

        /// <summary>
        /// Sorts engines
        /// </summary>
        /// <returns>List of sorted engines by fuel economy in ascending order</returns>
        public List<Engine> SortEnginesByEconomyPerHundredKmAscending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderBy(x => x.EconomyPerHundredKm).ToList();
            }
        }

        /// <summary>
        /// Sorts engines
        /// </summary>
        /// <returns>List of sorted engines by fuel economy in descending order</returns>
        public List<Engine> SortEnginesByEconomyPerHundredKmDescending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderByDescending(x => x.EconomyPerHundredKm).ToList();
            }
        }

        /// <summary>
        /// Sorts engines
        /// </summary>
        /// <returns>List of sorted engines by name in ascending order</returns>
        public List<Engine> SortEnginesByNameAscending()
        {
            using (engineContext)
            {
                return engineContext.Engines.OrderBy(x => x.Name).ToList();
            }
        }

        /// <summary>
        /// Sorts engines
        /// </summary>
        /// <returns>List of sorted engines by name in ascending order</returns>
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
