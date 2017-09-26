using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.SMS_Typing
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfCharacters = int.Parse(Console.ReadLine());
			for (int i = 1; i <= numberOfCharacters ; i++)
			{
				int numberOfSymbol = int.Parse(Console.ReadLine());
				if (numberOfSymbol == 0)
				{
					Console.Write(' ');
				}
				else if (numberOfSymbol>1 && numberOfSymbol<10)
				{
					switch (numberOfSymbol)
					{
						case 1:
						case 2:
							Console.Write('a');
							break;
						case 3:
							Console.Write('d');
							break;
						case 4:
							Console.Write('g');
							break;
						case 5:
							Console.Write('j');
							break;
						case 6:
							Console.Write('m');
							break;
						case 7:
							Console.Write('p');
							break;
						case 8:
							Console.Write('t');
							break;
						case 9:
							Console.Write('w');
							break;
					}
				}
				else if (numberOfSymbol >10 && numberOfSymbol <100)
				{
					switch (numberOfSymbol)
					{
						case 22:
							Console.Write('b');
							break;
						case 33:
							Console.Write('e');
							break;
						case 44:
							Console.Write('h');
							break;
						case 55:
							Console.Write('k');
							break;
						case 66:
							Console.Write('n');
							break;
						case 77:
							Console.Write('q');
							break;
						case 88:
							Console.Write('u');
							break;
						case 99:
							Console.Write('x');
							break;
					}
				}
				else if(numberOfSymbol > 100 && numberOfSymbol <1000)
				{
					switch (numberOfSymbol)
					{
						case 222:
							Console.Write('c');
							break;
						case 333:
							Console.Write('f');
							break;
						case 444:
							Console.Write('i');
							break;
						case 555:
							Console.Write('l');
							break;
						case 666:
							Console.Write('o');
							break;
						case 777:
							Console.Write('r');
							break;
						case 888:
							Console.Write('v');
							break;
						case 999:
							Console.Write('y');
							break;
					}
				}
				else if (numberOfSymbol>1000)
				{
					switch (numberOfSymbol)
					{
						case 7777:
							Console.Write('s');
							break;
						case 9999:
							Console.Write('z');
							break;
					}
				}
			}

		}
	}
}
