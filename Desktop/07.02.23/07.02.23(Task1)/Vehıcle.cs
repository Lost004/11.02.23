using System;
using System.Collections.Generic;
using System.Text;

namespace _07_02_23
{
	internal class Vehıcle
	{
     public Vehıcle(string brand,string model)
		{
			Brand = brand;
			Model = model;
		}
		public string Brand; 
		public string Model;

     public virtual void ShowInfo()
		{
			Console.WriteLine($"Model:{Model}-Brand:{Brand}");
		}
	}
}
