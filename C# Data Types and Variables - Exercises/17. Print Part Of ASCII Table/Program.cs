using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstInput = Console.ReadLine();
			string secondInput = Console.ReadLine();
			int startCharacter;
			int lastCharacter;

			if (Int32.TryParse(firstInput, out startCharacter)&& Int32.TryParse(secondInput, out lastCharacter))
			{
				if (startCharacter>=0 && lastCharacter<128 )
				{
					char one = (char)startCharacter;
					//Console.WriteLine(one);
					char two = (char)lastCharacter;
					for (char i = one; i <= two; i++)
					{
						Console.Write("{0} ",i);
					}
					
					//Console.WriteLine(two);
				}
			}
			Console.WriteLine();
		}
	}
}
