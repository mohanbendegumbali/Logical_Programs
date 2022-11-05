using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopWatch
    {
        DateTime dateTime = DateTime.Now;
        public void Start()
        {
            int startHr = dateTime.Hour;
            int startMin = dateTime.Minute;
            int startSec = dateTime.Second;
            int startMilliSec = dateTime.Millisecond;
            Console.WriteLine(" Press S to start ");
            string data = Console.ReadLine().ToLower();
            if (data.Equals("s"))
            {
                Console.WriteLine(startMilliSec);
                Console.WriteLine(" Press X for exit ");
                string stop = Console.ReadLine().ToLower();
                if (data.Equals("x"))
                {
                    DateTime dateTime1 = DateTime.Now;
                    int endHr = dateTime1.Hour;
                    int endMin = dateTime1.Minute;
                    int endSec = dateTime1.Second;
                    int endMilliSec = dateTime1.Millisecond;
                    Console.WriteLine(" StopWatch Hour :" + (startHr - endHr));
                    Console.WriteLine(" StopWatch Minutes :" + (startMin - endMin));
                    Console.WriteLine(" StopWatch Seconds :" + (startSec - endSec));
                    Console.WriteLine(" StopWatch Milli Seconds :" + (startMilliSec - endMilliSec));
                }
            }
        }
    }

}
