using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = string.Empty;
            while (selection != "q" && selection != "Q")
            {
                Console.WriteLine("Enter C)elsius to Fahrenheit or F)ahrenheit to Celsius or Q)uit: ");
                selection = Console.ReadLine();
                double fahrenheit = 0, celsius = 0;
                switch (selection)
                {
                    case "C":
                    case "c":
                        Console.WriteLine("Please enter the Celsius temperature: ");
                        fahrenheit = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:f2}");
                        break;
                    case "F":
                    case "f":
                        Console.WriteLine("Please enter the Fahrenheit temperature: ");
                        // no longer creating an instance - instead calling method on the class via static method
                        celsius = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine($"Temperature in Celsius: {celsius:f2}");
                        break;

                    case "Q":
                    case "q":
                        break;
                    default:
                        Console.WriteLine("Please try again");
                        break;
                }
            }
        }
    }
}
