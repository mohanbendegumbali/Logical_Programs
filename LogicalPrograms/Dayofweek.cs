using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Dayofweek2
    {
        public void Weekday()
        {
            Console.WriteLine("1.January" + "\n" + "2.February" + "\n" + "3.March" + "\n" + "4.April" + "\n" + "5.May" + "\n" + "6.June" + "\n" + "7.July" + "\n" + "8.August" + "\n" + "9.September" + "\n" + "10.October" + "\n" + "11.November" + "\n" + "12.December");
            Console.WriteLine(" Enter the Month");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the Year");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the Day");
            int d = Convert.ToInt32(Console.ReadLine());

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            switch (d0)
            {
                case 0:
                    Console.WriteLine(" Sunday ");
                    break;
                case 1:
                    Console.WriteLine(" Monday ");
                    break;
                case 2:
                    Console.WriteLine(" Tuesday ");
                    break;
                case 3:
                    Console.WriteLine(" Wednesday ");
                    break;
                case 4:
                    Console.WriteLine(" Thursday ");
                    break;
                case 5:
                    Console.WriteLine(" Friday ");
                    break;
                case 6:
                    Console.WriteLine(" Saturday ");
                    break;
            }
        }
    }
}
