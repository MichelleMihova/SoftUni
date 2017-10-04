using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
	class Program
	{
		static void headerAndFother(int number)
		{
			Console.Write(new string('-',number*2));
			Console.WriteLine();
		}
		static void body(int number)
		{
			for (int i = 1; i <= number-2; i++)
			{
				Console.Write('-');
				for (int j = 1; j <= ((number * 2 - 2) / 2); j++)
				{
					Console.Write("\\/");
				}
				Console.Write('-');
				Console.WriteLine();
			}
		}
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			headerAndFother(number);
			body(number);
			headerAndFother(number);
		}
	}
}
