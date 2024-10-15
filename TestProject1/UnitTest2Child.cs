
using Microsoft.VisualStudio.TestPlatform.TestHost;
namespace TestProject1
{
    [TestFixture]
    public class UnitTest2Child:TestsForEmployeesOperationsBasic
    {
        [Test]
        [TestCase("hello",5)]
        [TestCase("",0)]
        public void TestLengthOfString(string s, int expected)
        { 
        Assert.AreEqual(expected, s.Length);
        }

        //[Ignore("")]
        [TestCase(0)]
        [TestCase(100)]
        public void TestForFindEmployeeDetails(int id)
        {
            if (id == 0)
            {
                string id1 = "ID cannot be zero";
                Assert.AreEqual(id1, "ID cannot be zero");
            }
            else
            {
                base.TestForFindEmployeeDetails(id);
            }
        }
    }
}
