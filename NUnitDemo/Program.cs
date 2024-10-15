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

        Console.ReadLine();

    }

    public  string CheckLogin(string userid,string password)
    {
        

        EmployeesOperations employeesOperations = new EmployeesOperations();
        string status = employeesOperations.Login(userid, password);
        return status;
    }
}