using System;
using System.Collections.Generic;
using System.Text;

namespace _06_02_23
{
	internal class Notebook
	{
		public string Brand;
		public string Model;
		public string price;

		public Notebook(string brand, string model, int price)
		{
			Console.WriteLine("Axtardiginiz melumatlari qeyd edin!");
			Brand = brand;
			Model = model;
			Price = price;
		}
		public string brand;
		public string model;
		public int Price;

		public void showinfo()
		{
			Console.WriteLine($"Brand : {Brand} - Model : {Model} - Price: {Price}");
		}
	}
}
