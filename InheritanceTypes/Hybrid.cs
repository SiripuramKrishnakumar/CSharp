using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

        // Hybrid
        class HA
        {
            public void M1()
            {
                Console.WriteLine("Im from HA Class  A, Method 1");
            }
            public void M2()
            {
                Console.WriteLine("Im from HA Class  A, Method 2");
            }
        }
        class HB : HA
        {
            public void M3()
            {
                Console.WriteLine("Im from HB Class  B, Method 3");
            }
            public void M4()
            {
                Console.WriteLine("Im from HB Class  B, Method 4");
            }
        }
        class HC : HB
        {
            public void M5()
            {
                Console.WriteLine("Im from HC Class  C, Method 5");
            }
            public void M6()
            {
                Console.WriteLine("Im from HC Class  C, Method 6");
            }
        }

        class HD : HC
        {
            public void M7()
            {
                Console.WriteLine("Im from HD Class  C, Method 7");
            }
            public void M8()
            {
                Console.WriteLine("Im from HD Class  C, Method 8");
            }
        }

        class HE : HC
        {
            public void M9()
            {
                Console.WriteLine("Im from HE Class  C, Method 9");
            }
            public void M10()
            {
                Console.WriteLine("Im from HE Class  C, Method 10");
            }
        }

    }

