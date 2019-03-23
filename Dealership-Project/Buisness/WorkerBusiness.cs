using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Business
{
    public class WorkerBusiness
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

        public List<Worker> GetWorkersByFirstName(string firstName)
        {
            using (workerContext = new CarDealershipContext())
            {
                return workerContext.Workers.Where(x => x.FirstName == firstName).ToList();
            }
        }

        public List<Worker> GetWorkersByLastName(string lastName)
        {
            using (workerContext = new CarDealershipContext())
            {
                return workerContext.Workers.Where(x => x.LastName == lastName).ToList();
            }
        }

        public List<Worker> GetWorkersByPosition(string position)
        {
            using (workerContext = new CarDealershipContext())
            {
                return workerContext.Workers.Where(x => x.Position == position).ToList();
            }
        }

        public List<Worker> GetWorkersBySalary(decimal salary)
        {
            using (workerContext = new CarDealershipContext())
            {
                return workerContext.Workers.Where(x => x.Salary == salary).ToList();
            }
        }

        public List<Worker> GetWorkersByDealershipId(int dealershipId)
        {
            using (workerContext = new CarDealershipContext())
            {
                return workerContext.Workers.Where(x => x.CarDealershipId == dealershipId).ToList();
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
