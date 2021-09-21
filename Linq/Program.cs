using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq
{

    class Program
    {
        static void Main(string[] args)
        {

            var allemps = Data.Employees.ToList();
            Console.WriteLine("\nAll Employees \n");
            foreach (var emp in allemps)
            {
                Console.WriteLine($"[\n Employee Id: {emp.Id}, \n Name: {emp.Name}, \n Salary: {emp.Salary} \n ],");
            }

            Console.WriteLine("\nOrder By:");
            var cities = Data.Cities.OrderBy(i => i.Name);
            foreach (var city in cities)
            {
                Console.WriteLine($"city id {city.Id} , city name : {city.Name}");
            }
            Console.WriteLine("\nOrder By Decending:");
            var cities1 = Data.Cities.OrderByDescending(k => k.Name).ToList();

            foreach (var city in cities1)
            {
                Console.WriteLine($"[ City Id: {city.Id},  Name: {city.Name}, ],");
            }

            Console.WriteLine($"\n Than By");

            var empls = Data.Employees.OrderBy(i => i.Name).ThenBy(i => i.Salary);
            foreach (var emp in empls)
            {
                Console.WriteLine($"[\n Employee Id: {emp.Id},  Name: {emp.Name},  Salary: {emp.Salary} \n ],");
            }

            Console.WriteLine($"\n Than By Desending");

            var empls1 = Data.Employees.OrderBy(i => i.Name).ThenByDescending(i => i.Salary);
            foreach (var emp in empls1)
            {
                Console.WriteLine($"[\n Employee Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary} \n ],");
            }

            Console.WriteLine("\n Take ");

            var tkemps = Data.Employees.Take(5);
            foreach (var emp in tkemps)
            {
                Console.WriteLine($"[\n Employee Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary} \n ],");
            }

            Console.WriteLine("\nTake While");

            var mnagers = Data.Employees.TakeWhile(i => i.IsManger is true);

            foreach (var emp in mnagers)
            {
                Console.WriteLine($"[\n Employee Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary} IsManager {emp.IsManger} \n ],");
            }
            Console.WriteLine("\nskip While");

            var skemps = Data.Employees.Skip(5);

            foreach (var emp in skemps)
            {
                Console.WriteLine($"[\n Employee Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary} IsManager {emp.IsManger} \n ],");
            }


            Console.WriteLine("\n To Array");
            var citiesarr = Data.Cities.ToArray();
            Console.WriteLine($"{JsonConvert.SerializeObject(citiesarr)}");

            Console.WriteLine("\n To List");
            var citieslst = Data.Cities.ToArray();
            Console.WriteLine($"{JsonConvert.SerializeObject(citieslst)}");

            Console.WriteLine("\n To Dictionary");
            var citiesdic = Data.Cities.ToDictionary(i => i.Id);
            Console.WriteLine($"{JsonConvert.SerializeObject(citiesdic)}");

            Console.WriteLine("\n To Lookup");
            //ToLookup() method is used to print the value of the data in the pair/collection of items.  
            var empslkp = Data.Employees.ToLookup(i => i.BranchId);
            // group the employees by BusinessUnit Id
            foreach (var kvpair in empslkp)
            {
                Console.WriteLine($"\n{Data.Branches.Where(i => i.BranchID == kvpair.Key).Select(j => j.BranchName).FirstOrDefault()}");
                foreach (var emp in empslkp[kvpair.Key])
                {
                    Console.WriteLine($"[\n Employee Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary} ],");
                }
            }

            Console.WriteLine("Enumerable");
            IEnumerable<Employee> emps = Data.Employees.AsEnumerable();
            foreach (var emp in emps)
            {
                Console.WriteLine($"[\n Employee Id: {emp.Id},  Name: {emp.Name},  Salary: {emp.Salary} \n ],");
            }


            Console.WriteLine("IQuerable");
            IQueryable<Employee> employees = Data.Employees.AsQueryable();
            foreach (var emp in employees)
            {
                Console.WriteLine($"[\n Employee Id: {emp.Id},  Name: {emp.Name},  Salary: {emp.Salary} \n ],");
            }

            Console.WriteLine("\nGroup by");

            var Branchs = Data.Employees.GroupBy(i => i.BranchId).Select(j => new { Branch = j.Key, BranchCount = j.Count() }).ToArray();
            foreach(var branch in Branchs)
            {
                Console.WriteLine($"{branch.BranchCount} {branch.Branch}");
            }

            Console.WriteLine("\nInner Join");

            var brn = (from br in Data.Branches
                       join
                       ct in Data.Cities
                       on br.CityId equals ct.Id
                       select new { CityName = ct.Name, BranchName = br.BranchName, IsMainBranch = br.IsMainBrach }).ToList();

            foreach (var branch in brn)
            {
                Console.WriteLine($"{branch.CityName} {branch.BranchName} {branch.IsMainBranch}");
            }

            Console.WriteLine("\n ");
        }
    }
}
