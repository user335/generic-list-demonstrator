using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();
        public abstract void PrintYourThings();

        static public List<Person> employees;
        static void Main()
        {
            employees = new List<Person>();
            var employee = new Employee<string>();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.ID = 1;
            employee.things = new List<string>() { "sup", "yo" };
            employees.Add(employee);

            var employee2 = new Employee<int>();
            employee2.firstName = "Sample2";
            employee2.lastName = "Student2";
            employee2.ID = 2;
            employee2.things = new List<int>() { 1, 2 };
            employees.Add(employee2);

            foreach (var item in employees)
            {
                item.PrintYourThings();
            }

            Console.Read();
        }
    }
}
