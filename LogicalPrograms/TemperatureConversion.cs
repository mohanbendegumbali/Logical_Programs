using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class TemperatureConversion
    {
        public void Conversion()
        {
            double F = 0, C = 0;
            Console.WriteLine("\nEnter your option:\n 1.Celsius To Fahrenheit\n 2.Fahrenheit To Celsius");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter value in Celsius:");
                    C = Convert.ToDouble(Console.ReadLine());
                    F = C * (9 / 5) + 32;
                    Console.WriteLine("Celsius To Fahrenheit: " + F);
                    break;
                case 2:
                    Console.WriteLine("Enter value in Fahrenheit:");
                    F = Convert.ToDouble(Console.ReadLine());
                    C = (F - 32) * 5 / 9;
                    Console.WriteLine("Fahrenheit To Celsius: " + C);
                    break;
                default:
                    Console.WriteLine("Wrong option!!!");
                    break;
            }
        }
    }
}
