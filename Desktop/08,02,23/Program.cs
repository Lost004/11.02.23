
   using System;

namespace _08_02_23
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Employee emp1 = new Employee();
			emp1.Fullname = "Nihat Eliyev";
			emp1.Salary = 250;

			Console.WriteLine("Muhendis sayi");
			int count = Convert.ToInt32(Console.ReadLine());

			Enginer[] enginers = new Enginer[count];
			for (int  i= 0; i< count; i++)
			{
				Console.WriteLine("Ad daxiledin!");
				string Name = Console.ReadLine();

				
			}

		}
	}
}
