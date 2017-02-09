using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumApplication1
{
    public class Employee
    {
        public string FirstName;
        public string LastName;

    }
    enum WorksIn { Google, Yahoo, Ebay, Apple, Facebook, IBM };
    public class program
    { 
        public static void Main(string[] args)
        {
            Employee Emp = new Employee();
            string FullName;
            Console.WriteLine("List Of Companies:");
            foreach (string str in Enum.GetNames(typeof(WorksIn)))
            Console.WriteLine(str);
            Console.WriteLine("Enter the First Name: ");
            Emp.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name: ");
            Emp.LastName = Console.ReadLine();
            Console.WriteLine("Enter the Company Name:");
            WorksIn Company = (WorksIn)(Enum.Parse(typeof(WorksIn),Console.ReadLine()));
            FullName = Emp.FirstName + " " + Emp.LastName;
            Console.WriteLine("Full Name && Works In: {0},{1}",FullName, Company);
            Console.ReadLine();
        }
    }
}
