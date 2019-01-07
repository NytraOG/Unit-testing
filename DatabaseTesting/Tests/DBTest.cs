using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class DBTest
    {
        [TestMethod]
        public void ArrayLengthTest()
        {
            // Arrange
            var dbArrayLengthExpected = 16;

            // Act
            var dBinit = new Database();
            var dbArrayLengthActual = dBinit.DbArray.Length;

            // Assert
            Assert.AreEqual(dbArrayLengthExpected, dbArrayLengthActual);
        }

        [TestMethod]
        public void TestAddMethod()
        {
            // Arrange
            var dbInit = new Database();

            // Act
            dbInit.Add();

            // Assert
            Assert.ThrowsException<InvalidOperationException>(null);
        }

        [TestMethod]
        public void TestRemoveMethod()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
