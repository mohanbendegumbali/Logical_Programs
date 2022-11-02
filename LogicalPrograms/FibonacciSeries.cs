using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public void Print( int num)
        {
            int firstnum = 0, secondnum = 1, thirdnum =0;
            Console.WriteLine(firstnum + "\n" + secondnum);
            for ( int i = 0; i < num; i++)
            {
                thirdnum = firstnum + secondnum;
                firstnum=secondnum;
                secondnum=thirdnum;
                Console.WriteLine(thirdnum);
            }
        }
    }
}
