using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Data.Models;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Business.Tests
{
    [TestFixture]
    public class CarDealershipBuisnessTests
    {
        [Test]
        public void AddCarDealership()
        {
            var mockSet = new Mock<DbSet<CarDealership>>();

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.CarDealerships).Returns(mockSet.Object);

            var service = new CarDealershipBusiness(mockContext.Object);
            service.Add(new CarDealership());

            mockSet.Verify(m => m.Add(It.IsAny<CarDealership>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [Test]
        public void GetAllDealerships()
        {
            var data = new List<CarDealership>
            {
                new CarDealership{ Name="CarDealership1"},
                new CarDealership{ Name="CarDealership2"},
                new CarDealership{ Name="CarDealership3"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<CarDealership>>();
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.CarDealerships).Returns(mockSet.Object);

            var service = new CarDealershipBusiness(mockContext.Object);
            var carDealershipsFound = service.GetAllCarDealerships();

            Assert.AreEqual(3, carDealershipsFound.Count());
            Assert.AreEqual("CarDealership1", carDealershipsFound[0].Name);
            Assert.AreEqual("CarDealership2", carDealershipsFound[1].Name);
            Assert.AreEqual("CarDealership3", carDealershipsFound[2].Name);
        }

        /*[Test]
        public void GetCarDealershipById()
        {
            var data = new List<CarDealership>
            {
                new CarDealership{ Name="CarDealership1",Id=1},
                new CarDealership{ Name="CarDealership2",Id=2},
                new CarDealership{ Name="CarDealership3",Id=3},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<CarDealership>>();
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.CarDealerships).Returns(mockSet.Object);

            var service = new CarDealershipBusiness(mockContext.Object);
            var carDealershipFound = service.GetCarDealershipById(1);

            Assert.AreEqual("CarDealership1", carDealershipFound.Name);
        }*/

        [Test]
        public void GetCarDealershipByName()
        {
            var data = new List<CarDealership>
            {
                new CarDealership{ Name="CarDealership1"},
                new CarDealership{ Name="CarDealership2"},
                new CarDealership{ Name="CarDealership3"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<CarDealership>>();
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.CarDealerships).Returns(mockSet.Object);

            var service = new CarDealershipBusiness(mockContext.Object);
            var dealershipFound = service.GetCarDealershipByName("CarDealership1");

            Assert.AreEqual("CarDealership1", dealershipFound.Name);
        }

        [Test]
        public void GetcarDealershipByTown()
        {
            var data = new List<CarDealership>
            {
                new CarDealership{ Name="CarDealership1",Town=new Town{ Name="Town1"} },
                new CarDealership{ Name="CarDealership2",Town=new Town{ Name="Town2"} },
                new CarDealership{ Name="CarDealership3",Town=new Town{ Name="Town1"} },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<CarDealership>>();
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.CarDealerships).Returns(mockSet.Object);

            var service = new CarDealershipBusiness(mockContext.Object);
            var dealershipsFound = service.GetDealershipsByTown("Town1");

            Assert.AreEqual(2, dealershipsFound.Count());
            Assert.AreEqual("CarDealership1", dealershipsFound[0].Name);
            Assert.AreEqual("CarDealership3", dealershipsFound[1].Name);
        }

        /*[Test]
        public void GetTownName()
        {
            var data = new List<CarDealership>
            {
                new CarDealership{ Name="CarDealership1"},
                new CarDealership{ Name="CarDealership2",Town=new Town{ Id=6,Name="Town1"} },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<CarDealership>>();
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.CarDealerships).Returns(mockSet.Object);

            var service = new CarDealershipBusiness(mockContext.Object);
            var list = data.ToList();
            var townNameFound = service.GetTownName(list[1].Town.Id);

            Assert.AreEqual("Town1", townNameFound);
        }*/

        [Test]
        public void SortDealershipsByNameAscending()
        {
            var data = new List<CarDealership>
            {
                new CarDealership{ Name="DealershipC"},
                new CarDealership{ Name="DealershipA"},
                new CarDealership{ Name="DealershipB"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<CarDealership>>();
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.CarDealerships).Returns(mockSet.Object);

            var service = new CarDealershipBusiness(mockContext.Object);
            var sortedDealerships = service.SortDealershipsByNameAscending();

            Assert.AreEqual("DealershipA", sortedDealerships[0].Name);
            Assert.AreEqual("DealershipB", sortedDealerships[1].Name);
            Assert.AreEqual("DealershipC", sortedDealerships[2].Name);
        }

        [Test]
        public void SortDealershipsByNameDescending()
        {
            var data = new List<CarDealership>
            {
                new CarDealership{ Name="DealershipA"},
                new CarDealership{ Name="DealershipC"},
                new CarDealership{ Name="DealershipB"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<CarDealership>>();
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.CarDealerships).Returns(mockSet.Object);

            var service = new CarDealershipBusiness(mockContext.Object);
            var sortedDealerships = service.SortDealershipsByNameDescending();

            Assert.AreEqual("DealershipC", sortedDealerships[0].Name);
            Assert.AreEqual("DealershipB", sortedDealerships[1].Name);
            Assert.AreEqual("DealershipA", sortedDealerships[2].Name);
        }

        [Test]
        public void SortDealershipsByTownNameAscending()
        {
            var data = new List<CarDealership>
            {
                new CarDealership{ Name="DealershipA",Town=new Town{ Name="TownB"} },
                new CarDealership{ Name="DealershipB",Town=new Town{ Name="TownC"} },
                new CarDealership{ Name="DealershipC",Town=new Town{ Name="TownA"} },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<CarDealership>>();
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.CarDealerships).Returns(mockSet.Object);

            var service = new CarDealershipBusiness(mockContext.Object);
            var sortedDealerships = service.SortDealershipsByTownNameAscending();

            Assert.AreEqual("DealershipC", sortedDealerships[0].Name);
            Assert.AreEqual("DealershipA", sortedDealerships[1].Name);
            Assert.AreEqual("DealershipB", sortedDealerships[2].Name);

        }

        [Test]
        public void SortDealershipsByTownNameDescending()
        {
            var data = new List<CarDealership>
            {
                new CarDealership{ Name="DealershipA",Town=new Town{ Name="TownB"} },
                new CarDealership{ Name="DealershipB",Town=new Town{ Name="TownC"} },
                new CarDealership{ Name="DealershipC",Town=new Town{ Name="TownA"} },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<CarDealership>>();
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<CarDealership>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.CarDealerships).Returns(mockSet.Object);

            var service = new CarDealershipBusiness(mockContext.Object);
            var sortedDealerships = service.SortDealershipsByTownNameDescending();

            Assert.AreEqual("DealershipB", sortedDealerships[0].Name);
            Assert.AreEqual("DealershipA", sortedDealerships[1].Name);
            Assert.AreEqual("DealershipC", sortedDealerships[2].Name);

        }
    }
}
