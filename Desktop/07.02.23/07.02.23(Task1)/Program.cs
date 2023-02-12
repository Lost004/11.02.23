using System;

namespace _07_02_23
{
	internal class Program
	{
		
		static void Main(string[] args)
		{
			Car cr1 = new Car("Bmw", "F30")
			{
				Millage = 200000,
				FuelCapacity= 100,
		    };
			Bıcycle bycl1 = new Bıcycle("Kron", "GERONI")
			{
				Millage = 200,
			};
			cr1.ShowInfo();
			bycl1.ShowInfo();
		}
	}
}
