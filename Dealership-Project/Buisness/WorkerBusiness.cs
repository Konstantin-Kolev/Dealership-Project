using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Buisness
{
    class WorkerBusiness
    {
        private CarDealershipContext workerContext;

        public List<Worker> GetAllWorkers()
        {
            using (workerContext = new CarDealershipContext())
            {
                return workerContext.Workers.ToList();
            }
        }

        public Worker GetWorker(int id)
        {
            using (workerContext = new CarDealershipContext())
            {
                return workerContext.Workers.Find(id);
            }
        }

        public void Add(Worker worker)
        {
            using (workerContext = new CarDealershipContext())
            {
                workerContext.Workers.Add(worker);
                workerContext.SaveChanges();
            }
        }

        public void Update(Worker worker)
        {
            using (workerContext = new CarDealershipContext())
            {
                var item = workerContext.Workers.Find(worker.Id);
                if (item != null)
                {
                    workerContext.Entry(item).CurrentValues.SetValues(worker);
                    workerContext.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (workerContext = new CarDealershipContext())
            {
                var worker = workerContext.Workers.Find(id);
                if (worker != null)
                {
                    workerContext.Workers.Remove(worker);
                    workerContext.SaveChanges();
                }
            }
        }
    }
}
