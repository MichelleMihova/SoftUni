using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Magic_Letter
{
	class Program
	{
		static void Main(string[] args)
		{
			char first = char.Parse( Console.ReadLine());
			char second = char.Parse(Console.ReadLine());
			char containing = char.Parse(Console.ReadLine());
			int count = 0;
			//int secondcount = 0;

			for (char i = first; i <= second; i++)
			{
				for (char j = first; j <= second; j++)
				{
					for (char k = first; k <= second; k++)
					{
						//Console.WriteLine("{0}{1}{2}",i,j,k);
						count++;
						if (i != containing && j != containing && k != containing)
						{
							//secondcount++;
							Console.Write("{0}{1}{2} ",i,j,k);
						}
						
					}
				}
			}
			Console.WriteLine(count);
			//Console.WriteLine(secondcount);
		}
	}
}
