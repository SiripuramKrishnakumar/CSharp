using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            
            /* Thread Life Cycle
            * Unstarted
            *Runnable (Ready to run)
            *Running
            *Not Runnable
            *Dead (Terminated)
            */


            // Main Thread starts first , and end last
            Thread thread = Thread.CurrentThread;
            thread.Name = "Main Thread";
           
            Program program = new Program();
            Thread thread1 = new Thread(new ThreadStart(Program.GetStudents)); // thread for void
            Thread thread2 = new Thread(new ThreadStart(Program.GetIds)); // thread for void
            thread1.Priority = ThreadPriority.Normal;
            thread2.Priority = ThreadPriority.Highest;
            thread1.Start();
            Console.WriteLine(thread.Name);
            thread1.Join(500); // for given time that will run this thread and wait left over threads
            thread2.Start();
      
            Console.WriteLine("end");

        }


        public static void GetStudents()
        {
            List<string> list = new List<string>() { "Krishna", "Altaf", "Bharath", "RaviTeja", "Manjeet", "Praveen" };
            foreach (string str in list)
            {
                Thread.Sleep(200); // sleep for given time
                Console.WriteLine(str);
            }
        }
        public static void GetIds()
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
          
            foreach (int id in list)
            {
                Thread.Sleep(100);
                Console.WriteLine(id);
            }
        }
    }






}
