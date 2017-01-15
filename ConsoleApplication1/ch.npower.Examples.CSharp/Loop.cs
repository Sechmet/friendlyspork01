using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch.npower.Examples.CSharp
{
    public class Loop
    {
        public class LoopFor
        {
            public const int MAX_COUNT = 1000;
            public int Run()
            {
                int counter;
                for(counter = 0; counter < MAX_COUNT; counter++)
                {
                    // tralala
                }

                return counter;
            }
        }
    }
}
