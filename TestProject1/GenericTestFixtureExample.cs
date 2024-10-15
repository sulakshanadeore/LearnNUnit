using NUnit.Framework;

namespace TestProject1
{

    public class GenericTestFixtureExample<T> where T : class
    {


    }
    [TestFixture(typeof(Program))]
    public class MyClassTest<T> where T : Program, new()
    {
        [Test]
        public void TestLogin()
        {

            T pobj = new T();
            string wrongUseridPassword = pobj.CheckLogin("Ajit", "Ajit");
            string correctUseridPassword = pobj.CheckLogin("Admin", "Admin");
            string isemptydata = pobj.CheckLogin("", "");

            Assert.AreEqual(correctUseridPassword, "Welcome Admin");
            Assert.AreEqual(wrongUseridPassword, "Incorrect userid/password");
            Assert.AreEqual(isemptydata, "Userid or password cannot be empty or null");
        }

    }

}
