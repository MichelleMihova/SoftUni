using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Exercises
{
	class Program
	{
		static string Name(string name)
		{
			return name;
		}
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			Console.WriteLine("Hello, {0}!",Name(name));
		}
	}
}
