using System;
using System.Text;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Data Types are twoo types - 1.Value Type 2.Reference Type
             * 
             * Value Types => Simple types (integral,floating point, char, boolean) , Enum Types, Struct types, Nullable Types
             * 
             * Reference Types => Class types, Interface Types, Array Types,Delegate Types
             * 
             * Value Types have a default values
             * 
             */

            // string builder
            StringBuilder sb = new StringBuilder(); // it ill not create new memory when we modified it it will extend modified memory
            sb.Append("Hello");                     // when we modify (concat) string it will create new memory
            sb.Append("World");
            sb.AppendLine("Ï'm Kishna");

            //enum
            Console.WriteLine(Weeks.Mon);
            Console.WriteLine((int)Weeks.Mon);

            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();
            dt1 = dt1.AddYears(2020);
            dt1 = dt1.AddMonths(2);
            dt1 = dt1.AddDays(20);

            Console.WriteLine(dt1);

            //assigns year, month, day
            DateTime dt2 = new DateTime(2015, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            // diff days bw two days

            double days = DateTime.Now.Subtract(dt1).TotalDays;
            double hours = DateTime.Now.Subtract(dt1).TotalHours;
            double min = DateTime.Now.Subtract(dt1).TotalMinutes;
            Console.WriteLine($"days {days} ");
            Console.WriteLine($"hours {hours} ");
            Console.WriteLine($"min {min} ");


            // without instance we can assign values because it is value type , it is used to store small information whih is not changable.
            Person person;
            person.Id = 1;
            person.FirstName = "Siripuram";
            person.LastName = "Krishna ";
            Console.WriteLine(person.FirstName + " " + person.LastName);

            //Nullable type
            int? num = null;
            num = 1;
            Console.WriteLine(num);

            //without instance we can not assign values  because its reference type
            Employee employee = new Employee();
            employee.Id = 1;
            employee.FirstName = "Siripuram";
            employee.LastName = "Krishna ";
            Console.WriteLine(employee.FirstName + " " + employee.LastName);

            

            // Anonymous type : these types are without name and  public, read only

            var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
            Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName}");

            var list = new[] {
                     new { Id = 1, FirstName = "James", LastName = "Bond" },
                     new { Id = 2, FirstName = "Peter", LastName = "Bond" },
               };
            Console.WriteLine($"{list[1].Id} {list[1].FirstName} {list[1].LastName}");


            //Dynamic type : it similar to object type but no need of type casting when we make operations on variables , it dynamically define Type at runtime.

            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            //Delegate
            PrintSalary empSalary = new PrintSalary();
            PrintDelgate salaryDelgate = new PrintDelgate(empSalary.Assocaitesalry);
            salaryDelgate += empSalary.Leadsalry;
            salaryDelgate += empSalary.Managersalry;

            salaryDelgate.Invoke(); // Invoke method used to call delegate methods as one event

            EmpSalary salary = new EmpSalary();
            SalaryDelgate delgate = new SalaryDelgate(salary.Basicsalry);
            delgate += salary.HRA;
            delgate += salary.Allowances;
            Console.WriteLine("Enter Basic Salary:");
            string strbsc = Console.ReadLine();

            int val = delgate.Invoke(Convert.ToInt32(strbsc)); // its invoke all methods at once
            Console.WriteLine("Total Salary: " + val);
            //delgate += salary.Managersalry;// compiler error because signiture is no same

        }


    }
    //enum 
    public enum Weeks
    {
        Sun = 1,
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat,
    }
    // struct
    struct Person
    {
        public int Id;
        public String FirstName;
        public String LastName;

    }
    //class
    class Employee
    {
        public int Id;
        public String FirstName;
        public String LastName;

    }

    // Delegate declaration
    public delegate int SalaryDelgate(int sal);
    public delegate void PrintDelgate();

    class EmpSalary
    {
        int totalsal = 0;
        public int Basicsalry(int sal)
        {
            totalsal = (int)(totalsal + sal + (sal * 0.3));
            return totalsal;
        }
        public int HRA(int sal)
        {
            totalsal = (int)(totalsal + sal + (sal * 0.4));
            return totalsal;
        }
        public int Allowances(int sal)
        {
            totalsal = (int)(totalsal + sal + 5000);
            return totalsal;
        }
    }

    class PrintSalary
    {

        public void Assocaitesalry()
        {

            Console.WriteLine(1000);
        }
        public void Leadsalry()
        {

            Console.WriteLine(5000); ;
        }
        public void Managersalry()
        {

            Console.WriteLine(10000);
        }
    }
}
