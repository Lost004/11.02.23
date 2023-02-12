using System;
using System.Collections.Generic;
using System.Text;

namespace _08_02_23
{
	internal class Employee
	{
		public string Fullname;
		protected int  _salary;

		public virtual int Salary
		{
			get
			{
				return _salary;
			}
			set
			{
				if (value >= 300)
					_salary = value;

			}
		}
		public void ShowInfo()
		{
			Console.WriteLine($"Fulanme:{Fullname}-Salary:{Salary}");
		}
	}
}
