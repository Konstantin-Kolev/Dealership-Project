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
    public class CarBusinessTests
    {
        [Test]
        public void AddCar()
        {
            var mockSet = new Mock<DbSet<Car>>();

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            service.Add(new Car());

            mockSet.Verify(m => m.Add(It.IsAny<Car>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [Test]
        public void GetAllCars()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1"},
                new Car{ Model="Car2"},
                new Car{ Model="Car3"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetAllCars();

            Assert.AreEqual(3, CarsFound.Count());
            Assert.AreEqual("Car1", CarsFound[0].Model);
            Assert.AreEqual("Car2", CarsFound[1].Model);
            Assert.AreEqual("Car3", CarsFound[2].Model);
        }

        [Test]
        public void GetCarsByManufacturer()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1",Manufacturer="ManufacturerA"},
                new Car{ Model="Car2",Manufacturer="ManufacturerB"},
                new Car{ Model="Car3",Manufacturer="Man" +
                "ufacturerA"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsByManufacturer("ManufacturerA");

            Assert.AreEqual(2, CarsFound.Count());
            Assert.AreEqual("Car1", CarsFound[0].Model);
            Assert.AreEqual("Car3", CarsFound[1].Model);
        }

        [Test]
        public void GetCarsByModel()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1"},
                new Car{ Model="Car2"},
                new Car{ Model="Car2"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsByModel("Car2");

            Assert.AreEqual(2, CarsFound.Count());
            Assert.AreEqual("Car2", CarsFound[0].Model);
            Assert.AreEqual("Car2", CarsFound[1].Model);
        }

        [Test]
        public void GetCarsByColor()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1",Color="Black"},
                new Car{ Model="Car2",Color="Black"},
                new Car{ Model="Car3",Color="White"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsByColor("Black");

            Assert.AreEqual(2, CarsFound.Count());
            Assert.AreEqual("Car1", CarsFound[0].Model);
            Assert.AreEqual("Car2", CarsFound[1].Model);
        }

        [Test]
        public void GetCarsByTransmitionType()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1",TransmissionType="Manual"},
                new Car{ Model="Car2",TransmissionType="Automatic"},
                new Car{ Model="Car3",TransmissionType="Manual"},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsByTransmissionType("Manual");

            Assert.AreEqual(2, CarsFound.Count());
            Assert.AreEqual("Car1", CarsFound[0].Model);
            Assert.AreEqual("Car3", CarsFound[1].Model);
        }

        [Test]
        public void GetCarsByPrice()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1",Price=5500M},
                new Car{ Model="Car2",Price=5000M},
                new Car{ Model="Car3",Price=5500M},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsByPrice(5500M);

            Assert.AreEqual(2, CarsFound.Count());
            Assert.AreEqual("Car1", CarsFound[0].Model);
            Assert.AreEqual("Car3", CarsFound[1].Model);
        }

        [Test]
        public void GetCarsWithLowerPrice()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1",Price=5500M},
                new Car{ Model="Car2",Price=5300M},
                new Car{ Model="Car3",Price=5000M},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsWithLowerPrice(5400M);

            Assert.AreEqual(2, CarsFound.Count());
            Assert.AreEqual("Car2", CarsFound[0].Model);
            Assert.AreEqual("Car3", CarsFound[1].Model);
        }

        [Test]
        public void GetCarsWithHigherPrice()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1",Price=5500M},
                new Car{ Model="Car2",Price=5300M},
                new Car{ Model="Car3",Price=5000M},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsWithHigherPrice(5200M);

            Assert.AreEqual(2, CarsFound.Count());
            Assert.AreEqual("Car1", CarsFound[0].Model);
            Assert.AreEqual("Car2", CarsFound[1].Model);
        }

        [Test]
        public void GetCarsByTransmitionGears()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1",TransmissionGears=6},
                new Car{ Model="Car2",TransmissionGears=6},
                new Car{ Model="Car3",TransmissionGears=5},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsByTransmissionGears(6);

            Assert.AreEqual(2, CarsFound.Count());
            Assert.AreEqual("Car1", CarsFound[0].Model);
            Assert.AreEqual("Car2", CarsFound[1].Model);
        }

        [Test]
        public void GetCarsByPower()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1",Engine=new Engine{ Power=100} },
                new Car{ Model="Car2",Engine=new Engine{ Power=100} },
                new Car{ Model="Car3",Engine=new Engine{ Power=150} },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsByPower(100);

            Assert.AreEqual(2, CarsFound.Count());
            Assert.AreEqual("Car1", CarsFound[0].Model);
            Assert.AreEqual("Car2", CarsFound[1].Model);
        }

        [Test]
        public void GetCarsWithLowerPower()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1",Engine=new Engine{ Power=100} },
                new Car{ Model="Car2",Engine=new Engine{ Power=120} },
                new Car{ Model="Car3",Engine=new Engine{ Power=150} },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsWithLowerPower(130);

            Assert.AreEqual(2, CarsFound.Count());
            Assert.AreEqual("Car1", CarsFound[0].Model);
            Assert.AreEqual("Car2", CarsFound[1].Model);
        }

        [Test]
        public void GetCarsWithHigherPower()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1",Engine=new Engine{ Power=100} },
                new Car{ Model="Car2",Engine=new Engine{ Power=120} },
                new Car{ Model="Car3",Engine=new Engine{ Power=150} },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsWithHigherPower(110);

            Assert.AreEqual(2, CarsFound.Count());
            Assert.AreEqual("Car2", CarsFound[0].Model);
            Assert.AreEqual("Car3", CarsFound[1].Model);
        }

        [Test]
        public void GetCarsByDisplacement()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1",Engine=new Engine{ Displacement=1900} },
                new Car{ Model="Car2",Engine=new Engine{ Displacement=1900} },
                new Car{ Model="Car3",Engine=new Engine{ Displacement=2700} },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsByDisplacement(1900);

            Assert.AreEqual(2, CarsFound.Count());
            Assert.AreEqual("Car1", CarsFound[0].Model);
            Assert.AreEqual("Car2", CarsFound[1].Model);
        }

        [Test]
        public void GetCarsWithLowerDisplacement()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1",Engine=new Engine{ Displacement=1900} },
                new Car{ Model="Car2",Engine=new Engine{ Displacement=1800} },
                new Car{ Model="Car3",Engine=new Engine{ Displacement=2700} },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsWithLowerDisplacement(2000);

            Assert.AreEqual(2, CarsFound.Count());
            Assert.AreEqual("Car1", CarsFound[0].Model);
            Assert.AreEqual("Car2", CarsFound[1].Model);
        }

        [Test]

        public void GetCarsWithHigherDisplacement()
        {
            var data = new List<Car>
            {
                new Car{ Model="Car1",Engine=new Engine{ Displacement=1900} },
                new Car{ Model="Car2",Engine=new Engine{ Displacement=1800} },
                new Car{ Model="Car3",Engine=new Engine{ Displacement=2700} },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsWithHigherDisplacement(2000);

            Assert.AreEqual(1, CarsFound.Count());
            Assert.AreEqual("Car3", CarsFound[0].Model);
        }
    }
}
