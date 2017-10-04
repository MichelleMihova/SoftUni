using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Greater_of_Two_Values
{
	class Program
	{
		static int getMax(int a, int b)
		{
			if (a > b)
			{
				return a;
			}
			else if (a==b)
			{
				return 0;
			}
			else 
			{
				return b;
			}
			
		}
		static char getMax(char a, char b)
		{
			int first=Convert.ToInt16(a);
			int second= Convert.ToInt16(b);
			if (first > second)
			{
				return a;
			}
			else
			{
				return b;
			}
		}
		static string getMax (string a, string b)
		{
			/*int first = a.Length;
			int second = b.Length;*/
			if (a.CompareTo(b)>0)
			{
				return a;
			}
			else if (a.CompareTo(b) ==0)
			{
				return "0";
			}
			else 
			{
				return b;
			}
		}

		static void Main(string[] args)
		{
			string whatType = Console.ReadLine();
			if (whatType=="int")
			{
				int first = int.Parse(Console.ReadLine());
				int second = int.Parse(Console.ReadLine());
				int maxIs = getMax(first, second);
				Console.WriteLine(maxIs);
			}
			else if (whatType == "string")
			{
				string first = Console.ReadLine();
				string second =Console.ReadLine();
				string maxIs = getMax(first, second);
				Console.WriteLine(maxIs);
			}
			if (whatType == "char")
			{
				char first = char.Parse(Console.ReadLine());
				char second = char.Parse(Console.ReadLine());
				char maxIs = getMax(first, second);
				Console.WriteLine(maxIs);
			}
		}
	}
}
