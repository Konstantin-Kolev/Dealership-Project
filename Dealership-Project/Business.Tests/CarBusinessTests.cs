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

        [Test]
        public void GetCarsByFuelType()
        {
            var data = new List<Car>
            {
                new Car{Model = "Car1", Engine = new Engine {FuelType = "Diesel" } },
                new Car{Model = "Car2", Engine = new Engine {FuelType = "Gasoline"} },
                new Car{Model = "Car3", Engine = new Engine {FuelType = "Electricity"} },
                new Car{Model = "Car4", Engine = new Engine {FuelType = "Diesel" } }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var CarsFound = service.GetCarsByFuelType("Diesel");

            Assert.AreEqual(2, CarsFound.Count());
            Assert.AreEqual("Car1", CarsFound[0].Model);
            Assert.AreEqual("Car4", CarsFound[1].Model);
        }

        [Test]
        public void SortCarsByPowerAscending()
        {
            var data = new List<Car>
            {
                new Car{Engine = new Engine {Power = 100}},
                new Car{Engine = new Engine {Power = 120}},
                new Car{Engine = new Engine {Power = 140}}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByPowerAscending();

            Assert.AreEqual(100, SortedCars[0].Engine.Power);
            Assert.AreEqual(120, SortedCars[1].Engine.Power);
            Assert.AreEqual(140, SortedCars[2].Engine.Power);
        }

        [Test]
        public void SortCarsByPowerDescending()
        {
            var data = new List<Car>
            {
                new Car{Engine = new Engine {Power = 100}},
                new Car{Engine = new Engine {Power = 120}},
                new Car{Engine = new Engine {Power = 140}}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByPowerDescending();

            Assert.AreEqual(140, SortedCars[0].Engine.Power);
            Assert.AreEqual(120, SortedCars[1].Engine.Power);
            Assert.AreEqual(100, SortedCars[2].Engine.Power);
        }

        [Test]
        public void SortCarsByFuelEconomyAscending()
        {
            var data = new List<Car>
            {
                new Car{Engine = new Engine {EconomyPerHundredKm = 5m}},
                new Car{Engine = new Engine {EconomyPerHundredKm = 6m}},
                new Car{Engine = new Engine {EconomyPerHundredKm = 7m}}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByFuelEconomyAscending();

            Assert.AreEqual(5m, SortedCars[0].Engine.EconomyPerHundredKm);
            Assert.AreEqual(6m, SortedCars[1].Engine.EconomyPerHundredKm);
            Assert.AreEqual(7m, SortedCars[2].Engine.EconomyPerHundredKm);
        }

        [Test]
        public void SortCarsByFuelEconomyDescending()
        {
            var data = new List<Car>
            {
                new Car{Engine = new Engine {EconomyPerHundredKm = 5m}},
                new Car{Engine = new Engine {EconomyPerHundredKm = 6m}},
                new Car{Engine = new Engine {EconomyPerHundredKm = 7m}}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByFuelEconomyDescending();

            Assert.AreEqual(7m, SortedCars[0].Engine.EconomyPerHundredKm);
            Assert.AreEqual(6m, SortedCars[1].Engine.EconomyPerHundredKm);
            Assert.AreEqual(5m, SortedCars[2].Engine.EconomyPerHundredKm);
        }

        [Test]
        public void SortCarsByFuelType()
        {
            var data = new List<Car>
            {
                new Car{Model = "Car1", Engine = new Engine {FuelType = "Diesel" } },
                new Car{Model = "Car2", Engine = new Engine {FuelType = "Gasoline"} },
                new Car{Model = "Car3", Engine = new Engine {FuelType = "Electricity"} },

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByFuelType();

            Assert.AreEqual("Diesel", SortedCars[0].Engine.FuelType);
            Assert.AreEqual("Electricity", SortedCars[1].Engine.FuelType);
            Assert.AreEqual("Gasoline", SortedCars[2].Engine.FuelType);
        }

        [Test]
        public void SortCarsByDisplacementAscending()
        {
            var data = new List<Car>
            {
                new Car{Model = "Car1", Engine = new Engine {Displacement = 1900 } },
                new Car{Model = "Car2", Engine = new Engine {Displacement = 2000} },
                new Car{Model = "Car3", Engine = new Engine {Displacement = 2700} },

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByDisplacementAscending();

            Assert.AreEqual(1900, SortedCars[0].Engine.Displacement);
            Assert.AreEqual(2000, SortedCars[1].Engine.Displacement);
            Assert.AreEqual(2700, SortedCars[2].Engine.Displacement);
        }

        [Test]
        public void SortCarsByDisplacementDescending()
        {
            var data = new List<Car>
            {
                new Car{Model = "Car1", Engine = new Engine {Displacement = 1900 } },
                new Car{Model = "Car2", Engine = new Engine {Displacement = 2000} },
                new Car{Model = "Car3", Engine = new Engine {Displacement = 2700} },

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByDisplacementDescending();

            Assert.AreEqual(2700, SortedCars[0].Engine.Displacement);
            Assert.AreEqual(2000, SortedCars[1].Engine.Displacement);
            Assert.AreEqual(1900, SortedCars[2].Engine.Displacement);
        }

        [Test]
        public void SortCarsByTransmissionType()
        {
            var data = new List<Car>
            {
                new Car{Model = "Car1", TransmissionType = "manual" },
                new Car{Model = "Car2", TransmissionType = "automatic" },
                new Car{Model = "Car3", TransmissionType = "DSG" },

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByTransmissionType();

            Assert.AreEqual("automatic", SortedCars[0].TransmissionType);
            Assert.AreEqual("DSG", SortedCars[1].TransmissionType);
            Assert.AreEqual("manual", SortedCars[2].TransmissionType);
        }

        [Test]
        public void SortCarsByTransmissionGearsAscending()
        {
            var data = new List<Car>
            {
                new Car{Model = "Car1", TransmissionGears = 5 },
                new Car{Model = "Car2", TransmissionGears = 6 },
                new Car{Model = "Car3", TransmissionGears = 7 },

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByTransmissionGearsAscending();

            Assert.AreEqual(5, SortedCars[0].TransmissionGears);
            Assert.AreEqual(6, SortedCars[1].TransmissionGears);
            Assert.AreEqual(7, SortedCars[2].TransmissionGears);
        }

        [Test]
        public void SortCarsByTransmissionGearsDescending()
        {
            var data = new List<Car>
            {
                new Car{Model = "Car1", TransmissionGears = 5 },
                new Car{Model = "Car2", TransmissionGears = 6 },
                new Car{Model = "Car3", TransmissionGears = 7 },

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByTransmissionGearsDescending();

            Assert.AreEqual(7, SortedCars[0].TransmissionGears);
            Assert.AreEqual(6, SortedCars[1].TransmissionGears);
            Assert.AreEqual(5, SortedCars[2].TransmissionGears);
        }

        [Test]
        public void SortCarsByColor()
        {
            var data = new List<Car>
            {
                new Car{Model = "Car1", Color = "red" },
                new Car{Model = "Car2", Color = "blue" },
                new Car{Model = "Car3", Color = "green" },

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByColor();

            Assert.AreEqual("blue", SortedCars[0].Color);
            Assert.AreEqual("green", SortedCars[1].Color);
            Assert.AreEqual("red", SortedCars[2].Color);
        }

        [Test]
        public void SortCarsByPriceAscending()
        {
            var data = new List<Car>
            {
                new Car{Model = "Car1", Price = 5000m },
                new Car{Model = "Car2", Price = 6000m },
                new Car{Model = "Car3", Price = 7000m },

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByPriceAscending();

            Assert.AreEqual(5000m, SortedCars[0].Price);
            Assert.AreEqual(6000m, SortedCars[1].Price);
            Assert.AreEqual(7000m, SortedCars[2].Price);
        }

        [Test]
        public void SortCarsByPriceDescending()
        {
            var data = new List<Car>
            {
                new Car{Model = "Car1", Price = 5000m },
                new Car{Model = "Car2", Price = 6000m },
                new Car{Model = "Car3", Price = 7000m },

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByPriceDescending();

            Assert.AreEqual(7000m, SortedCars[0].Price);
            Assert.AreEqual(6000m, SortedCars[1].Price);
            Assert.AreEqual(5000m, SortedCars[2].Price);
        }

        [Test]
        public void SortCarsByManufacturerAndModelAscending()
        {
            var data = new List<Car>
            {
                new Car{Manufacturer = "ManufacturerA" , Model = "CarA" },
                new Car{Manufacturer = "ManufacturerB" , Model = "CarB" },
                new Car{Manufacturer = "ManufacturerB", Model = "CarA",},

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByManufacturerAndModelAscending();

            Assert.AreEqual("ManufacturerA", SortedCars[0].Manufacturer);
            Assert.AreEqual("ManufacturerB", SortedCars[1].Manufacturer);
            Assert.AreEqual("ManufacturerB", SortedCars[2].Manufacturer);
            Assert.AreEqual("CarB", SortedCars[2].Model);
        }

        [Test]
        public void SortCarsByManufacturerAndModelDescending()
        {
            var data = new List<Car>
            {
                new Car{Manufacturer = "ManufacturerA" , Model = "CarA" },
                new Car{Manufacturer = "ManufacturerB" , Model = "CarB" },
                new Car{Manufacturer = "ManufacturerB", Model = "CarA",},

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByManufacturerAndModelDescending();

            Assert.AreEqual("ManufacturerB", SortedCars[0].Manufacturer);
            Assert.AreEqual("ManufacturerB", SortedCars[1].Manufacturer);
            Assert.AreEqual("ManufacturerA", SortedCars[2].Manufacturer);
            Assert.AreEqual("CarB", SortedCars[0].Model);
        }

        [Test]
        public void SortCarsByDealershipNameAscending()
        {
            var data = new List<Car>
            {
                new Car{Model = "Car1",CarDealership =new CarDealership{Name = "NameA"} },
                new Car{Model = "Car2",CarDealership =new CarDealership{Name = "NameB"} },
                new Car{Model = "Car3",CarDealership =new CarDealership{Name = "NameC"} },

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByDealershipNameAscending();

            Assert.AreEqual("NameA", SortedCars[0].CarDealership.Name);
            Assert.AreEqual("NameB", SortedCars[1].CarDealership.Name);
            Assert.AreEqual("NameC", SortedCars[2].CarDealership.Name);          
        }

        [Test]
        public void SortCarsByDealershipNameDescending()
        {
            var data = new List<Car>
            {
                new Car{Model = "Car1",CarDealership =new CarDealership{Name = "NameA"} },
                new Car{Model = "Car2",CarDealership =new CarDealership{Name = "NameB"} },
                new Car{Model = "Car3",CarDealership =new CarDealership{Name = "NameC"} },

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.Cars).Returns(mockSet.Object);

            var service = new CarBusiness(mockContext.Object);
            var SortedCars = service.SortCarsByDealershipNameDescending();

            Assert.AreEqual("NameC", SortedCars[0].CarDealership.Name);
            Assert.AreEqual("NameB", SortedCars[1].CarDealership.Name);
            Assert.AreEqual("NameA", SortedCars[2].CarDealership.Name);
        }
    }
}
