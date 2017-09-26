using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine().ToLower();

			if (name == "england" || name == "usa")
			{
				Console.WriteLine("English");
			}
		    else if ( name=="spain" || name== "argentina" || name=="mexico")
			{
				Console.WriteLine("Spanish");
			}
			else
				Console.WriteLine("unknown");
		}
	}
}
