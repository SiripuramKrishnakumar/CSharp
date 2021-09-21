using System;

namespace Delegates
{
    class Program
    {

        static void Main(string[] args)
        {

            EmployeeData employeeData = new EmployeeData();
            Payroll payroll = new Payroll();

            Employee employee = new Employee();
            employee.FirstName = "Krishna";
            employee.LastName = "Siripuram";
            employee.Address = "Hyderabad";
            employee.Designation= "Software Developer.";

            PayDelegate payDelegate = new PayDelegate(employeeData.AddBasicSalary);
            
            payDelegate += payroll.AddHRA;  // adding more than one pointing method to a delegate is called multi cast delegate.
            payDelegate += payroll.AddAllowance;
            payDelegate += e => {
                Console.WriteLine("Adding Special allowance by lambda expression");
                e.TotalSalary = e.TotalSalary + 1500; // special Allowance by Lambda
                return e;
            };
            payDelegate += payroll.AddPF;

           

            var emp = payDelegate.Invoke(employee);

            EmpDelegate empDelegate = new EmpDelegate(employeeData.PersonalDetails);
            empDelegate += delegate (Employee employee1)  // Anonymus Method
                            {
                                Console.WriteLine("Calling Anonymus Moethod");
                                Console.WriteLine(employee1.Address);
                            };

            

            empDelegate += e => Console.WriteLine("Calling empDelegate by single Line Lambda Expression & Designation is"+e.Designation);// Lambda Expression

            empDelegate += employeeData.EmploymentDetails;

            empDelegate.Invoke(emp);

        
        }
    }
    public delegate void EmpDelegate(Employee employee);
    public delegate Employee PayDelegate(Employee employee);
    public class EmployeeData
    {
        public void PersonalDetails(Employee employee)
        {
            Console.WriteLine(employee.FirstName+employee.LastName);
          
        }
        public void EmploymentDetails(Employee employee)
        {
         
            Console.WriteLine("Salary From Method"+employee.TotalSalary);
        }
        public Employee AddBasicSalary(Employee employee)
        {
            employee.BasicSalary = 10000;
            employee.TotalSalary = employee.TotalSalary + 10000;
            return employee;
        }
       
    }
    public class Payroll
    {
        public Employee AddAllowance(Employee employee)
        {
            employee.Allowances = 4000;
            employee.TotalSalary = employee.TotalSalary + 4000;
            return employee;
        }
        public Employee AddHRA(Employee employee)
        {
            employee.HRA = 5000;
            employee.TotalSalary = employee.TotalSalary + 5000;
            return employee;
            
        }
        public Employee AddPF(Employee employee)
        {
            employee.PF = 1500;
            employee.TotalSalary = employee.TotalSalary + 1500;
            return employee;
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
        public int BasicSalary { get; set; }
        public int HRA { get; set; }
        public int PF { get; set; }
        public int Allowances{ get; set; }
        public int TotalSalary{ get; set; }
    }
}
