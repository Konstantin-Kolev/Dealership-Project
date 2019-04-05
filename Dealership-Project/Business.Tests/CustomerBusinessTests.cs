using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Microsoft.EntityFrameworkCore;
using Data.Models;

namespace Business.Tests
{
    [TestFixture]
    public class CustomerBusinessTests
    {
        [Test]
        public void AddCustomer()
        {
            var mockSet = new Mock<DbSet<Customer>>();

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new CustomerBusiness(mockContext.Object);
            service.Add(new Customer());

            mockSet.Verify(m => m.Add(It.IsAny<Customer>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [Test]
        public void GetAllCustomers()
        {
            var data = new List<Customer>
            {
                new Customer{ FirstName="Customer1"},
                new Customer{ FirstName="Customer2"},
                new Customer{ FirstName="Customer3"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new CustomerBusiness(mockContext.Object);
            var customersFound = service.GetAllCustomers();

            Assert.AreEqual(3, customersFound.Count());
            Assert.AreEqual("Customer1", customersFound[0].FirstName);
            Assert.AreEqual("Customer2", customersFound[1].FirstName);
            Assert.AreEqual("Customer3", customersFound[2].FirstName);
        }

        [Test]
        public void GetCustomersByFirstName()
        {
            var data = new List<Customer>
            {
                new Customer{ FirstName="Customer1"},
                new Customer{ FirstName="Customer1"},
                new Customer{ FirstName="Customer3"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new CustomerBusiness(mockContext.Object);
            var customersFound = service.GetCustomersByFirstName("Customer1");

            Assert.AreEqual(2, customersFound.Count());
            Assert.AreEqual("Customer1", customersFound[0].FirstName);
            Assert.AreEqual("Customer1", customersFound[1].FirstName);
        }

        [Test]
        public void GetCustomersByLastName()
        {
            var data = new List<Customer>
            {
                new Customer{ LastName="Customer1"},
                new Customer{ LastName="Customer1"},
                new Customer{ LastName="Customer3"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new CustomerBusiness(mockContext.Object);
            var customersFound = service.GetCustomersByLastName("Customer1");

            Assert.AreEqual(2, customersFound.Count());
            Assert.AreEqual("Customer1", customersFound[0].LastName);
            Assert.AreEqual("Customer1", customersFound[1].LastName);
        }

        [Test]
        public void GetCustomersByTownName()
        {
            var data = new List<Customer>
            {
                new Customer{ FirstName="Customer1",Town=new Town{ Name="Town1"} },
                new Customer{ FirstName="Customer2",Town=new Town{ Name="Town1"} },
                new Customer{ FirstName="Customer3",Town=new Town{ Name="Town2"} },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new CustomerBusiness(mockContext.Object);
            var customersFound = service.GetCustomersByTownName("Town1");

            Assert.AreEqual(2, customersFound.Count());
            Assert.AreEqual("Customer1", customersFound[0].FirstName);
            Assert.AreEqual("Customer2", customersFound[1].FirstName);
        }

        [Test]
        public void SortCustomersByBothNamesAcending()
        {
            var data = new List<Customer>
            {
                new Customer{ FirstName="CustomerB",LastName="A"},
                new Customer{ FirstName="CustomerA",LastName="C"},
                new Customer{ FirstName="CustomerB",LastName="B"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new CustomerBusiness(mockContext.Object);
            var customersFound = service.SortCustomerByBothNamesAscending();

            Assert.AreEqual(3, customersFound.Count());
            Assert.AreEqual("CustomerA", customersFound[0].FirstName);
            Assert.AreEqual("CustomerB", customersFound[1].FirstName);
            Assert.AreEqual("CustomerB", customersFound[2].FirstName);
            Assert.AreEqual("B", customersFound[2].LastName);
        }

        [Test]
        public void SortCustomersByBothNamesDescending()
        {
            var data = new List<Customer>
            {
                new Customer{ FirstName="CustomerB",LastName="A"},
                new Customer{ FirstName="CustomerA",LastName="C"},
                new Customer{ FirstName="CustomerB",LastName="B"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new CustomerBusiness(mockContext.Object);
            var customersFound = service.SortCustomerByBothNamesDescending();

            Assert.AreEqual(3, customersFound.Count());
            Assert.AreEqual("CustomerB", customersFound[0].FirstName);
            Assert.AreEqual("CustomerB", customersFound[1].FirstName);
            Assert.AreEqual("CustomerA", customersFound[2].FirstName);
            Assert.AreEqual("B", customersFound[0].LastName);
        }

        [Test]
        public void SortCustomersByFirstNameAscending()
        {
            var data = new List<Customer>
            {
                new Customer{ FirstName="CustomerC"},
                new Customer{ FirstName="CustomerA"},
                new Customer{ FirstName="CustomerB"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new CustomerBusiness(mockContext.Object);
            var customersFound = service.SortCustomersByFirstNameAscending();

            Assert.AreEqual(3, customersFound.Count());
            Assert.AreEqual("CustomerA", customersFound[0].FirstName);
            Assert.AreEqual("CustomerB", customersFound[1].FirstName);
            Assert.AreEqual("CustomerC", customersFound[2].FirstName);
        }

        [Test]
        public void SortCustomersByFirstNameDescending()
        {
            var data = new List<Customer>
            {
                new Customer{ FirstName="CustomerA"},
                new Customer{ FirstName="CustomerC"},
                new Customer{ FirstName="CustomerB"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new CustomerBusiness(mockContext.Object);
            var customersFound = service.SortCustomersByFirstNameDescending();

            Assert.AreEqual(3, customersFound.Count());
            Assert.AreEqual("CustomerC", customersFound[0].FirstName);
            Assert.AreEqual("CustomerB", customersFound[1].FirstName);
            Assert.AreEqual("CustomerA", customersFound[2].FirstName);
        }

        [Test]
        public void SortCustomersByLastNameAscending()
        {
            var data = new List<Customer>
            {
                new Customer{ LastName="CustomerC"},
                new Customer{ LastName="CustomerA"},
                new Customer{ LastName="CustomerB"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new CustomerBusiness(mockContext.Object);
            var customersFound = service.SortCustomersByLastNameAscending();

            Assert.AreEqual(3, customersFound.Count());
            Assert.AreEqual("CustomerA", customersFound[0].LastName);
            Assert.AreEqual("CustomerB", customersFound[1].LastName);
            Assert.AreEqual("CustomerC", customersFound[2].LastName);
        }

        [Test]
        public void SortCustomersByLastNameDescending()
        {
            var data = new List<Customer>
            {
                new Customer{ LastName="CustomerA"},
                new Customer{ LastName="CustomerC"},
                new Customer{ LastName="CustomerB"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new CustomerBusiness(mockContext.Object);
            var customersFound = service.SortCustomersByLastNameDescending();

            Assert.AreEqual(3, customersFound.Count());
            Assert.AreEqual("CustomerC", customersFound[0].LastName);
            Assert.AreEqual("CustomerB", customersFound[1].LastName);
            Assert.AreEqual("CustomerA", customersFound[2].LastName);
        }

        [Test]
        public void SortCustomersByTownNameAscending()
        {
            var data = new List<Customer>
            {
                new Customer{ FirstName="CustomerA",Town=new Town{ Name="C"} },
                new Customer{ FirstName="CustomerC",Town=new Town{ Name="A"} },
                new Customer{ FirstName="CustomerB",Town=new Town{ Name="B"} },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new CustomerBusiness(mockContext.Object);
            var customersFound = service.SortCustomersByTownNameAscending();

            Assert.AreEqual(3, customersFound.Count());
            Assert.AreEqual("CustomerC", customersFound[0].FirstName);
            Assert.AreEqual("CustomerB", customersFound[1].FirstName);
            Assert.AreEqual("CustomerA", customersFound[2].FirstName);
        }

        [Test]
        public void SortCustomersByTownNameDescending()
        {
            var data = new List<Customer>
            {
                new Customer{ FirstName="CustomerA",Town=new Town{ Name="C"} },
                new Customer{ FirstName="CustomerC",Town=new Town{ Name="A"} },
                new Customer{ FirstName="CustomerB",Town=new Town{ Name="B"} },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new CustomerBusiness(mockContext.Object);
            var customersFound = service.SortCustomersByTownNameDescending();

            Assert.AreEqual(3, customersFound.Count());
            Assert.AreEqual("CustomerA", customersFound[0].FirstName);
            Assert.AreEqual("CustomerB", customersFound[1].FirstName);
            Assert.AreEqual("CustomerC", customersFound[2].FirstName);
        }
    }
}
