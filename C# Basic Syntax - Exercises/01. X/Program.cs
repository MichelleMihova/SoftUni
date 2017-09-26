using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab
{
	class Program
	{
		static void Main(string[] args)
		{
			int first =int.Parse(Console.ReadLine());
			int second = int.Parse(Console.ReadLine());
			int third = int.Parse(Console.ReadLine());
			int fourth = int.Parse(Console.ReadLine());
			Console.Write("{0:D4} {1:D4} {2:D4} {3:D4}", first, second, third, fourth);
		}
	}
}
