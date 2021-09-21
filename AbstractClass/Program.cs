using System;

namespace AbstractClass
{
    class AbDemo
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.DemoM();
            program.Test();
        }
    }

    class Program : Demo
    {
        public override void DemoM()
        {
            Console.WriteLine("Hello from overrided method !");
        }
    }

    abstract class Demo
    {
        public abstract void DemoM();
        public void Test()
        {
            Console.WriteLine("Hello from parent class method!");
        }
    }
}
