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

        public WorkerBusiness()
        {
            this.workerContext = new CarDealershipContext();
        }

        public WorkerBusiness(CarDealershipContext carDealershipContext)
        {
            this.workerContext = new CarDealershipContext();
        }

        //Basic operations//
        public void Add(Worker worker)
        {
            using (workerContext)
            {
                workerContext.Workers.Add(worker);
                workerContext.SaveChanges();
            }
        }

        public void Update(Worker worker)
        {
            using (workerContext)
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
            using (workerContext)
            {
                var worker = workerContext.Workers.Find(id);
                if (worker != null)
                {
                    workerContext.Workers.Remove(worker);
                    workerContext.SaveChanges();
                }
            }
        }
        //Basic operations//

        //Get operations//
        public List<Worker> GetAllWorkers()
        {
            using (workerContext = new CarDealershipContext())
            {
                return workerContext.Workers.ToList();
            }
        }

        public Worker GetWorkerById(int id)
        {
            using (workerContext)
            {
                return workerContext.Workers.Find(id);
            }
        }

        public List<Worker> GetWorkersByFirstName(string firstName)
        {
            using (workerContext)
            {
                return workerContext.Workers.Where(x => x.FirstName == firstName).ToList();
            }
        }

        public List<Worker> GetWorkersByLastName(string lastName)
        {
            using (workerContext)
            {
                return workerContext.Workers.Where(x => x.LastName == lastName).ToList();
            }
        }

        public List<Worker> GetWorkersByPosition(string position)
        {
            using (workerContext)
            {
                return workerContext.Workers.Where(x => x.Position == position).ToList();
            }
        }

        public List<Worker> GetWorkersBySalary(decimal salary)
        {
            using (workerContext)
            {
                return workerContext.Workers.Where(x => x.Salary == salary).ToList();
            }
        }

        public List<Worker> GetWorkersByDealershipId(int dealershipId)
        {
            using (workerContext)
            {
                return workerContext.Workers.Where(x => x.CarDealershipId == dealershipId).ToList();
            }
        }
        //Get operations//

        //Sort operations//
        public List<Worker> SortWorkersByBothNamesAscending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
            }
        }

        public List<Worker> SortWorkersByBothNamesDescending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName).ToList();
            }
        }

        public List<Worker> SortWorkersByFirstNameAscending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderBy(x => x.FirstName).ToList();
            }
        }

        public List<Worker> SortWorkersByFirstNameDescending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderByDescending(x => x.FirstName).ToList();
            }
        }

        public List<Worker> SortWorkersByLastNameAscending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderBy(x => x.LastName).ToList();
            }
        }

        public List<Worker> SortWorkersByLastNameDescending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderByDescending(x => x.LastName).ToList();
            }
        }

        public List<Worker> SortWorkersByPosition()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderBy(x => x.Position).ToList();
            }
        }

        public List<Worker> SortWorkersBySalaryAscending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderBy(x => x.Salary).ToList();
            }
        }

        public List<Worker> SortWorkersBySalaryDescending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderByDescending(x => x.Salary).ToList();
            }
        }

        public List<Worker> SortWorkersByCarDealership()
        {
            using (workerContext = new CarDealershipContext())
            {
                return workerContext.Workers.OrderBy(x => x.CarDealership.Name).ToList();
            }
        }
        //Sort operations//
    }
}
