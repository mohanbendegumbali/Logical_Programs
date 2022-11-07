using LogicalPrograms;
using System;
using DayOfWeek = System.DayOfWeek;

namespace Demo
{
    class Program
    {
        int a = 10;
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Fibonacci Series" + "\n" + "2.Perfect Number" + "\n" + "3.Prime Number" + "\n" + "4.Reverse Number" + "\n" + "5.Coupon Number" + "\n" + "6.Stop Watch" + "\n" + "7.Vending Machine" + "\n" + "8.Day of Week" + "\n" + "9.Temperature Conversion");
                Console.WriteLine(" Enter the option ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries fib = new FibonacciSeries();
                        fib.Print(5);
                        break;
                    case 2:
                        PerfectNumber perfect = new PerfectNumber();
                        perfect.check(28);
                        break;
                    case 3:
                        PrimeNumber prime = new PrimeNumber();
                        prime.check(5);
                        break;
                    case 4:
                        ReverseNumber num = new ReverseNumber();
                        num.reverse(345);
                        break;
                    case 5:
                        CouponNumber.Generatecoupons(10);
                        break;
                    case 6:
                        StopWatch stop = new StopWatch();
                        stop.Start();
                        break;
                    case 7:
                        VendingMachine machine = new VendingMachine();
                        machine.Notes(1500);
                        machine.Print();
                        break;
                    case 8:
                        Dayofweek dayofweek2 = new Dayofweek();
                        dayofweek2.Weekday();
                        break;
                    case 9:
                        TemperatureConversion temp = new TemperatureConversion();
                        temp.Conversion();
                        break;


                }
            }
        }
    }
}
