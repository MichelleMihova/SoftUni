using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
	class Program
	{
		static int GetMax(int a, int b, int c)
		{
			if (a > b)
			{
				if (a>c)
				{
					return a;
				}
				else
				{
					return c;
				}
			}
			else
			{
				if (b>c)
				{
					return b;
				}
				else
				{
					return c;
				}
			}
		}
		static void Main(string[] args)
		{
			int first = int.Parse(Console.ReadLine());
			int second = int.Parse(Console.ReadLine());
			int third = int.Parse(Console.ReadLine());
			int max = GetMax(first,second,third );
			Console.WriteLine(max);
		}
	}
}
