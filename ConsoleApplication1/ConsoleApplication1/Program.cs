using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program 
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            worker.DoMagic();

            worker.PrintMessageUntilNextMinute("my base message", 0);
        }
    }
}
