using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Buisness
{
    class EngineBusiness
    {
        private CarDealershipContext engineContext;

        public List<Engine> GetAllEngines()
        {
            using (engineContext = new CarDealershipContext())
            {
                return engineContext.Engines.ToList();
            }
        }

        public Engine GetEngine(int id)
        {
            using (engineContext = new CarDealershipContext())
            {
                return engineContext.Engines.Find(id);
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
