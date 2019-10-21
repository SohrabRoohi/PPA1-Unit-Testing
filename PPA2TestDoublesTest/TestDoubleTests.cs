using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPA1;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model;
using Moq;

namespace PPA1Tests
{
    
    [TestClass]
    public class TestDoubleTests
    {
        Functions f = new PPA1.Functions();

        [TestMethod]
        public void BMIStubCountTestA()
        {
            var mockSet = new Mock<DbSet<BMILog>>();
            var mockContext = new Mock<LogContext>();
            mockContext.Setup(m => m.BMILogs).Returns(mockSet.Object);
            f.BMI(5, 11, 123, mockContext.Object);
            mockSet.Verify(m => m.Add(It.IsAny<BMILog>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void BMIStubCountTestB()
        {
            var mockSet = new Mock<DbSet<BMILog>>();
            var mockContext = new Mock<LogContext>();
            mockContext.Setup(m => m.BMILogs).Returns(mockSet.Object);
            f.BMI(5, 11, 123, mockContext.Object);
            f.BMI(5, 11, 123, mockContext.Object);
            f.BMI(5, 11, 123, mockContext.Object);
            mockSet.Verify(m => m.Add(It.IsAny<BMILog>()), Times.Exactly(3));
            mockContext.Verify(m => m.SaveChanges(), Times.Exactly(3)); ;
        }

        [TestMethod]
        public void BMIMockResultTest()
        {
            List<BMILog> source = new List<BMILog>();
            var data = source.AsQueryable();
            var mockSet = new Mock<DbSet<BMILog>>();
            mockSet.As<IQueryable<BMILog>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<BMILog>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<BMILog>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<BMILog>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            mockSet.Setup(m => m.Add(It.IsAny<BMILog>())).Callback<BMILog>((s) => source.Add(s));
            var mockContext = new Mock<LogContext>();
            mockContext.Setup(c => c.BMILogs).Returns(mockSet.Object);
            f.BMI(5, 11, 123, mockContext.Object);
            Assert.AreEqual("17.57 Underweight", source[0].result);
        }

        [TestMethod]
        public void BMIMockCountTest()
        {
            List<BMILog> source = new List<BMILog>();
            var data = source.AsQueryable();
            var mockSet = new Mock<DbSet<BMILog>>();
            mockSet.As<IQueryable<BMILog>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<BMILog>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<BMILog>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<BMILog>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            mockSet.Setup(m => m.Add(It.IsAny<BMILog>())).Callback<BMILog>((s) => source.Add(s));
            var mockContext = new Mock<LogContext>();
            mockContext.Setup(c => c.BMILogs).Returns(mockSet.Object);
            f.BMI(5, 11, 123, mockContext.Object);
            f.BMI(5, 3, 110, mockContext.Object);
            f.BMI(6, 3, 200, mockContext.Object);
            f.BMI(4, 8, 95, mockContext.Object);
            Assert.AreEqual(4, source.Count);
        }

        [TestMethod]
        public void BMIInMemoryTestA()
        {
            LogContext db = new LogContext(new DbContextOptionsBuilder<LogContext>()
                .UseInMemoryDatabase(databaseName: "BMIA")
                .Options);
            f.BMI(5, 11, 123, db);
            BMILog result = db.BMILogs.ToList()[0];
            Assert.AreEqual("17.57 Underweight", result.result);
        }

        [TestMethod]
        public void BMIInMemoryTestB()
        {
            LogContext db = new LogContext(new DbContextOptionsBuilder<LogContext>()
                .UseInMemoryDatabase(databaseName: "BMIB")
                .Options);
            f.BMI(5, 11, 123, db);
            f.BMI(5, 3, 110, db);
            f.BMI(6, 3, 200, db);
            f.BMI(4, 8, 95, db);
            Assert.AreEqual(4, db.BMILogs.Count());
        }

        [TestMethod]
        public void DistanceStubCountTestA()
        {
            var mockSet = new Mock<DbSet<DistanceLog>>();
            var mockContext = new Mock<LogContext>();
            mockContext.Setup(m => m.DistanceLogs).Returns(mockSet.Object);
            f.Distance(1, 0, 2, 0, mockContext.Object);
            mockSet.Verify(m => m.Add(It.IsAny<DistanceLog>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void DistanceStubCountTestB()
        {
            var mockSet = new Mock<DbSet<DistanceLog>>();
            var mockContext = new Mock<LogContext>();
            mockContext.Setup(m => m.DistanceLogs).Returns(mockSet.Object);
            f.Distance(1, 0, 2, 0, mockContext.Object);
            f.Distance(1, 0, 2, 0, mockContext.Object);
            f.Distance(1, 0, 2, 0, mockContext.Object);
            mockSet.Verify(m => m.Add(It.IsAny<DistanceLog>()), Times.Exactly(3));
            mockContext.Verify(m => m.SaveChanges(), Times.Exactly(3)); ;
        }

        [TestMethod]
        public void DistanceMockResultTest()
        {
            List<DistanceLog> source = new List<DistanceLog>();
            var data = source.AsQueryable();
            var mockSet = new Mock<DbSet<DistanceLog>>();
            mockSet.As<IQueryable<DistanceLog>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<DistanceLog>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<DistanceLog>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<DistanceLog>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            mockSet.Setup(m => m.Add(It.IsAny<DistanceLog>())).Callback<DistanceLog>((s) => source.Add(s));
            var mockContext = new Mock<LogContext>();
            mockContext.Setup(c => c.DistanceLogs).Returns(mockSet.Object);
            f.Distance(1, 0, 2, 0, mockContext.Object);
            Assert.AreEqual(1.00, source[0].result);
        }

        [TestMethod]
        public void DistanceMockCountTest()
        {
            List<DistanceLog> source = new List<DistanceLog>();
            var data = source.AsQueryable();
            var mockSet = new Mock<DbSet<DistanceLog>>();
            mockSet.As<IQueryable<DistanceLog>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<DistanceLog>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<DistanceLog>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<DistanceLog>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            mockSet.Setup(m => m.Add(It.IsAny<DistanceLog>())).Callback<DistanceLog>((s) => source.Add(s));
            var mockContext = new Mock<LogContext>();
            mockContext.Setup(c => c.DistanceLogs).Returns(mockSet.Object);
            f.Distance(1, 0, 2, 0, mockContext.Object);
            f.Distance(100, 5, 200, -20, mockContext.Object);
            f.Distance(1e9, -1e5, 1e6, 1e7, mockContext.Object);
            Assert.AreEqual(3, source.Count);
        }

        [TestMethod]
        public void DistanceInMemoryTestA()
        {
            LogContext db = new LogContext(new DbContextOptionsBuilder<LogContext>()
                .UseInMemoryDatabase(databaseName: "DistanceA")
                .Options);
            f.Distance(1, 0, 2, 0, db);
            DistanceLog result = db.DistanceLogs.ToList()[0];
            Assert.AreEqual(1.00, result.result);
        }

        [TestMethod]
        public void DistanceInMemoryTestB()
        {
            LogContext db = new LogContext(new DbContextOptionsBuilder<LogContext>()
                .UseInMemoryDatabase(databaseName: "DistanceB")
                .Options);
            f.Distance(1, 0, 2, 0, db);
            f.Distance(100, 5, 200, -20, db);
            f.Distance(1e9, -1e5, 1e6, 1e7, db);
            Assert.AreEqual(3, db.DistanceLogs.Count());
        }
    }
}
