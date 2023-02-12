 using System;

namespace _07._02._23_Task_2_
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Tarix daxil edin");
			string dateStr = Console.ReadLine();
			DateTime date= Convert.ToDateTime(dateStr);
			


			Console.WriteLine("Il daxil edin!");
			string dateStr2 = Console.ReadLine();
			var date1 = Convert.ToInt32(dateStr2);



			date = date.AddYears(date1);
			Console.WriteLine(date.ToString("dddd-MMMM-yyyy HH:MM"));
		
		}
	}
}
