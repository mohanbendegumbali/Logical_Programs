using LogicalPrograms;
using System; 

namespace Demo 
{
    class Program 
    {
        int a = 10;
        public static void Main(string[] args) 
        {
            Console.WriteLine(" Welcome");
            FibonacciSeries fib = new FibonacciSeries();
            fib.Print(5);
        }
    }
}
