using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPA1;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model;
using Moq;
using WebAPI.Controllers;
using WebAPI.Model;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace PPA1Tests
{
    
    [TestClass]
    public class APITests
    {
        Functions f = new PPA1.Functions();

        [TestMethod]
        public void BMIAPIPostTest()
        {
            LogContext db = new LogContext(new DbContextOptionsBuilder<LogContext>()
                .UseInMemoryDatabase(databaseName: "BMIPost")
                .Options);
            BMIController MockBMIAPI = new BMIController(db);
            BMIModel input = new BMIModel(5, 11, 123);
            var response = MockBMIAPI.Post(input) as ObjectResult;
            Assert.AreEqual(StatusCodes.Status200OK, response.StatusCode);
        }

        [TestMethod]
        public void BMIAPIGetTest()
        {
            LogContext db = new LogContext(new DbContextOptionsBuilder<LogContext>()
                .UseInMemoryDatabase(databaseName: "BMIGet")
                .Options);
            BMIController MockBMIAPI = new BMIController(db);
            var response = MockBMIAPI.Get() as ObjectResult;
            Assert.AreEqual(StatusCodes.Status200OK, response.StatusCode);
        }

        [TestMethod]
        public void DistanceAPIPostTest()
        {
            LogContext db = new LogContext(new DbContextOptionsBuilder<LogContext>()
                .UseInMemoryDatabase(databaseName: "BMIPost")
                .Options);
            DistanceController MockDistanceAPI = new DistanceController(db);
            DistanceModel input = new DistanceModel(1, 0, 2, 0);
            var response = MockDistanceAPI.Post(input) as ObjectResult;
            Assert.AreEqual(StatusCodes.Status200OK, response.StatusCode);
        }

        [TestMethod]
        public void DistanceAPIGetTest()
        {
            LogContext db = new LogContext(new DbContextOptionsBuilder<LogContext>()
                .UseInMemoryDatabase(databaseName: "BMIGet")
                .Options);
            DistanceController MockDistanceAPI = new DistanceController(db);
            var response = MockDistanceAPI.Get() as ObjectResult;
            Assert.AreEqual(StatusCodes.Status200OK, response.StatusCode);
        }
    }
}
