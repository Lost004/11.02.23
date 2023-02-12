using System;

namespace _30._01._2023
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var result = Sum(34,78);
			Console.WriteLine(result);
		}
		 static int Sum(int num1,int num2)
		{
		
		    var result = num1 + num2;
			return result; 
	    }
	}
}
