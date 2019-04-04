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
        /// <summary>
        /// Create a new instance of the class with a new context
        /// </summary>
        public TownBusiness()
        {
            this.townContext = new CarDealershipContext();
        }
        /// <summary>
        /// Create a new instance of the class with an existing context
        /// </summary>
        /// <param name="carDealershipContext">AN existing context to be used by the instance of the class</param>
        public TownBusiness(CarDealershipContext carDealershipContext)
        {
            this.townContext = carDealershipContext;
        }

        //Basic operations//
        /// <summary>
        /// Add a new town to the database
        /// </summary>
        /// <param name="town">The town that needs to be added to the database</param>
        public void Add(Town town)
        {
            using (townContext)
            {
                townContext.Towns.Add(town);
                townContext.SaveChanges();
            }
        }
        /// <summary>
        /// Change the information about one of the towns
        /// </summary>
        /// <param name="town">A town with the new information an the same id as the old one</param>
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
        /// <summary>
        /// Remove a town from the database
        /// </summary>
        /// <param name="id">The id of the town that needs to be removed</param>
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
        /// <summary>
        /// Find all towns in the database
        /// </summary>
        /// <returns>Retuns a list of all towns in the database</returns>
        public List<Town> GetAllTowns()
        {
            using (townContext)
            {
                return townContext.Towns.ToList();
            }
        }
        /// <summary>
        /// Find a town by a given id
        /// </summary>
        /// <param name="id">The id of the town you are searching for</param>
        /// <returns>Returns the town that matches the given id</returns>
        public Town GetTownById(int id)
        {
            using (townContext)
            {
                return townContext.Towns.Find(id);
            }
        }
        /// <summary>
        /// Find a town by a given name
        /// </summary>
        /// <param name="name">The bname of the town you are searching for</param>
        /// <returns>Returns the town that matches the given name</returns>
        public Town GetTownByName(string name)
        {
            using (townContext)
            {
                var list= townContext.Towns.Where(x => x.Name == name).ToList();
                return list[0];
            }
        }
        //Get operations//
        
        //Sort operations//

        /// <summary>
        /// Sorts towns
        /// </summary>
        /// <returns>List of towns sorted by name in ascending order</returns>
        public List<Town> SortTownsByNameAscending()
        {
            using (townContext)
            {
                return townContext.Towns.OrderBy(x => x.Name).ToList();
            }
        }

        /// <summary>
        /// Sorts towns
        /// </summary>
        /// <returns>List of towns sorted by name in ascending order</returns>
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
