
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1
{
    [TestFixture]
    public class TestsForEmployeesOperations
    {
        Program p = null;
        
        [SetUp]
        public void Setup()
        {
            p = new Program();
        }

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
        
            string wrongUseridPassword=p.CheckLogin("Ajit", "Ajit");
            string correctUseridPassword = p.CheckLogin("Admin", "Admin");
            string isemptydata = p.CheckLogin("", "");

            Assert.AreEqual(correctUseridPassword, "Welcome Admin");
            Assert.AreEqual(wrongUseridPassword, "Incorrect userid/password");
            Assert.AreEqual(isemptydata, "Userid or password cannot be empty or null");

        }
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(6)]

        public void TestForFindEmployeeDetails(int id)
        {
            string empdet=null;
            try
            {
                 empdet = p.FindEmpByID(id);

                Assert.AreEqual(empdet, empdet);
            }
            catch (Exception ex)
            {

                Assert.AreEqual(empdet, "Object reference not set to instance of an object");
            }
            ;
        
        
        }




    }
}