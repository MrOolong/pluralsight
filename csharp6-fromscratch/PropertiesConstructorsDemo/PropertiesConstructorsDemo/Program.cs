using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesConstructorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // explicit constructor
            Employee emp = new Employee(5, 101);
            Console.WriteLine($"emp years of service: {emp.YearsOfService}");
            Console.WriteLine($"emp office: {emp.Office}");

            // default constructor
            Employee emp2 = new Employee();
            emp2.YearsOfService = 15;
            emp2.Office = 201;
            Console.WriteLine($"emp years of service: {emp2.YearsOfService}");
            Console.WriteLine($"emp office: {emp2.Office}");

            // initialization
            Employee emp3 = new Employee()
            {
                YearsOfService = 20,
                Office = 301
            };
            Console.WriteLine($"emp years of service: {emp3.YearsOfService}");
            Console.WriteLine($"emp office: {emp3.Office}");
        }
    }


}
