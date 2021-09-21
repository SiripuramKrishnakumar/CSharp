using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * function means method
             * we can call functions in two ways 
             * 1> call by value
             * 2> call by reference
             * out , ref key words
             */
            // <Access Modifier>  <return type> <MethodName>(<Formal Parameters>)  // Method Signature

            // void - if anything is not returning

            // return type shoud be a Type , it may be predefined or userdefined  // prefined {int, string, decimal, double}  // userdefined {complex/userdefine classes , structs, Enums Collections[List, Array etc]} 

            // making instance , or calling constructor
            Program program = new Program();

            //call by value

            int c = 5;
            int d = 15;
            int e = 25;
            int sum = program.AddNum(c, d);  // c,d are Actual Parameters.
            Console.WriteLine("Sum is " + sum);
            int sum1 = program.AddNum(c, d, e);
            Console.WriteLine("Sum is " + sum1 + "\n"); // string conctatination

            //call by reference
            Console.WriteLine($"Before Method Calling values are {c} {d} {e} \n");  // string interpolation
            program.RefDemo(ref c, ref d, c);

            Console.WriteLine($"After Method Calling with ouot ref values are {c} {d} {e} \n");  // string interpolation


            int sum2 = program.AddNum(c, d);
            Console.WriteLine("Sum After Calling function by ref is " + sum2);

            // out key word : it used to return multiple outputs
            int product = 0;
            int sum3 = program.AddProduct(c, d, out product);
            Console.WriteLine($"\nSum is {sum3} product is {product}");

        }

        public int AddNum(int a, int b)
        {
            return a + b;
        }
        public int AddNum(int a, int b, int c)
        {
            return a + b + c;
        }

        public void RefDemo(ref int c, ref int d, int e)
        {
            c = 25;
            d = 50;
            e = 75;
        }

        public int AddProduct(int a, int b, out int prod)
        {
            prod = a * b;
            int sum = a + b;
            return sum;

        }
    }
}
