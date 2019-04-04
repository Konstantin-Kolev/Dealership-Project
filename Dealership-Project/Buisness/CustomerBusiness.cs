using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Business
{
    public class CustomerBusiness
    {
        private CarDealershipContext customerContext;
        /// <summary>
        /// Create a new instance of the class with a new context
        /// </summary>
        public CustomerBusiness()
        {
            this.customerContext = new CarDealershipContext();
        }
        /// <summary>
        /// Create a new instance of the class with an existing context
        /// </summary>
        /// <param name="carDealershipContext">An existing context to be used by the instance of the class</param>
        public CustomerBusiness(CarDealershipContext carDealershipContext)
        {
            this.customerContext = carDealershipContext;
        }

        //Basic operations//
        /// <summary>
        /// Add a new customer to the database
        /// </summary>
        /// <param name="customer">The customer that needs to be added to the database</param>
        public void Add(Customer customer)
        {
            using (customerContext)
            {
                customerContext.Customers.Add(customer);
                customerContext.SaveChanges();
            }
        }
        /// <summary>
        /// Change the information about one of the customers
        /// </summary>
        /// <param name="customer">A customer with the new information and the same id as the old one</param>
        public void Update(Customer customer)
        {
            using (customerContext)
            {
                var item = customerContext.Customers.Find(customer.Id);
                if (item != null)
                {
                    customerContext.Entry(item).CurrentValues.SetValues(customer);
                    customerContext.SaveChanges();
                }
            }
        }
        /// <summary>
        /// Remove a customer from the database
        /// </summary>
        /// <param name="id">The id of the customer that need to be removed</param>
        public void Delete(int id)
        {
            using (customerContext)
            {
                var customer = customerContext.Customers.Find(id);
                if (customer != null)
                {
                    customerContext.Customers.Remove(customer);
                    customerContext.SaveChanges();
                }
            }
        }
        //Basic operations//

        //Get operations//
        /// <summary>
        /// Find all customers in the database
        /// </summary>
        /// <returns>Returns a list of all customers in the database</returns>
        public List<Customer> GetAllCustomers()
        {
            using (customerContext)
            {
                return customerContext.Customers.ToList();
            }
        }
        /// <summary>
        /// Find a customer by a given id
        /// </summary>
        /// <param name="id">The id of the customer you are searching for</param>
        /// <returns>Returns the customer that matches the given id</returns>
        public Customer GetCustomerById(int id)
        {
            using (customerContext)
            {
                return customerContext.Customers.Find(id);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customer GetCustomerById(int? id)
        {
            using (customerContext)
            {
                return customerContext.Customers.Find(id);
            }
        }
        /// <summary>
        /// Find all customers witha given first name
        /// </summary>
        /// <param name="firstName">The first name you are searching for</param>
        /// <returns>Returns a list of all customers with the given first name</returns>
        public List<Customer> GetCustomersByFirstName(string firstName)
        {
            using (customerContext)
            {
                return customerContext.Customers.Where(x => x.FirstName == firstName).ToList();
            }
        }
        /// <summary>
        /// Find all customers witha given last name
        /// </summary>
        /// <param name="firstName">The last name you are searching for</param>
        /// <returns>Returns a list of all customers with the given last name</returns>
        public List<Customer> GetCustomersByLastName(string lastName)
        {
            using (customerContext)
            {
                return customerContext.Customers.Where(x => x.LastName == lastName).ToList();
            }
        }
        /// <summary>
        /// Find all customers from a given town by the town id
        /// </summary>
        /// <param name="townId">The id of the town you are searching for</param>
        /// <returns>Returns a list of customers from the given town</returns>
        public List<Customer> GetCustomersByTownId(int townId)
        {
            using (customerContext)
            {
                return customerContext.Customers.Where(x => x.TownId == townId).ToList();
            }
        }
        /// <summary>
        /// Find all customers from given town by the town name
        /// </summary>
        /// <param name="townName">The name of the town you are searching for</param>
        /// <returns>Returns a list of all customers from the given town</returns>
        public List<Customer> GetCustomersByTownName(string townName)
        {
            using (customerContext)
            {
                return customerContext.Customers.Where(x => x.Town.Name == townName).ToList();
            }
        }
        /// <summary>
        /// Find the name of a town by a customer's TownId
        /// </summary>
        /// <param name="townId">The id of a customer's town you want the name of</param>
        /// <returns>The name of the town as a string</returns>
        public string GetTownName(int townId)
        {
            TownBusiness townBusiness = new TownBusiness();
            var town = townBusiness.GetTownById(townId);
            return town.Name;
        }
        //Get operations//

        //Sort operations//

        /// <summary>
        /// Sorts customer
        /// </summary>
        /// <returns>List of sorted customers by both names in ascending order</returns>
        public List<Customer> SortCustomerByBothNamesAscending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
            }
        }

        /// <summary>
        /// Sorts customer
        /// </summary>
        /// <returns>List of sorted customers by both names in ascending order</returns>
        public List<Customer> SortCustomerByBothNamesDescending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName).ToList();
            }
        }

        /// <summary>
        /// Sorts customer
        /// </summary>
        /// <returns>List of sorted customers by first name in ascending order</returns>
        public List<Customer> SortCustomersByFirstNameAscending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderBy(x => x.FirstName).ToList();
            }
        }

        /// <summary>
        /// Sorts customer
        /// </summary>
        /// <returns>List of sorted customers by first name in descending order</returns>
        public List<Customer> SortCustomersByFirstNameDescending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderByDescending(x => x.FirstName).ToList();
            }
        }

        /// <summary>
        /// Sorts customer
        /// </summary>
        /// <returns>List of sorted customers by last name in ascending order</returns>
        public List<Customer> SortCustomersByLastNameAscending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderBy(x => x.LastName).ToList();
            }
        }

        /// <summary>
        /// Sorts customer
        /// </summary>
        /// <returns>List of sorted customers by last name in descending order</returns>
        public List<Customer> SortCustomersByLastNameDescending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderByDescending(x => x.LastName).ToList();
            }
        }

        /// <summary>
        /// Sorts customer
        /// </summary>
        /// <returns>List of sorted customers by town name in ascending order</returns>
        public List<Customer> SortCustomersByTownNameAscending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderBy(x => x.Town.Name).ToList();
            }
        }

        /// <summary>
        /// Sorts customer
        /// </summary>
        /// <returns>List of sorted customers by town name in ascending order</returns>
        public List<Customer> SortCustomersByTownNameDescending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderByDescending(x => x.Town.Name).ToList();
            }
        }
        //Sort operations//
    }
}
