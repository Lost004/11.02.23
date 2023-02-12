using System;
using System.Diagnostics.CodeAnalysis;

namespace Tapsırıq_3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var digitSum = reqemcem(7890);
			Console.WriteLine(digitSum);
		}
		static int reqemcem(int n)
		{
			
			int sum = 0;
			while(n>0)
			{
				sum += n % 10;
				n /= 10;
            }
			return sum;

		}
	}
}
