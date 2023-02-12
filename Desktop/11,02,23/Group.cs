using System;
using System.Collections.Generic;
using System.Text;

namespace _11_02_23
{
	internal class Group
	{
		string _no;
    	public	double AvgPoint;
        
		public string No
		{
			get
			{
				return _no;
			}
			set
			{
				if (value.Length > 3 && char.IsUpper(value[0]))
				{
					_no = value;
				}
				else
				{
					Console.WriteLine("Boyuk herfle basliyib 3 reqemle devam etmelidi!");
				}
					
			}
			
		}
	}
}
