using System;
using System.ComponentModel.DataAnnotations;

namespace Tapsırıq_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var reverse = Reverse("Nazim");
			Console.WriteLine(reverse);
		}

	}


	static string Reverse(string str)
{
		 string newStr = "";
		 for(int i = str.Length-1;i>0;i--)
		{
			newStr += str[i];
		
		}

	    	return newStr;
	}  

	     
}
