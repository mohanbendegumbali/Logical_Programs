using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class MonthPayment
    {
        double Y = 0, P = 0, R = 0;
        public void Payment()
        {
            Console.WriteLine(" Enter the Principle Amount ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter the Rate ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter the Year ");
            double Y = Convert.ToDouble(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);
            double payment = P * r / (1 - Math.Pow(1 + r, n));
            Console.WriteLine(" The Monthly Payment is " + payment);
        }
    }
}
