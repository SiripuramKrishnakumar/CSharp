using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class HRA
    {
        public void M1()
        {
            Console.WriteLine("Im from HR Class  A, Method 1");
        }
        public void M2()
        {
            Console.WriteLine("Im from HR Class  A, Method 2");
        }
    }
    class HRB : HRA
    {
        public void M3()
        {
            Console.WriteLine("Im from HR Class  B, Method 3");
        }
        public void M4()
        {
            Console.WriteLine("Im from HR Class  B, Method 4");
        }
    }
    class HRC : HRA
    {
        public void M5()
        {
            Console.WriteLine("Im from HR Class  C, Method 5");
        }
        public void M6()
        {
            Console.WriteLine("Im from HR Class  C, Method 6");
        }
    }
    class HRD : HRA
    {
        public void M7()
        {
            Console.WriteLine("Im from HR Class  D, Method 7");
        }
        public void M8()
        {
            Console.WriteLine("Im from HR Class  D, Method 8");
        }
    }
}
