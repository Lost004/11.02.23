using System;
using System.Collections.Generic;
using System.Text;

namespace _07_02_23
{
	internal class Car: Vehıcle
	{
		public Car( string brand,string model):base(brand,model)
		{

		}
		public int Millage;
		public int FuelCapacity;

		public override void ShowInfo()
		{
			Console.WriteLine($"Model:{Model}-Brand:{Brand}-Millage:{Millage}-FuelCapacity:{FuelCapacity}");
		}
	}
}
