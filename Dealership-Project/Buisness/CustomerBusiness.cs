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

        public CustomerBusiness()
        {
            this.customerContext = new CarDealershipContext();
        }

        public CustomerBusiness(CarDealershipContext carDealershipContext)
        {
            this.customerContext = carDealershipContext;
        }

        //Basic operations//
        public void Add(Customer customer)
        {
            using (customerContext)
            {
                customerContext.Customers.Add(customer);
                customerContext.SaveChanges();
            }
        }

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
        public List<Customer> GetAllCustomers()
        {
            using (customerContext)
            {
                return customerContext.Customers.ToList();
            }
        }

        public Customer GetCustomerById(int id)
        {
            using (customerContext)
            {
                return customerContext.Customers.Find(id);
            }
        }

        public Customer GetCustomerById(int? id)
        {
            using (customerContext)
            {
                return customerContext.Customers.Find(id);
            }
        }

        public List<Customer> GetCustomersByFirstName(string firstName)
        {
            using (customerContext)
            {
                return customerContext.Customers.Where(x => x.FirstName == firstName).ToList();
            }
        }

        public List<Customer> GetCustomersByLastName(string lastName)
        {
            using (customerContext)
            {
                return customerContext.Customers.Where(x => x.LastName == lastName).ToList();
            }
        }

        public List<Customer> GetCustomersByTownId(int townId)
        {
            using (customerContext)
            {
                return customerContext.Customers.Where(x => x.TownId == townId).ToList();
            }
        }

        public List<Customer> GetCustomersByTownName(string townName)
        {
            using (customerContext)
            {
                return customerContext.Customers.Where(x => x.Town.Name == townName).ToList();
            }
        }
        //Get operations//

        //Sort operations//
        public List<Customer> SortCustomerByBothNamesAscending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
            }
        }

        public List<Customer> SortCustomerByBothNamesDescending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName).ToList();
            }
        }

        public List<Customer> SortCustomersByFirstNameAscending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderBy(x => x.FirstName).ToList();
            }
        }

        public List<Customer> SortCustomersByFirstNameDescending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderByDescending(x => x.FirstName).ToList();
            }
        }

        public List<Customer> SortCustomersByLastNameAscending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderBy(x => x.LastName).ToList();
            }
        }

        public List<Customer> SortCustomersByLastNameDescending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderByDescending(x => x.LastName).ToList();
            }
        }

        public List<Customer> SortCustomersByTownNameAscending()
        {
            using (customerContext)
            {
                return customerContext.Customers.OrderBy(x => x.Town.Name).ToList();
            }
        }

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
