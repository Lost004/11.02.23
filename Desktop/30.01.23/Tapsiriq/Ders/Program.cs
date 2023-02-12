using System;

namespace Ders
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bir eded yazin!");
			int n = Convert.ToInt32(Console.ReadLine());
			int Cem = 0;
			for (int i = 0; i < n; i++)
			{
				Cem += i;
			}
			Console.WriteLine("1 den'" + n + "reqemine qeder olan sayilarin toplami = " + Cem);
			Console.ReadLine();
		}
	}
}
