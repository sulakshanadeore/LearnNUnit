using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemo
{
    public class Student:IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CourseProgramme { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public class Staff:IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }


    public interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName();
    }

    

}
