 
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
 
namespace WebClient1
{
    class Program
    {
        static void Main()
        {
        start:
            Console.WriteLine("Opions => A : Employee List; B: Employee Deails; C: Create Employee; D: Update Employee; E: Delete Employee; F: Exit Employee; ");
 
            string option = Console.ReadKey().Key.ToString().ToUpper();
 
            switch (option)
            {
                case "A":
                   Console.WriteLine("\nEmployees List");
                    List<Employee> employeelist = new List<Employee>();
                    using (var webClient = new System.Net.WebClient())
                    {
                        webClient.Headers["Content-Type"] = "application/json";
                        webClient.BaseAddress = "http://localhost:61322/api/";
                        string response = webClient.DownloadString("Home/Employees/");
                        employeelist = JsonConvert.DeserializeObject<List<Employee>>(response);
                    }
                    foreach (var emp in employeelist)
                    {
                        Console.WriteLine($"EmployeeId= {emp.Id} , Employee Name = {emp.Name}");
                    }
                    goto start;
 
                case "B":
                    Console.WriteLine("\nEnter Employee Id");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    using (var webClient = new System.Net.WebClient())
                    {
                        webClient.Headers["Content-Type"] = "application/json";
                        webClient.BaseAddress = "http://localhost:61322/api/";
                        string response = webClient.DownloadString("Home/Employee/" + Id);
                        Employee emp = JsonConvert.DeserializeObject<Employee>(response);
                        Console.WriteLine($"EmployeeId= {emp.Id} , Employee Name = {emp.Name}");
                    }
                    
                    goto start;
 
                case "C":
                    Employee employee1 = new Employee();
                    Console.WriteLine("\nEnter Employee Id");
                    employee1.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Employee Name");
                    employee1.Name = Console.ReadLine();
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                        var response = webClient.UploadString("http://localhost:61322/api/Home/Employee/Save/", JsonConvert.SerializeObject(employee1));
                        List<Employee> employeelist1 = JsonConvert.DeserializeObject<List<Employee>>(response);
                        foreach (var emp in employeelist1)
                        {
                            Console.WriteLine($"EmployeeId= {emp.Id} , Employee Name = {emp.Name}");
                        }
                    }
                    goto start;
 
                case "D":
                    Employee employee2 = new Employee();
                    Console.WriteLine("\nEnter Employee Id");
                    employee2.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Employee Name");
                    employee2.Name = Console.ReadLine();
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                        string inp = JsonConvert.SerializeObject(employee2);
                        var response = webClient.UploadString("http://localhost:61322/api/Home/Employee/"+employee2.Id,WebRequestMethods.Http.Put,inp );
                        Employee emp = JsonConvert.DeserializeObject<Employee>(response);
                        Console.WriteLine($" EmployeeId= {emp.Id} ,Updated Employee Name = {emp.Name}");
                    }
                    goto start;
                case "E":
                    Console.WriteLine("\nEnter Employee Id");
                    int Id1 = Convert.ToInt32(Console.ReadLine());
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("http://localhost:61322/api/");
                        HttpResponseMessage result = client.DeleteAsync("Home/Employee/"+Id1).Result;
                        if(result.IsSuccessStatusCode)
                        {
                            Console.WriteLine("Employee is Deleted");
                        }
                        
                        List<Employee> employeelist1 = JsonConvert.DeserializeObject<List<Employee>>(result.Content.ReadAsStringAsync().Result);
                        foreach (var emp in employeelist1)
                        {
                            Console.WriteLine($"EmployeeId= {emp.Id} , Employee Name = {emp.Name}");
                        }
 
                    }
                    goto start;
                case "F":
                    break;
                default:
                    break;
 
            }
 
 
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
 
