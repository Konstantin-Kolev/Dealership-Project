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
        public void CreateCarDealership()
        {
            var mockSet = new Mock<DbSet<CarDealership>>();

            var mockContext = new Mock<CarDealershipContext>();
            mockContext.Setup(m => m.CarDealerships).Returns(mockSet.Object);

            var service = new CarDealershipBusiness(mockContext.Object);
            service.Add(new CarDealership());

            mockSet.Verify(m => m.Add(It.IsAny<CarDealership>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}
