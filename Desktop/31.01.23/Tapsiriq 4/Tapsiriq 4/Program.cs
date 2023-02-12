using System;

namespace Tapsiriq_4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var result=Sum(56,87);
			Console.WriteLine(result);

		}
		static int Sum(int num1, int num2)
		{

		    var result = num1 + num2;
			return result;
		}
	}
}
