using System;
using System.Xml.Schema;

namespace _06_02_23
{
	internal class Program
	{
		static void Main(string[] args)
		{
		 Notebook ntd1=	new Notebook("Asus","Zenbook Pro 16x",2900);
			
			ntd1.showinfo();

			Notebook ntd2 = new Notebook("Monster", "Markut M7",9999);
			
			ntd2.showinfo();

			Notebook[] arr = new Notebook[] { ntd1, ntd2 };
			var dubble = 0;
			var count = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				dubble += arr[i].Price;
				count++;

			}

			Console.WriteLine($"Qiymetlerin ortalama deyeri: {dubble /count}");
			
		}
	}
}
