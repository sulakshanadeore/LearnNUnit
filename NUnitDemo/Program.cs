using HRLibrary;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter userid");
        string userid = Console.ReadLine();
        Console.WriteLine("enter password");
        string password = Console.ReadLine();
        Program p=new Program();
        string status=p.CheckLogin(userid,password);
        Console.WriteLine(status);

        Console.WriteLine("Enter id you want to find");
        int idToFind=Convert.ToInt32(Console.ReadLine());   
        string data=p.FindEmpByID(idToFind);
        Console.WriteLine(data);


        Console.ReadLine();

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