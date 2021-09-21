using System;
using System.Collections.Generic;
using System.Linq;
namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            bool res = i.IsGreaterThan(5);
            Console.WriteLine(res);
            string str = "Hello World";
            int ind = str.Position('o');
            Console.WriteLine(ind);
            List<String> ls = new List<string> {"Altaf","Krishna", "Atul_Kulkarni", "Bharath","Atul Kulkarni" };
            string maxstr =ls.GetMaxLegnthItem();
            Console.WriteLine(maxstr);
        }
    }
    public static class CustomExtensions
    {
        public static bool IsGreaterThan(this int i , int j)
        {
            return i > j;
        }
        public static bool IsLessThan(this int i, int j)
        {
            return i < j;
        }
        public static int Position(this String i, char j)
        {
            return i.IndexOf(j)+1;
        }
        public static string GetMaxLegnthItem(this List<String> ls)
        {
            int maxlgn = ls.Max(i => i.Length);
            string str = ls.Where(j => j.Length == maxlgn).FirstOrDefault();
            return str;
        }
    }
}
