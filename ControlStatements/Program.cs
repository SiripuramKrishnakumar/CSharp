using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
             * 2 Types - 1> Conditional 2> Iterational Statements.
             * 
             * Conditional Statements - 1> Switch , 2> If else, 3> nested If , 4>Ternarory Operator
             * 
             * Iterational - 1> for , 2> foreach , 3> while , 4> do while
             * 
             * goto , break , continue.
             * 
             */

			//Switch
			
			start:
				 Console.WriteLine("A : Managers ; B : Employees");
				 ConsoleKeyInfo option = Console.ReadKey();

			switch(option.Key.ToString())
			{

				case "A":
					Console.WriteLine("\nManagers : \t Altaf , Krishna");
					break;
				case "B":
					Console.WriteLine("\nEmployees : \t Pradeep , Paresh");
					break;
				default :
					Console.WriteLine("\nEntered Invalid Option");
					goto start;

			}

			// if else & nested if
			start1:
			 Console.WriteLine("A : Managers ; B : Employees");
				 ConsoleKeyInfo option1 = Console.ReadKey();		

			if(option1.Key.ToString() == "A")
			{
				Console.WriteLine("\nManagers : \t Altaf , Krishna");			
			}
			else if(option1.Key.ToString() == "B")
			{
				Console.WriteLine("\nEmployees : \t Pradeep , Paresh");			
			}
			else
			{
				Console.WriteLine("\nEntered Invalid Option");			
				goto start1;
			}
		
			// for 


			
					for(int i=0;i<=10;i++)
					{
						for(int j=10;j >=i;j--)
						{
							Console.Write("\t"+i);
						}
						Console.WriteLine();
					}


					for(int i=0;i<=10;i++)
					{
						for(int j=0;j <=i;j++)
						{
							Console.Write("\t"+i);
						}
						Console.WriteLine();
					}
					Console.WriteLine();		

					for(int i=0;i<=5;i++)
					{
						for(int j=5;j>i;j--)
						{
						Console.Write("\t ");	
						}


						for(int K=0;K<=i;K++)
						{
						Console.Write("\t"+i);	
						}

						for(int l=5;l>=i;l--)
						{
						Console.Write("\t"+l);	
						}

						for(int m=5;m>=i;m--)
						{
						Console.Write("\t -");	
						}

						Console.WriteLine();
					}

			
			
					// foreach
					int[] arr = new int[]{1,2,3,5,6,7,8,45,67,87,875,34,56,34,5,34,57,324,6,5,34,35,65,45};

					foreach(int item in arr)
					{

						Console.WriteLine(item);
					}

			
			
					//while loop
					Console.WriteLine("Enter Length");
					int length = Convert.ToInt32(Console.ReadLine());
					while(length > 0)
					{
					Console.WriteLine("Altaf");
					length--;
					}
					
					//do while


					Console.WriteLine("Enter Length");
					int length1 = Convert.ToInt32(Console.ReadLine());
					do
					{
					Console.WriteLine("Krishna");
					length1--;
					}
					while(length1 > 0);


					int[] arr1 = new int[]{1,2,3,5,6,7,8,45,67,87,875,34,56,34,5,34,57,324,6,5,34,35,65,45};
					int indx = 0;
					do
					{
					Console.WriteLine(arr1[indx]);
					indx++;
					}
					while(arr1.Length > indx);
			

			// continue


			int[] amounts = new int[] { 100, 250, 3000, 5550, 6000, 7000, 88000, 45000, 11000 };
			foreach (int item in amounts)
			{
				if (item < 1000) //{1} not satisy 
				{

					Console.WriteLine("Intrest Percentage for " + item + " is 10%");
					continue;  // directly iterate next item

				}

				if (item < 5000) //{1}satisy but execute only one because of continue statement.
				{

					Console.WriteLine("Intrest Percentage for " + item + " is 12%");
					continue;  // directly iterate next item
				}
				if (item < 10000) //{1}satisy 
				{
					Console.WriteLine("Intrest Percentage for " + item + " is 15%");
					continue;  // directly iterate next item

				}

				if (item > 10000) //{1}satisy 
				{
					Console.WriteLine("Intrest Percentage for " + item + " is 20%");
					continue;  // directly iterate next item

				}

			}


			Console.ReadLine();
		}
	}
}
