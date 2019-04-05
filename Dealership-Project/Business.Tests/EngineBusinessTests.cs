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
    public class EngineBusinessTests
    {
        [Test]
        public void AddEngine()
        {
            var mockSet = new Mock<DbSet<Engine>>();

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            service.Add(new Engine());

            mockSet.Verify(m => m.Add(It.IsAny<Engine>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [Test]
        public void GetAllEngines()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="Engine1"},
                new Engine{ Name="Engine2"},
                new Engine{ Name="Engine3"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EnginesFound = service.GetAllEngines();

            Assert.AreEqual(3, EnginesFound.Count());
            Assert.AreEqual("Engine1", EnginesFound[0].Name);
            Assert.AreEqual("Engine2", EnginesFound[1].Name);
            Assert.AreEqual("Engine3", EnginesFound[2].Name);
        }

        [Test]
        public void GetEnginesByFuelType()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="Engine1",FuelType="Diesel"},
                new Engine{ Name="Engine2",FuelType="Petrol"},
                new Engine{ Name="Engine3",FuelType="Diesel"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EnginesFound = service.GetEnginesByFuelType("Diesel");

            Assert.AreEqual(2, EnginesFound.Count());
            Assert.AreEqual("Engine1", EnginesFound[0].Name);
            Assert.AreEqual("Engine3", EnginesFound[1].Name);
        }

        [Test]
        public void GetEnginesByDisplacement()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="Engine1",Displacement=1900},
                new Engine{ Name="Engine2",Displacement=2700},
                new Engine{ Name="Engine3",Displacement=2700},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EnginesFound = service.GetEnginesByDisplacement(2700);

            Assert.AreEqual(2, EnginesFound.Count());
            Assert.AreEqual("Engine2", EnginesFound[0].Name);
            Assert.AreEqual("Engine3", EnginesFound[1].Name);
        }

        [Test]
        public void GetEnginesByPower()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="Engine1",Power=150},
                new Engine{ Name="Engine2",Power=150},
                new Engine{ Name="Engine3",Power=100},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EnginesFound = service.GetEnginesByPower(150);

            Assert.AreEqual(2, EnginesFound.Count());
            Assert.AreEqual("Engine1", EnginesFound[0].Name);
            Assert.AreEqual("Engine2", EnginesFound[1].Name);
        }

        [Test]
        public void GetEnginesByFuelEconomyPerHundredKm()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="Engine1",EconomyPerHundredKm=3.0M},
                new Engine{ Name="Engine2",EconomyPerHundredKm=10.3M},
                new Engine{ Name="Engine3",EconomyPerHundredKm=3.0M},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EnginesFound = service.GetEnginesByEconomyPerHundredKm(3.0M);

            Assert.AreEqual(2, EnginesFound.Count());
            Assert.AreEqual("Engine1", EnginesFound[0].Name);
            Assert.AreEqual("Engine3", EnginesFound[1].Name);
        }

        [Test]
        public void GetEngineByName()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="Engine1"},
                new Engine{ Name="Engine2"},
                new Engine{ Name="Engine3"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EngineFound = service.GetEngineByName("Engine1");

            Assert.AreEqual("Engine1", EngineFound.Name);
        }

        [Test]
        public void SortEnginesByFuelType()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="Engine1",FuelType="Diesel"},
                new Engine{ Name="Engine2",FuelType="Petrol"},
                new Engine{ Name="Engine3",FuelType="Diesel"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EnginesFound = service.SortEnginesByFuelType();

            Assert.AreEqual(3, EnginesFound.Count());
            Assert.AreEqual("Engine1", EnginesFound[0].Name);
            Assert.AreEqual("Engine3", EnginesFound[1].Name);
            Assert.AreEqual("Engine2", EnginesFound[2].Name);
        }

        [Test]
        public void SortEnginesByDisplacemntAscending()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="Engine1",Displacement=1900},
                new Engine{ Name="Engine2",Displacement=2700},
                new Engine{ Name="Engine3",Displacement=2000},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EnginesFound = service.SortEnginesByDisplacementAscending();

            Assert.AreEqual(3, EnginesFound.Count());
            Assert.AreEqual("Engine1", EnginesFound[0].Name);
            Assert.AreEqual("Engine3", EnginesFound[1].Name);
            Assert.AreEqual("Engine2", EnginesFound[2].Name);
        }

        [Test]
        public void SortEnginesByDisplacemntDescending()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="Engine1",Displacement=1900},
                new Engine{ Name="Engine2",Displacement=2700},
                new Engine{ Name="Engine3",Displacement=2000},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EnginesFound = service.SortEnginesByDisplacementDescending();

            Assert.AreEqual(3, EnginesFound.Count());
            Assert.AreEqual("Engine2", EnginesFound[0].Name);
            Assert.AreEqual("Engine3", EnginesFound[1].Name);
            Assert.AreEqual("Engine1", EnginesFound[2].Name);
        }

        [Test]
        public void SortEnginesByPowerAscending()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="Engine1",Power=130},
                new Engine{ Name="Engine2",Power=150},
                new Engine{ Name="Engine3",Power=100},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EnginesFound = service.SortEnginesByPowerAscending();

            Assert.AreEqual(3, EnginesFound.Count());
            Assert.AreEqual("Engine3", EnginesFound[0].Name);
            Assert.AreEqual("Engine1", EnginesFound[1].Name);
            Assert.AreEqual("Engine2", EnginesFound[2].Name);
        }

        [Test]
        public void SortEnginesByPowerDescending()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="Engine1",Power=130},
                new Engine{ Name="Engine2",Power=150},
                new Engine{ Name="Engine3",Power=100},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EnginesFound = service.SortEnginesByPowerDescending();

            Assert.AreEqual(3, EnginesFound.Count());
            Assert.AreEqual("Engine2", EnginesFound[0].Name);
            Assert.AreEqual("Engine1", EnginesFound[1].Name);
            Assert.AreEqual("Engine3", EnginesFound[2].Name);
        }

        [Test]
        public void SortEnginesByEconomyPerHundredKmAscending()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="Engine1",EconomyPerHundredKm=3.0M},
                new Engine{ Name="Engine2",EconomyPerHundredKm=10.3M},
                new Engine{ Name="Engine3",EconomyPerHundredKm=8.0M},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EnginesFound = service.SortEnginesByEconomyPerHundredKmAscending();

            Assert.AreEqual(3, EnginesFound.Count());
            Assert.AreEqual("Engine1", EnginesFound[0].Name);
            Assert.AreEqual("Engine3", EnginesFound[1].Name);
            Assert.AreEqual("Engine2", EnginesFound[2].Name);
        }

        [Test]
        public void SortEnginesByEconomyPerHundredKmDescending()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="Engine1",EconomyPerHundredKm=3.0M},
                new Engine{ Name="Engine2",EconomyPerHundredKm=10.3M},
                new Engine{ Name="Engine3",EconomyPerHundredKm=8.0M},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EnginesFound = service.SortEnginesByEconomyPerHundredKmDescending();

            Assert.AreEqual(3, EnginesFound.Count());
            Assert.AreEqual("Engine2", EnginesFound[0].Name);
            Assert.AreEqual("Engine3", EnginesFound[1].Name);
            Assert.AreEqual("Engine1", EnginesFound[2].Name);
        }

        [Test]
        public void SortEnginesByNameAscending()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="EngineC"},
                new Engine{ Name="EngineA"},
                new Engine{ Name="EngineB"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EnginesFound = service.SortEnginesByNameAscending();

            Assert.AreEqual(3,EnginesFound.Count());
            Assert.AreEqual("EngineA",EnginesFound[0].Name);
            Assert.AreEqual("EngineB", EnginesFound[1].Name);
            Assert.AreEqual("EngineC", EnginesFound[2].Name);
        }

        [Test]
        public void SortEnginesByNameDescending()
        {
            var data = new List<Engine>
            {
                new Engine{ Name="EngineC"},
                new Engine{ Name="EngineA"},
                new Engine{ Name="EngineB"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Engine>>();
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Engine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Engines).Returns(mockSet.Object);

            var service = new EngineBusiness(mockContext.Object);
            var EnginesFound = service.SortEnginesByNameDescending();

            Assert.AreEqual(3, EnginesFound.Count());
            Assert.AreEqual("EngineC", EnginesFound[0].Name);
            Assert.AreEqual("EngineB", EnginesFound[1].Name);
            Assert.AreEqual("EngineA", EnginesFound[2].Name);
        }
    }
}
