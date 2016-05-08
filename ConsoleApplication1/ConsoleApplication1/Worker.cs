/**
 * Copyright 2015 d-fens GmbH
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Worker
    {
        public void DoMagic()
        {
            Debug.WriteLine("Hello, world!");

            int counter = 42;
            Debug.WriteLine(counter.ToString());

            //counter = counter + 1;
            //counter += 1;
            counter++;
            Debug.WriteLine(counter);

            string message;
            if(DateTimeOffset.Now.Second < 30)
            {
                message = "Irene ist super";
            }
            else
            {
                message = "Irene ist immer noch ganz ok";
            }

            for(counter = 0; counter < 10; counter++)
            {
                message = message + "er";
                Debug.WriteLine(message);
            }

            //string message1 = string.Empty;
            //Debug.WriteLine(message1);        
        }

        public string PrintMessageUntilNextMinute(string baseMessage, int maxInvocations)
        {
            string result = "Tralala";

            var startingMinute = DateTimeOffset.Now.Minute;

            string message = baseMessage;
            while(startingMinute == DateTimeOffset.Now.Minute)
            {
                message = message + "@";
                Debug.WriteLine(message);
                System.Threading.Thread.Sleep(1000);
            }

            result = message;
            return result;
        }

        

    }
}
