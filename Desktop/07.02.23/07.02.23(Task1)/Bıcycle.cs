using System;
using System.Collections.Generic;
using System.Text;

namespace _07_02_23
{
	internal class Bıcycle:Vehıcle
	{

		public Bıcycle(string model,string brand):base(brand,model)
		{

		}
		public int Millage;
		public virtual void ShowInfo()
		{
			Console.WriteLine($"Model:{Model}-Brand:{Brand}-Millage:{Millage}");
		}

	}
}
