
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1
{
    [TestFixture]
    public class TestsForEmployeesOperations
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        //[Test]
        //public void TestForAdminLogin()
        //{
        //    EmployeesOperations op=new EmployeesOperations();
        //    string admintest = op.Login("Admin", "Admin");
        //    Assert.AreEqual(admintest, "Welcome Admin");

        //}
        //[Test]
        //public void TestForLoginWithWrongUserIDandPassword()
        //{
        //    EmployeesOperations op = new EmployeesOperations();
        //    string testForUserGauri = op.Login("Gauri", "Gauri234");
        //    Assert.AreEqual(testForUserGauri, "Incorrect userid/password");


        //}


        //[Test]
        //public void TestForLoginWithEmptyUSerIDPassword()
        //{
        //    EmployeesOperations op = new EmployeesOperations();
        //    string testForEmpty = op.Login("", "");
        //    Assert.AreEqual(testForEmpty, "Userid or password cannot be empty or null");


        //}

        [Test]
        public void TestForLogin()
        { 
        Program p=new Program();
            string wrongUseridPassword=p.CheckLogin("Ajit", "Ajit");
            string correctUseridPassword = p.CheckLogin("Admin", "Admin");
            string isemptydata = p.CheckLogin("", "");

            Assert.AreEqual(correctUseridPassword, "Welcome Admin");
            Assert.AreEqual(wrongUseridPassword, "Incorrect userid/password");
            Assert.AreEqual(isemptydata, "Userid or password cannot be empty or null");

        }




    }
}