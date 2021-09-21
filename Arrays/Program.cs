using System;

namespace arraysnm
{

	class Program
	{

		static void Main()
		{
			/*
			Single Dimensional Array
			*/
			string[] strarr = new string[] { "krishna", "Ravi", "Bharath", "Atul" };
			foreach (string item in strarr)
			{
				Console.Write(item.ToString() + "\t");
			}
			Console.WriteLine("");
			string[] arr1 = new string[5];
			arr1[0] = "Hello1";
			arr1[1] = "Hello2";
			arr1[2] = "Hello3";
			arr1[3] = "Hello4";
			arr1[4] = "Hello5";

			foreach (string item in arr1)
			{
				Console.Write(item.ToString() + "\t");
			}
			Console.WriteLine("");
			/*
Multi Dimensional Dimensional Array
*/
			int[,] intarr = new int[3, 3]{
							{11,12,13},
							{21,22,23},
							{31,32,33}
							 };

			foreach (int item in intarr)
			{
				Console.Write(item.ToString() + "\t");
			}
			Console.WriteLine("");
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write(intarr[i, j] + "\t");
				}
				Console.WriteLine(" ");
			}

			/*
				Sorting Array
			*/
			int[] numarr = new int[] { 32, 4, 45, 23, 78, 7, 56, 77, 88, 55, 887, 999, 778, 87, 8878, 6565, 98, 79, 797, 78979, 809, 89 };
			Console.WriteLine("Before Sorting Array");
			Console.WriteLine("");
			foreach (int item in numarr)
			{
				Console.Write(item.ToString() + "\t");
			}
			Console.WriteLine("");
			Console.WriteLine("Sorted Array");
			Array.Sort(numarr);
			Console.WriteLine("");
			foreach (int item in numarr)
			{
				Console.Write(item.ToString() + "\t");
			}
			Console.WriteLine("");
			Console.WriteLine("Reverse Array");
			Array.Reverse(numarr);
			Console.WriteLine("");
			foreach (int item in numarr)
			{
				Console.Write(item.ToString() + "\t");
			}
			Console.WriteLine("");
			/*
				Jagged Array
			*/
			int[][] jgarr = new int[2][];
			jgarr[0] = new int[2] { 11, 12 };
			jgarr[1] = new int[3] { 21, 22, 23 };
			foreach (int[] itemarr in jgarr)
			{
				foreach (int item in itemarr)
				{
					Console.Write(item.ToString() + "\t");
				}
				Console.WriteLine(" ");
			}




			Program program = new Program();

			/*
				Params in Array
			*/
		
			program.PrintParamArray(1,5,14,54,54,5,487,85,5,85,87,7,45,484,4,548,45,484,45);

		}
		private  void PrintParamArray(params int[] pararr)
		{
			int sum = 0;

			foreach (int item in pararr)
			{
				sum = sum + item;
			}
			Console.Write("Sum is" + "\t" + sum);

		}

	}


}
