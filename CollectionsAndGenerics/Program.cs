using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Types
            // Comes Under Types
            object sample = 90.00;
            object sample1 = 23;
            // object sum =  sample + sample1;

            dynamic str = "0";
            dynamic num2 = 3;
            Console.WriteLine($"{str + num2}");
            str = 1;
            Console.WriteLine(str + num2);

            StringBuilder sb = new StringBuilder(); // when we modify it will not create new memory it will extend memory.
            sb.Append("Hello ");
            sb.Append("Altaf");
            sb.AppendLine("Hello Krishna");

            string strex = "Hello Krishna";
            strex = strex + "Hello Altaf";

            /* int/int = int
             * 
             * int/ float = int
             * 
             * float/flot = float
             * 
             * float/int = float
             */


            #endregion


            #region Non Generic Collection

            // Non Generic Colletion - it will present System.Collections

            //1. ArrayList 
            // it will store only object type values
            ArrayList arrayList = new ArrayList();
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add("Five");
            Console.WriteLine(arrayList.Count);
            arrayList.Remove("Five");
            Console.WriteLine(arrayList.Count);
            Console.WriteLine(arrayList[1]);

            // HashTable
            // it will store key value pair of object type collection , key is object type , value also object type
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Altaf");
            hashtable.Add(2, "Krishna");
            hashtable.Add(3, "ashfaq");
            hashtable.Add(4, "Bharath");
            Console.WriteLine(hashtable.Count);
            hashtable.Remove(2);
            Console.WriteLine(hashtable.Count);
            Console.WriteLine(hashtable[1]);
            Console.WriteLine(hashtable[3]);

            //Sorted List
            SortedList sortedList = new SortedList();
            sortedList.Add("D", "Krishna");
            sortedList.Add("F", "Altaf");
            sortedList.Add("A", "ashfaq");
            sortedList.Add("AB", "Sharath");
            sortedList.Add("AC", "Bharath");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            // Stack

            Stack stack = new Stack();
            stack.Push("Altaf");
            stack.Push(1);
            stack.Push("Krishna");
            stack.Push(2);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Peek());

            // Queue

            Queue queue = new Queue();
            queue.Enqueue("Altaf");
            queue.Enqueue("Krishna");
            queue.Enqueue("Ashfaq");
            queue.Enqueue(45.56);
            queue.Enqueue("Bharath");
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Peek());

            #endregion

            Console.WriteLine("\n \n \n Generic -----------------------");
            #region Generic Collection

            // Generic Collection - we can define any type of collection / set using Generic Operator "T"
            // Generic types means generalized Type Collections

            //*** List *** imp

            // We Can Perform Operation on Collection with IEnumerable and IQuerable

            // 1. List , 2. Disctionary , 3. HashSet , 4.Stack  , 5. Queue. , 6. SortedList
            // Type Safe 

            //1.List

            List<String> strlst = new List<string>() { "Krishna", "Ashfaq", };
            strlst.Add("Altaf");
            List<String> strlst1 = new List<string>() { "Bharath", "Praveen" };
            strlst.AddRange(strlst1);

            List<Person> people = new List<Person>() {
            new Person{ FirstName = "Krishna",LastName = "Siripuram" ,Salary = 10000 },
            new Person{ FirstName = "Bharath",LastName = "Awaru" ,Salary = 15000},
            new Person{ FirstName = "Praveen",LastName = "Theegavarapu", Salary = 10000},
            };
            Person person = new Person();
            person.FirstName = "Altaf";
            person.LastName = "Raza";
            person.Salary = 20000;
            people.Add(person);

            foreach (var per in people)
            {
                Console.WriteLine($"{per.FirstName } {per.LastName} ");
            }
            Console.WriteLine($"{people.Max(i => i.Salary)} {people.Sum(i => i.Salary)}");
            Person person1 = people.Where(i => i.FirstName == "Krishna").FirstOrDefault();
            people.Remove(person1);
            Console.WriteLine("After Remove");
            foreach (var per in people)
            {
                Console.WriteLine($"{per.FirstName } {per.LastName}");
            }


            // 2. Dictionary

            Dictionary<int, Person> pairs = new Dictionary<int, Person>();
            pairs.Add(101, new Person { FirstName = "Altaf", LastName = "Raza" });
            pairs.Add(105, new Person { FirstName = "Altaf", LastName = "Raza" });
            pairs.Add(102, new Person { FirstName = "Ashfaq", LastName = "Raza" });
            pairs.Add(103, new Person { FirstName = "Bharath", LastName = "Awaru" });

            foreach (var per in pairs)
            {
                Console.WriteLine($"{per.Key } {per.Value.FirstName } {per.Value.LastName}");
            }
            Person per5 = pairs[101];
            Console.WriteLine($"{per5.FirstName } {per5.LastName}");

            //3.Hashset
            Console.WriteLine("\n \n \n");

            HashSet<String> hs = new HashSet<string>();
            hs.Add("Altaf");
            hs.Add("Krishna");
            hs.Add("Krishna");
            hs.Add("Krishna");
            hs.Add("Krishna");
            hs.Add("Altaf");



            // only distinct values will consider or take
            foreach (string str1 in hs)
            {
                Console.WriteLine(str1);
            }

            HashSet<String> hs1 = new HashSet<string>();
            hs1.Add("Altaf");
            hs1.Add("Krishna");
            hs1.Add("Praveen");
            hs1.Add("Bharath");
            hs1.Add("Krishna");
            hs1.Add("Altaf");
            hs1.Add("Altaf");

            Console.WriteLine("\n \n \n");
            var hs3 = hs.Intersect(hs1);

            foreach (string str1 in hs3)
            {
                Console.WriteLine(str1);
            }

            //o/p
            //Altaf
            //Krishna

            var hs4 = hs.Union(hs1);
            foreach (string str1 in hs4)
            {
                Console.WriteLine(str1);
            }




            // sorted list

            SortedList<int, String> valuePairs = new SortedList<int, string>();
            valuePairs.Add(1, "Krishna");
            valuePairs.Add(2, "Altaf");
            valuePairs.Add(5, "ashfaq");
            valuePairs.Add(3, "Sharath");
            valuePairs.Add(9, "Bharath");
            foreach (var item in valuePairs)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            // Stack

            Stack<String> stackT = new Stack<String>();
            stackT.Push("Altaf");
            stackT.Push("Bharath");
            stackT.Push("Krishna");
            stackT.Push("Ashfaq");

            Console.WriteLine(stackT.Peek());
            Console.WriteLine(stackT.Count);
            Console.WriteLine(stackT.Pop());
            Console.WriteLine(stackT.Count);
            Console.WriteLine(stackT.Peek());

            // Queue

            Queue<String> queueT = new Queue<String>();
            queueT.Enqueue("Altaf");
            queueT.Enqueue("Krishna");
            queueT.Enqueue("Ashfaq");
            queueT.Enqueue("Bharath");
            Console.WriteLine(queueT.Peek());
            Console.WriteLine(queueT.Count);
            Console.WriteLine(queueT.Dequeue());
            Console.WriteLine(queueT.Count);
            Console.WriteLine(queueT.Peek());

            Console.WriteLine("\n\n");
            // Linked List

            LinkedList<string> lnlst = new LinkedList<string>();
            lnlst.AddFirst("Pradeep");
            lnlst.AddFirst("Ashfaq");

            lnlst.AddLast("Altaf");
            lnlst.AddLast("Bharath");
            LinkedListNode<string> node = lnlst.Find("Altaf");
            lnlst.AddBefore(node, "Krishna");
            LinkedListNode<String> node1 = lnlst.FindLast("Pradeep");
            lnlst.AddAfter(node1, "Praveen");

            foreach (var item in lnlst)
            {
                Console.WriteLine($"{item}");
            }

            #endregion


        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
}
