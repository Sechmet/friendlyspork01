using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace CountdownTimer
{
    class Program
    {
        public static void Main()
        {
            var arrival = new DateTimeOffset(2016, 07, 30, 14, 30, 1, TimeSpan.FromHours(2));
            TimeSpan timeLeft;
            do
            {
                timeLeft = arrival - DateTimeOffset.Now;

                var countDownMessage = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds til we meet again.",
                    timeLeft.Days, timeLeft.Hours, timeLeft.Minutes, timeLeft.Seconds);
                Console.WriteLine(countDownMessage);

                Thread.Sleep(1000);

            }
            while (timeLeft.TotalSeconds > 0);

            Console.Read();
        }
    }
}
