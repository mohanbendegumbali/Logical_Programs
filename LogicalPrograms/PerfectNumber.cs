using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void check(int num)
        {
            int sum=0;
            for( int i = 0; i < num/2; i++)
            {
                if ( num % i == 0)
                {
                    sum += i;
                }
            }
            if ( num == sum)
                Console.WriteLine(" It is a Perfect Number ");
            else
                Console.WriteLine(" It is not a Perfect Number ");
            
        }
    }
}
