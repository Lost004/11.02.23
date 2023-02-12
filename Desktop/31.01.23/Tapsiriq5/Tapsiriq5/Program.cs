 using System;

namespace Tapsiriq5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = (17, 48, 79, 86, 15);
			var sumOfArr = Sum(numbers);
			Console.WriteLine(sumOfArr);
			
			static int Sum(int[] numbers)
			{
				int sum = 0;
				for (int i = 0; i < numbers.Length; i++)
					
				{
					sum += numbers[i];
				}
			}
		}
	}
}
