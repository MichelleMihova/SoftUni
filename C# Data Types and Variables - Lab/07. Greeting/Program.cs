﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greeting
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstName = Console.ReadLine();
			string secondName = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());

			Console.WriteLine("Hello, {0} {1}. You are {2} years old.",firstName ,secondName,age);
		}
	}
}
