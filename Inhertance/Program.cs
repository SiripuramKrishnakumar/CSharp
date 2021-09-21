using System;

namespace Inhertance
{
    class Inhertanceclass
    {
        static void Main(string[] args)
        {
            Car car;
            car = new Audi();
            car = new Mercedes();

            Audi _Audi = new Audi();

            Console.WriteLine("Hello World!");
        }
       
      
    }
    class Car
    {
        public string color { get; set; }
        public int milage{ get; set; }
        public int maxspeed{ get; set; }
        public decimal cost { get; set; }
    }

    class Mercedes : Car
    {
        public int Model { get; set; }
    }
    class Audi : Car
    {
        public int Model { get; set; }
    }
    class Scoda : Car
    {
        public int Model { get; set; }
    }
}
