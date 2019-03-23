using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Buisness
{
    class CustomerBusiness
    {
        private CarDealershipContext customerContext;

        public List<Customer> GetAllCustomers()
        {
            using (customerContext = new CarDealershipContext())
            {
                return customerContext.Customers.ToList();
            }
        }

        public Customer GetCustomerById(int id)
        {
            using (customerContext = new CarDealershipContext())
            {
                return customerContext.Customers.Find(id);
            }
        }

        public List<Customer> GetCustomersByFirstName(string firstName)
        {
            using (customerContext = new CarDealershipContext())
            {
                return customerContext.Customers.Where(x => x.FirstName == firstName).ToList();
            }
        }

        public List<Customer> GetCustomersByLastName(string lastName)
        {
            using (customerContext = new CarDealershipContext())
            {
                return customerContext.Customers.Where(x => x.LastName == lastName).ToList();
            }
        }

        public List<Customer> GetCustomersByTownId(int townId)
        {
            using (customerContext = new CarDealershipContext())
            {
                return customerContext.Customers.Where(x => x.TownId == townId).ToList();
            }
        }

        public void Add(Customer customer)
        {
            using (customerContext = new CarDealershipContext())
            {
                customerContext.Customers.Add(customer);
                customerContext.SaveChanges();
            }
        }

        public void Update(Customer customer)
        {
            using (customerContext = new CarDealershipContext())
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
            using (customerContext = new CarDealershipContext())
            {
                var customer = customerContext.Customers.Find(id);
                if (customer != null)
                {
                    customerContext.Customers.Remove(customer);
                    customerContext.SaveChanges();
                }
            }
        }
    }
}
