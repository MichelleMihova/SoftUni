using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Lab
{
	class Program
	{
		static void printingTheHeader()
		{
			Console.WriteLine("CASH RECEIPT");
			Console.WriteLine("------------------------------");
		}
		static void body()
		{
			Console.WriteLine("Charged to____________________");
			Console.WriteLine("Received by___________________");
		}
		static void foother()
		{
			Console.WriteLine("------------------------------");
			Console.WriteLine("\u00A9 SoftUni");
		}
		static void Main(string[] args)
		{
			printingTheHeader();
			body();
			foother();
		}
	}
}
