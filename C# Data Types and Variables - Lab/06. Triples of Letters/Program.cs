﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Letters
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			char letter = (char)('a' + n);
			for (char i = 'a'; i < letter; i++)
			{
				for (char j = 'a'; j < letter; j++)
				{
					for (char k = 'a'; k < letter; k++)
					{
						Console.WriteLine("{0}{1}{2}",i,j,k);
					}
				}
				
			}
			//Console.WriteLine();
			
		}
	}
}
