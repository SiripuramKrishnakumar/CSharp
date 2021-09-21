using System;

namespace Inheritance
{
        // single level
        class SA
        {
            public void M1()
            {
                Console.WriteLine("Im from SL Class A, Method 1");
            }
            public void M2()
            {
                Console.WriteLine("Im from SL Class A, Method 2");
            }
        }
        class SB : SA
        {
            public void M3()
            {
                Console.WriteLine("Im from SL Class B, Method 3");
            }
            public void M4()
            {
                Console.WriteLine("Im from SL Class B, Method 4");
            }
        }
    }

