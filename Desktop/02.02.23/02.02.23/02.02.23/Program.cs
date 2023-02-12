using System;

namespace _02._02._23
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 14, 45, 56, 64 };
			Console.WriteLine(5);
			//verilmis yazda reqem olub olmadgin tapan metod.gonderilen yazda reqem varsa true varsa true yoxdursa false qaytar
			Console.WriteLine(char.IsDigit('2'));
		}
		//Verilmis int array e verilmis int deyeri elave eden metod....
		static int[] Add(int[] arr,int value)
		{
			int[] newArr = new int[arr.Length + 1];
			for (int i=0; i<arr.Length; i++)
			{
				newArr[i] = arr[i];
			}
			newArr[newArr.Length - 1] = value;
			return newArr;
		}
		
		
	}
}
