using System;

namespace _01._02._23
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 23, 56, 45, 89,-54};
			Console.WriteLine(Sum(nums));
			Console.WriteLine(Power(21,5));
			Console.WriteLine(LetterCount("Nazim"));
			Console.WriteLine(naz("salam"));
			var word = FindFristWord("   Salam Nazim necesen?");
			Console.WriteLine(word);
		}
		//Verilmis ededler siyahisnda musbet edelerin cemini tapan metod
		static int Sum(int[] arr)
		{
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > 0)
					sum += arr[i];
			}
			return sum;

		}
		//Verilmis ededi verilmis quvvete yukselden metod
		static int Power(int num,int pow)
		{
			int result = 1;
			for (int i = 0; i < pow; i++)
			{
				result *= num;
			}
			return result;
		}
	    //Verilmis yazida a charinin sayini tapan metod
         static int LetterCount(string text)
		{
			int count = 0;
				for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == 'a')
					count++;
			}
			return count;
		}
		//Verilmis yazida a charini olub olmamasin tapan metod
		static bool naz(string text)
		{
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == 'a')
				{
					return true;
				}
				
			}
return false;
		}

	//Verilmis yazidaki ilk sozu qaytaran metod
	static string FindFristWord(string str)
		{
			string word = "";
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] == ' ')
					break;
				word += str[i];
			}
			return word;
		}
	}
}
