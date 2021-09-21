using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface Interface1
    {
        void I1();
        void I2();
    }
    interface Interface2
    {
        void I3();
        void I4();
    }
    interface Interface3
    {
        void I5();
        void I6();
    }

    interface Interface4 : Interface1,Interface2,Interface3
    {
        void I7();
        void I8();
    }

    class Implement : Interface4
    {
        public void I1()
        {
            Console.WriteLine("Im from I1");
        }

        public void I2()
        {
            Console.WriteLine("Im from I2");
        }

        public void I3()
        {
            Console.WriteLine("Im from I3");
        }

        public void I4()
        {
            Console.WriteLine("Im from I4");
        }

        public void I5()
        {
            Console.WriteLine("Im from I5");
        }

        public void I6()
        {
            Console.WriteLine("Im from I6");
        }

        public void I7()
        {
            Console.WriteLine("Im from I7");
        }

        public void I8()
        {
            Console.WriteLine("Im from I8");
        }
    }


}
