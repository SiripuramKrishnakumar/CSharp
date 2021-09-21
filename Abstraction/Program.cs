using System;

namespace Abstraction
{
	public class Program
	{
		static void Main()
		{
			Mercedece merc = new Mercedece();
			merc.Colors();
			merc.Model();
			merc.Gears();
			merc.Wheels();
			//merc.ImportLicence(); // 'Car.ImportLicence()' is inaccessible due to its protection level

			RollsRoyse rsr = new RollsRoyse();
			rsr.Colors();
			rsr.Model();
			rsr.Gears();
			rsr.Wheels();
			//rsr.ImportLicence(); // 'Car.ImportLicence()' is inaccessible due to its protection level

		}
	}
	abstract class Car
	{
		private void ImportLicence()
		{
			Console.WriteLine("ASUID654643753");			
		}
		public abstract void Colors();
		
		public abstract void Model();
		
		public void Wheels()
		{
			Console.WriteLine("No of wheels 4");
		}
		
		public void Gears()
		{
			Console.WriteLine("No of Gears 5");
		}
	}
	class Mercedece : Car
	{
		public override void Colors()
		{
			Console.WriteLine("Available Colors are Red , White , Blue");
		}
		public override void Model()
		{
			Console.WriteLine("Available Model are S001, A008 , V2321");
		}
	
	}
	class RollsRoyse: Car
	{
		public override void Colors()
		{
			Console.WriteLine("Available Colors are Red , White , Blue,Brown, Pink");
		}
		public override void Model()
		{
			Console.WriteLine("Available Model are SAD001, AVF008 , VHS2321");
		}
	
	}
	

}