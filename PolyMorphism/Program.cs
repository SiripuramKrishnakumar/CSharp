using System;

namespace PolyMorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            // Method Overloading

            DateTime dateTime = new DateTime(2021, 12, 31);
            DateTime dateTime1 = new DateTime(2021, 12, 31, 18, 30, 5);
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime1);

            TicketBooking ticketBooking = new TicketBooking();
            Console.WriteLine("Input: 3");
            ticketBooking.BookTickets(3);
            Console.WriteLine("Input: 7");
            ticketBooking.BookTickets(7);
            Console.WriteLine("Input: 3,10");
            ticketBooking.BookTickets(3, 10);
            Console.WriteLine("Input: 6,10");
            ticketBooking.BookTickets(6, 10);
            Console.WriteLine("Input: 3,12,123KK");
            ticketBooking.BookTickets(3, 12, "123KK");
            Console.WriteLine("Input: 6,12,123ks");
            ticketBooking.BookTickets(6, 12, "123ks");
            Console.WriteLine("Input: 6,12,123KK");
            ticketBooking.BookTickets(6, 12, "123KK");

            Console.WriteLine("---------------------------");

            //Method Overiding

            Uber ub = new Uber();
            ub.WelcomeUber();
            ub.BookRide(4);
            ub.BookRidewithCode(4, "KK123");
            ub.VehicleType();

            Console.WriteLine("---------------------------");

            Ola o = new Ola();
            o.WelcomeOla();
            o.BookRide(4);
            o.BookRidewithCode(4, "KK123");
            o.VehicleType();

            Console.WriteLine("---------------------------");

            //Method Hiding

            Rapido rp = new Rapido();
            rp.WelcomeRapido();
            rp.BookRide(4);
            rp.BookRidewithCode(4, "KK123");
            rp.VehicleType();

        }
    }
    class TicketBooking
    {
        public void BookTickets(int custCount)
        {
            if (custCount > 5)
            {
                Console.WriteLine($"your {custCount} tickets are booked with 5% discount.");
            }
            else
            {
                Console.WriteLine($"your {custCount} tickets are booked ");
            }

        }
        public void BookTickets(int custCount, decimal disc)
        {
            if (custCount > 5)
            {
                Console.WriteLine($"your {custCount} tickets are booked with {disc} % discount.");
            }
            else
            {
                BookTickets(custCount);
            }

        }
        public void BookTickets(int custCount, decimal disc, string code)
        {
            if (code == "123KK" && custCount > 5)
            {
                Console.WriteLine($"your {custCount} tickets are booked with {disc} % discount and 100 rs cashback.");
            }
            else
            {
                BookTickets(custCount, disc);
            }
        }
    }

    class CabBooking
    {
        public void BookRide(int custCount)
        {
            if (custCount > 2)
            {
                Console.WriteLine($"For  {custCount} people cab are booked with total amount {((custCount * 0.2) + custCount) * 100} rs");
            }
            else
            {
                Console.WriteLine($"For {custCount} people cab are booked with total amount {custCount * 100} rs");
            }

        }
        public virtual void BookRidewithCode(int custCount, string code)
        {
            if (custCount > 2)
            {
                Console.WriteLine($"For {custCount}  people cab are booked with  code {code} and amount {(custCount * 100) - 50} rs.");
            }
            else
            {
                Console.WriteLine($"For {custCount} people cab are booked with total amount {custCount * 100} rs");
            }

        }
        public void VehicleType()
        {
            Console.WriteLine("Two Wheeler; Four Wheeler.");
        }
    }

    class Uber : CabBooking
    {
        public void WelcomeUber()
        {
            Console.WriteLine("Welcome to Uber.");
        }
    }
    // this is for overriding
    class Ola : CabBooking
    {
        public void WelcomeOla()
        {
            Console.WriteLine("Welcome to Ola");
        }
        public override void BookRidewithCode(int custCount, string code)
        {
            if (custCount > 3)
            {
                Console.WriteLine($"For {custCount} people cab are booked with code {code} and amount {(custCount * 100) - 100}  rs.");
            }
            else
            {
                Console.WriteLine($"For {custCount} people cab are booked with total amount {custCount * 100} rs");
            }

        }
    }
    // method hiding
    class Rapido : CabBooking
    {
        public void WelcomeRapido()
        {
            Console.WriteLine("Welcome to Rapido");
        }
        public new void VehicleType()
        {
            Console.WriteLine("Two Wheeler.");
        }
    }


}
