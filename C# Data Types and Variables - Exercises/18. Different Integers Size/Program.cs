using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string m = Console.ReadLine();
			try
			{
				long n = long.Parse(m);
				if (n >= -9223372036854775808 && n <= 9223372036854775807)
				{
					Console.WriteLine("{0} can fit in:", n);

					if (n >= 0 && n <= 4294967295)
					{
						if (n >= 0 && n <= 2147483647)
						{
							if (n >= 0 && n <= 65535)
							{
								if (n >= 0 && n <= 32767)
								{
									if (n >= 0 && n <= 255)
									{
										if (n >= 0 && n <= 127)
										{
											Console.WriteLine("* sbyte");
										}
										Console.WriteLine("* byte");
									}
									Console.WriteLine("* short");
								}
								Console.WriteLine("* ushort");
							}
							Console.WriteLine("* int");
						}
						Console.WriteLine("* uint");
					}
					else if (n >= -2147483648 && n <= 2147483647)
					{
						if (n >= -32768 && n <= 32767)
						{
							if (n >= -128 && n <= 127)
							{
								/*if (n >= 0 && n <= 127)
								{
								Console.WriteLine("* byte");
								//byte
								}*/
								Console.WriteLine("* sbyte");
							}
							Console.WriteLine("* short");
						}
						Console.WriteLine("* int");
					}
					Console.WriteLine("* long");
				}
			}
			catch (Exception)
			{
				//Console.WriteLine(m);
				//Console.WriteLine(n);
				Console.WriteLine("{0} can't fit in any type", m);
			}
		}
	}
}
