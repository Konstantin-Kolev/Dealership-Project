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
        /// <summary>
        /// Create a new instance of the class with a new context
        /// </summary>
        public WorkerBusiness()
        {
            this.workerContext = new CarDealershipContext();
        }
        /// <summary>
        /// Create a new instance of the class with an existing context
        /// </summary>
        /// <param name="carDealershipContext">An existign context to be used by the instance of the class</param>
        public WorkerBusiness(CarDealershipContext carDealershipContext)
        {
            this.workerContext = new CarDealershipContext();
        }

        //Basic operations//
        /// <summary>
        /// Add a new worker to the database
        /// </summary>
        /// <param name="worker">The worker that need to be added to the database</param>
        public void Add(Worker worker)
        {
            using (workerContext)
            {
                workerContext.Workers.Add(worker);
                workerContext.SaveChanges();
            }
        }
        /// <summary>
        /// Change the information about one of the workers
        /// </summary>
        /// <param name="worker">A worker with the new information and the same id as the old one</param>
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
        /// <summary>
        /// Remove a worker from the database
        /// </summary>
        /// <param name="id">The id of the worker that needs to be removed</param>
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
        /// <summary>
        /// Find all workers in the database
        /// </summary>
        /// <returns>Returns a list of all workers in the database</returns>
        public List<Worker> GetAllWorkers()
        {
            using (workerContext = new CarDealershipContext())
            {
                return workerContext.Workers.ToList();
            }
        }
        /// <summary>
        /// Find a worker by a given id
        /// </summary>
        /// <param name="id">The id of the worker you are searching for</param>
        /// <returns>Returns the worker that matches the given id</returns>
        public Worker GetWorkerById(int id)
        {
            using (workerContext)
            {
                return workerContext.Workers.Find(id);
            }
        }
        /// <summary>
        /// Find all workers with a given first name
        /// </summary>
        /// <param name="firstName">The first name you are searching for</param>
        /// <returns>Returns a list of all workers with the given first name</returns>
        public List<Worker> GetWorkersByFirstName(string firstName)
        {
            using (workerContext)
            {
                return workerContext.Workers.Where(x => x.FirstName == firstName).ToList();
            }
        }
        /// <summary>
        /// Find all workers with a given last name
        /// </summary>
        /// <param name="firstName">The last name you are searching for</param>
        /// <returns>Returns a list of all workers with the given last name</returns>
        public List<Worker> GetWorkersByLastName(string lastName)
        {
            using (workerContext)
            {
                return workerContext.Workers.Where(x => x.LastName == lastName).ToList();
            }
        }
        /// <summary>
        /// Find all workers with a given position
        /// </summary>
        /// <param name="position">The position you are searching for</param>
        /// <returns>Returns a list of all workers with the given position</returns>
        public List<Worker> GetWorkersByPosition(string position)
        {
            using (workerContext)
            {
                return workerContext.Workers.Where(x => x.Position == position).ToList();
            }
        }
        /// <summary>
        /// Find all workers with a given salary
        /// </summary>
        /// <param name="salary">The salary you are searching for</param>
        /// <returns>Returns a list of all workers with the given salary</returns>
        public List<Worker> GetWorkersBySalary(decimal salary)
        {
            using (workerContext)
            {
                return workerContext.Workers.Where(x => x.Salary == salary).ToList();
            }
        }
        /// <summary>
        /// Find all workers with salary higher than given
        /// </summary>
        /// <param name="salary">The lowest salary for which workers will be shown</param>
        /// <returns>Returns a list of workers with salary higher than given</returns>
        public List<Worker> GetWorkersWithHigherSalary(decimal salary)
        {
            using (workerContext)
            {
                return workerContext.Workers.Where(x => x.Salary >= salary).ToList();
            }
        }
        /// <summary>
        /// Find all workers with salary lower than given
        /// </summary>
        /// <param name="salary">The highest salary for which workers will be shown</param>
        /// <returns>Returns a list of workers with salary lower than given</returns>
        public List<Worker> GetWorkersWithLowerSalary(decimal salary)
        {
            using (workerContext)
            {
                return workerContext.Workers.Where(x => x.Salary <= salary).ToList();
            }
        }
        /// <summary>
        /// Find all workers in a given dealership
        /// </summary>
        /// <param name="dealershipId">The id of the dealership you are searching for</param>
        /// <returns>Returns a list of all workers in the given dealership</returns>
        public List<Worker> GetWorkersByDealershipId(int dealershipId)
        {
            using (workerContext)
            {
                return workerContext.Workers.Where(x => x.CarDealershipId == dealershipId).ToList();
            }
        }
        /// <summary>
        /// Find the name of a dealership from a worker's DealershipId
        /// </summary>
        /// <param name="dealershipId">The id of a worker's dealership you want the name of</param>
        /// <returns>Returns the name of the dealership as a string</returns>
        public string GetDealershipName(int dealershipId)
        {
            CarDealershipBusiness carDealershipBusiness = new CarDealershipBusiness();
            var dealership = carDealershipBusiness.GetCarDealershipById(dealershipId);
            return dealership.Name;
        }
        //Get operations//

        //Sort operations//
        /// <summary>
        /// Sorts workers
        /// </summary>
        /// <returns>List of workers sorted by both names in ascending order</returns>
        public List<Worker> SortWorkersByBothNamesAscending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
            }
        }

        /// <summary>
        /// Sorts workers
        /// </summary>
        /// <returns>List of workers sorted by both names in descending order</returns>
        public List<Worker> SortWorkersByBothNamesDescending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName).ToList();
            }
        }

        /// <summary>
        /// Sorts workers
        /// </summary>
        /// <returns>List of workers sorted by first name in ascending order</returns>
        public List<Worker> SortWorkersByFirstNameAscending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderBy(x => x.FirstName).ToList();
            }
        }

        /// <summary>
        /// Sorts workers
        /// </summary>
        /// <returns>List of workers sorted by first name in descending order</returns>
        public List<Worker> SortWorkersByFirstNameDescending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderByDescending(x => x.FirstName).ToList();
            }
        }

        /// <summary>
        /// Sorts workers
        /// </summary>
        /// <returns>List of workers sorted by last name in ascending order</returns>
        public List<Worker> SortWorkersByLastNameAscending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderBy(x => x.LastName).ToList();
            }
        }

        /// <summary>
        /// Sorts workers
        /// </summary>
        /// <returns>List of workers sorted by last name in descending order</returns>
        public List<Worker> SortWorkersByLastNameDescending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderByDescending(x => x.LastName).ToList();
            }
        }

        /// <summary>
        /// Sorts workers 
        /// </summary>
        /// <returns>List of workers sorted by position in ascending order</returns>
        public List<Worker> SortWorkersByPosition()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderBy(x => x.Position).ToList();
            }
        }

        /// <summary>
        /// Sorts workers
        /// </summary>
        /// <returns>List of workers sorted by salary in ascending order</returns>
        public List<Worker> SortWorkersBySalaryAscending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderBy(x => x.Salary).ToList();
            }
        }

        /// <summary>
        /// Sorts workers
        /// </summary>
        /// <returns>List of workers sorted by salary in descending order</returns>
        public List<Worker> SortWorkersBySalaryDescending()
        {
            using (workerContext)
            {
                return workerContext.Workers.OrderByDescending(x => x.Salary).ToList();
            }
        }

        /// <summary>
        /// Sorts workers
        /// </summary>
        /// <returns>List of workers sorted by dealership name in ascending order</returns>
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
