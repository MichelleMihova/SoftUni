using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			int sum = 0;

			for (int i=1; i<=10;i++)
			{
				sum = num * i;
				Console.WriteLine("{0} X {1} = {2}", num, i, sum);
			}
		}
	}
}
