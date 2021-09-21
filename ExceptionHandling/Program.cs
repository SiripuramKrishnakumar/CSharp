using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            check(age);
        }
        public static void check(int age)
        {
            try
            {
                if(age < 18)
                {
                    throw new AgeNotElgible(age);
                }
            }
            catch(AgeNotElgible ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                age = 0;
            }
        }
    }
    class AgeNotElgible : Exception
    {
        public AgeNotElgible():base("Your Not Eligibale , Age must be above 18 to work ")
        {

        }

        public AgeNotElgible(int age):base("Your Not Eligibale , Age must be above 18 to work , Given Age is "+age)
        {

        }
    }
}
