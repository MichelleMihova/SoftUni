using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int current = int.Parse(Console.ReadLine());
			int max = int.Parse(Console.ReadLine());
			int currentE = int.Parse(Console.ReadLine());
			int maxE = int.Parse(Console.ReadLine());

			int change;
			change =max-current ;

			int second;
			second  = maxE - currentE;

			Console.WriteLine("Name: {0}", name);
			Console.Write("Health: |");
			Console.Write(new string('|', current));
			Console.Write(new string('.', change));
			Console.WriteLine('|');

			Console.Write("Energy: |");
			Console.Write(new string('|', currentE));
			Console.Write(new string ('.',second)); 
			Console.WriteLine('|');
		}
	}
}
