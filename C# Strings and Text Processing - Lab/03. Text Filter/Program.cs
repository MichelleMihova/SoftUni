﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
	class Program
	{
		static void Main(string[] args)
		{
			var word = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			string text = Console.ReadLine();

			foreach (var badWord in word)
			{
				if (text.Contains(badWord))
				{
					text = text.Replace(badWord, new string('*', badWord.Length));
				}
			}
			Console.WriteLine(text);
		}
	}
}
