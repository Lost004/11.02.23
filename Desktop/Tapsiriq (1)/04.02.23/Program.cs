using System;

namespace _04._02._23
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] students = { "Nazim Ibrahimov" };
			string opt;
			do
			{
				Console.WriteLine("\n1.Butun telebelere bax");
				Console.WriteLine("2.Yeni telebe elave et");
				Console.WriteLine("3.Telebeler uzre axtaris et");
				Console.WriteLine("4.Telebelerin adina bax");
				Console.WriteLine("5.Siyahida adin olub olmadigna bax");
				Console.WriteLine("0.Menudan cix");


				Console.WriteLine("\nSecim edin!");
				opt = Console.ReadLine();

				switch (opt)
				{
					case "1":
						for (int i = 0; i < students.Length; i++)
						{
							Console.WriteLine(students[i]);
						}
						break;
					case "2":
						Console.WriteLine("Elave etmek istediyiniz telebeni qeyd edin ");
						string std = Console.ReadLine();
						Array.Resize(ref students, students.Length + 1);
						students[students.Length - 1] = std;

						break;
					case "3":
						Console.WriteLine("Telebeler uzre axtaris et");
						string searchPerson = Console.ReadLine();
						bool isExist = false;
						for (int  i=0; i < students.Length; i++)
						{
							if (students[i].ToLower().Contains(searchPerson) || students[i].ToUpper().Contains(searchPerson))
							{
								Console.WriteLine(students[i]);
								isExist = true;	
							}
						}
						if (isExist == false)
						{
							Console.WriteLine("Bele bir shexs yoxdur,duzgun qeyd edin!");
						}

						break;
					case "4":
						Console.WriteLine("Telebenin adlarina bax");
						for (int i = 0; i < students.Length; i++)
						{
							int index = students[i].IndexOf(' ');
							index = students[i].IndexOf(' ', index - 1);
							string result = students[i].Substring(0, index);
							Console.WriteLine(result);
						}
						break;
					case "5":
						Console.WriteLine("Siyahida adin olub olmadigina bax");
						string daxiledin = Console.ReadLine();
						bool daxilEdilen = false;
						for (int i = 0; i < students.Length; i++)
						{
							if(students[i].ToLower().Contains(daxiledin) || students[i].ToUpper().Contains(daxiledin))
							{
								daxilEdilen = true;
								Console.WriteLine("Var!");
							}
						}
						if (daxilEdilen == false)
						{
							Console.WriteLine("Yoxdur!");
						}

						break;
					case "0":
						Console.WriteLine("Proses bitdi");
						break;
					default:
						Console.WriteLine("Seciminiz yanlisdir,yeniden cehd edin!");
						break;
				}
			} while (opt != "0");

		}
	}
}
