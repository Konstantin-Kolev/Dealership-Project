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
    public class TownBusinessTests
    {
        [Test]
        public void AddTown()
        {
            var mockSet = new Mock<DbSet<Town>>();

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Towns).Returns(mockSet.Object);

            var service = new TownBusiness(mockContext.Object);
            service.Add(new Town());

            mockSet.Verify(m => m.Add(It.IsAny<Town>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [Test]
        public void GetAllTowns()
        {
            var data = new List<Town>
            {
                new Town{ Name="Town1"},
                new Town{ Name="Town2"},
                new Town{ Name="Town3"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Town>>();
            mockSet.As<IQueryable<Town>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Town>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Town>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Town>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Towns).Returns(mockSet.Object);

            var service = new TownBusiness(mockContext.Object);
            var TownsFound = service.GetAllTowns();

            Assert.AreEqual(3, TownsFound.Count());
            Assert.AreEqual("Town1", TownsFound[0].Name);
            Assert.AreEqual("Town2", TownsFound[1].Name);
            Assert.AreEqual("Town3", TownsFound[2].Name);
        }

        [Test]
        public void GetTownByName()
        {
            var data = new List<Town>
            {
                new Town{ Name="Town1"},
                new Town{ Name="Town2"},
                new Town{ Name="Town3"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Town>>();
            mockSet.As<IQueryable<Town>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Town>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Town>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Town>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Towns).Returns(mockSet.Object);

            var service = new TownBusiness(mockContext.Object);
            var TownFound = service.GetTownByName("Town1");

            Assert.AreEqual("Town1", TownFound.Name);
        }

        [Test]
        public void SortTownByNameAscending()
        {
            var data = new List<Town>
            {
                new Town{ Name="TownC"},
                new Town{ Name="TownA"},
                new Town{ Name="TownB"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Town>>();
            mockSet.As<IQueryable<Town>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Town>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Town>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Town>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Towns).Returns(mockSet.Object);

            var service = new TownBusiness(mockContext.Object);
            var TownsFound = service.SortTownsByNameAscending();

            Assert.AreEqual(3, TownsFound.Count());
            Assert.AreEqual("TownA", TownsFound[0].Name);
            Assert.AreEqual("TownB", TownsFound[1].Name);
            Assert.AreEqual("TownC", TownsFound[2].Name);
        }

        [Test]
        public void SortTownByNameDescending()
        {
            var data = new List<Town>
            {
                new Town{ Name="TownC"},
                new Town{ Name="TownA"},
                new Town{ Name="TownB"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Town>>();
            mockSet.As<IQueryable<Town>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Town>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Town>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Town>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Towns).Returns(mockSet.Object);

            var service = new TownBusiness(mockContext.Object);
            var TownsFound = service.SortTownsByNameDescending();

            Assert.AreEqual(3, TownsFound.Count());
            Assert.AreEqual("TownC", TownsFound[0].Name);
            Assert.AreEqual("TownB", TownsFound[1].Name);
            Assert.AreEqual("TownA", TownsFound[2].Name);
        }
    }
}
