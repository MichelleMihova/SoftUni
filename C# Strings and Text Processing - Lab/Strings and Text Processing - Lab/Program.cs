using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Text_Processing___Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			var text = Console.ReadLine();
			var revText = text.Reverse().ToArray();
			foreach (var item in revText)
			{
				Console.Write(item);
			}
			Console.WriteLine();
			
		}
	}
}
