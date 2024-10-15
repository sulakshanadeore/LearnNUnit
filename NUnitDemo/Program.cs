using HRLibrary;
using System.Xml;

public class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("enter userid");
        //string userid = Console.ReadLine();
        //Console.WriteLine("enter password");
        //string password = Console.ReadLine();
        //Program p=new Program();
        //string status=p.CheckLogin(userid,password);
        //Console.WriteLine(status);

        //Console.WriteLine("Enter id you want to find");
        //int idToFind=Convert.ToInt32(Console.ReadLine());   
        //string data=p.FindEmpByID(idToFind);
        //Console.WriteLine(data);
        //    couriercompany couriercompany = new couriercompany();
        //    couriercompany.CompanyName = "Tej";
        //    List<Courier> couriersListForTej = new List<Courier>()
        //    {
        //    new Courier(1,"Amit","Sumit","Pune","Mumbai",340f,"Pending",11,new DateTime(2024,11,07),1),
        //    new Courier(2,"Tina","Mina","Pune","Mumbai",340f,"Pending",11,new DateTime(2024,11,07),2),
        //    new Courier(3,"Amita","Sunita","Pune","Mumbai",340f,"Pending",11,new DateTime(2024,11,07),2)
        //    };
        //    couriercompany.couriers = couriersListForTej;


        //    couriercompany couriercompany1 = new couriercompany();
        //    couriercompany.CompanyName = "Fast Track";
        //    List<Courier> couriersListForfastTrack = new List<Courier>()
        //    {
        //    new Courier(1,"Amit","Sumit","Pune","Mumbai",340f,"Pending",11,new DateTime(2024,11,07),1),
        //    new Courier(2,"Tina","Mina","Pune","Mumbai",340f,"Delivered",12,new DateTime(2024,11,07),2),
        //    new Courier(3,"Amita","Sunita","Pune","Mumbai",340f,"Pending",11,new DateTime(2024,11,07),2)
        //    };
        //    couriercompany1.couriers = couriersListForfastTrack;




        //List<CourierCompanyCollection> companyBranches = 
        //        new List<CourierCompanyCollection>();
        //    CourierCompanyCollection c1 = 
        //        new CourierCompanyCollection(couriercompany);
        //    CourierCompanyCollection c2 = 
        //        new CourierCompanyCollection(couriercompany1);


        //    for (int i = 0; i < couriersListForfastTrack.Count; i++) {
        //       CourierCompanyCollection? detailsFound= companyBranches.Find(c => c.couriercompanies[i].CompanyName == "Fast Track");
        //        if (detailsFound != null) {
        //            detailsFound.couriercompanies[i].CompanyName = "First Flight";


        //        }
        //            }

        string genPass = null;
        for (int i = 0; i < 4; i++)
        {
             genPass += GenString();

        }
     

        Console.WriteLine(genPass);









        Console.ReadLine();

    }
    private static string GenString()
    {
        Random r = new Random();
        Random r1 = new Random();
        int min = r1.Next();
        char firstchar = (char)('a' + r.Next());
        string s = firstchar.ToString().ToLower();
       
        int max = r1.Next(1);
        int num=r.Next(max,min);
        char secondchar = (char)(r.Next(num));
        s += secondchar.ToString().ToUpper();
        return s;
    }

    public string FindEmpByID(int id)
    { 
    EmployeesOperations obj=new EmployeesOperations();

        string detailsOfEmp=null;
        try
        {

        
        EmployeeDetails details=obj.GetEmployee(id);
         detailsOfEmp=string.Concat(details.id,details.Name,details.Gender,details.Salary);
         
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        return detailsOfEmp;

    }

    public  string CheckLogin(string userid,string password)
    {
        

        EmployeesOperations employeesOperations = new EmployeesOperations();
        string status = employeesOperations.Login(userid, password);
        return status;
    }
}