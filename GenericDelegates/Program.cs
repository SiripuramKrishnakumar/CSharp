using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericDelegates
{
    class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();

            #region Action
            //Action is a Predefined Genereic  Delegate & it is an type safe void delegate with n number of input Parameters
            Action<int, int> empdel = new Action<int, int>(program.Add);
            empdel += program.Sub;
            empdel.Invoke(15, 10);

            // Action Delegate with anonymous function
            Action<String, String> action = new Action<string, string>(
                delegate (string fn, string ln)
                {
                    Console.WriteLine("Anonymous:" + fn + " " + ln);
                });
            // Action Delegate by Single Line Lambda Expression
            action += (string a, string b) => Console.WriteLine("Lambda : " + b + " " + a);
            // Invoking Action Delegate
            action.Invoke("Krishna", "Siripuram");
            #endregion

            #region Func

            // Func is a predeine Generic Delegate and it is type safe with one return type and n number of input parameters
            int res = 0;
            Func<int, int, int> func = new Func<int, int, int>(program.AddNum);
            func += delegate (int a, int b) // Anonymous Method
                    {

                        return a * b;
                    };

            // sigle line Lambda Expression
            func += (int a, int b) => a * b;
            res = func.Invoke(15, 10);
            Console.WriteLine("Pro" + res);
            // Lambda expression
            func += (int a, int b) => { a--; b++; Console.WriteLine("Func Lambda"); return a / b; };
            res = func.Invoke(25, 10);
            Console.WriteLine(res);
            #endregion

            #region Predicate
            // it have one input parameter and return boolean
            Predicate<int> predicate = new Predicate<int>(program.IsEven);
            Console.WriteLine(predicate.Invoke(20));

            predicate = i => i > 10;
            bool res1 = predicate.Invoke(5);
            Console.WriteLine(res1);

            // we will use delegates in Linq
            // simple example is below

            List<String> ls = new List<string> { "Krishna Kumar", "Hari", "Altaf", "Bharath", "Atul Kulkarni" };
            Predicate<String> pred = x => x.Contains("A");
            
            var lst1 = ls.Find(pred); //predicate delaget will be passed in  Find method to check and returns one value
            Console.WriteLine(lst1);
            Console.WriteLine("\n\n");

            Func<string, bool> func1 = delegate (string str) //  foreach item  it will check which returns true that string value will added to lst2
            {
                 bool val = str.Contains("A");
                 return val;
             };
                //i => i.Contains("A"); 
            var lst2 = ls.Where(func1).ToList();
            foreach(string item in lst2)
            {
                Console.WriteLine(item);
            }


            #endregion
        }
        public bool IsEven(int a)
        {
            return a % 2 == 0 ? true : false;
        }
        public void Add(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"Difference: {a - b}");
        }

        public int AddNum(int a, int b)
        {
            return a + b;
        }
        public int SubNum(int a, int b)
        {
            return a - b;
        }
    }
}
