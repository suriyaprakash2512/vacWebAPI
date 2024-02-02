using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
        public class VaccineTest
        {
            public bool vaccineTest(string VaccineName)
            {
                return VaccineName == "Covaxin";
            }

            public bool vaccineTest1(string Manufacturer)
            {
            return Manufacturer == "XYZ";
            }
        }
        [TestFixture]

        public class VacTest
        {
            [Test]
            public void ValidMatchingVacTest()
            {
                var vaccineTest = new VaccineTest();
                bool result = vaccineTest.vaccineTest("Covaxin");
                Assert.IsTrue(result);
            }
            [Test]
            public void InvalidMatchingVacTest()
            {
                var vaccineTest = new VaccineTest();
                bool result = vaccineTest.vaccineTest("Covidshield");
                Assert.IsFalse(result);
            }

             [Test]
            public void ValidMatchingManuTest()
            {
            var vaccineTest = new VaccineTest();
            bool result = vaccineTest.vaccineTest("XYZ");
            Assert.IsTrue(result);

            }

            [Test]
             public void InvalidMatchingManuTest()
            {
            var vaccineTest = new VaccineTest();
            bool result = vaccineTest.vaccineTest("123456");
            Assert.IsFalse(result);

            }



    }

    }

