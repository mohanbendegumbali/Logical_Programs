using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void check(int num)
        {
            int count = 0;
            for (int i = 1; i <=num; i++)
            {
                if (num % i == 0)
                     count++;
            }
            if (count == 2)
                Console.WriteLine(" It is Prime number ");
            else
                Console.WriteLine(" It is not Prime number ");
        }
    }
}
