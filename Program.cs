using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CountdownTimer
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                DateTime daysLeft = DateTime.Parse("30.07.2016 14:30:01");
                DateTime startDate = DateTime.Now;


                TimeSpan t = daysLeft - startDate;
                string countDown = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds til we meet again.", t.Days, t.Hours, t.Minutes, t.Seconds);
                Console.WriteLine(countDown);
                System.Threading.Thread.Sleep(1000);

            }
            

           

        }
            }
}
