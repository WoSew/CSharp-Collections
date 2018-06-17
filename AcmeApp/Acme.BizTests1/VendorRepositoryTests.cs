using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveValueIntTest()
        {
            //arrange
            var repository = new VendorRepository();
            var expected = 42;

            //act
            var actual = repository.RetrieveValue<int>("Select ...", 42);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveValueStringTest()
        {
            //arrange
            var repository = new VendorRepository();
            var expected = "test";

            //act
            var actual = repository.RetrieveValue<string>("Select ...", "test");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveValueOjbectTest()
        {
            //arrange
            var repository = new VendorRepository();
            var vendor = new Vendor();
            var expected = vendor;

            //act
            var actual = repository.RetrieveValue<Vendor>("Select ...", vendor);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveTest()
        {
            //arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>();
            expected.Add(new Vendor() { VendorId = 1, CompanyName = "ABC", Email = "abc@abc.com" });
            expected.Add(new Vendor() { VendorId = 2, CompanyName = "XYZ", Email = "XYZ@abc.com" });

            //act
            var actual = repository.Retrieve();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}