using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    
        // MultiLevel
        class MA
        {
            public void M1()
            {
                Console.WriteLine("Im from ML Class  A, Method 1");
            }
            public void M2()
            {
                Console.WriteLine("Im from ML Class  A, Method 2");
            }
        }
        class MB : MA
        {
            public void M3()
            {
                Console.WriteLine("Im from ML Class  B, Method 3");
            }
            public void M4()
            {
                Console.WriteLine("Im from ML Class  B, Method 4");
            }
        }
        class MC : MB
        {
            public void M5()
            {
                Console.WriteLine("Im from ML Class  C, Method 5");
            }
            public void M6()
            {
                Console.WriteLine("Im from ML Class  C, Method 6");
            }
        }
    }

    
