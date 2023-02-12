using System;
using System.Collections.Generic;
using System.Text;

namespace _08_02_23
{
	internal class Enginer:Employee
	{
		public override int Salary
		{
			get
			{
				return _salary;
			}
			set
			{
				if (value >= 1000)
					_salary = value;
			}

	    	}
		}
	
	}
}
