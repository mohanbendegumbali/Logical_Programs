﻿using LogicalPrograms;
using System; 

namespace Demo 
{
    class Program 
    {
        int a = 10;
        public static void Main(string[] args) 
        {
            Console.WriteLine(" Welcome");
            //FibonacciSeries fib = new FibonacciSeries();
            //fib.Print(5);
            //PerfectNumber perfect = new PerfectNumber();
            //perfect.check(28);
            PrimeNumber prime = new PrimeNumber();
            prime.check(5);
        }
    }
}
