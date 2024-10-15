using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class WorkingWithArrays
    {
        [Test]
        public void TestAssertArrays()
        {
            int[] expected = { 1, 2, 3, 4, 5 };
            int[] actual = { 1, 2 ,3,4,5};
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestContains()
        {
            int[] nos = { 1, 2, 3, 4, 5 };
            //Assert.That(nos, Contains.Item(13));
            Assert.That(nos, Does.Not.Contain(13));

        }


        [Test]
        public void TestEmptyArray()
        {
            int[] nos = { };
            //Assert.That(nos, Is.Empty);
            Assert.That(nos,Is.Not.Empty);
        }


        [Test]
        [TestCase(new int[] {1,23,3})]
        [TestCase(new int[] { 100, 23, 3,3333,322 })]
        public void TestForArrayParameters(int[] arr)
        {

            Assert.That(arr, Is.GreaterThan(0));
        }
    }
}
