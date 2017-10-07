using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
	class Program
	{
		static string NameOfLastDigit(string number)
		{
			//int lastDigit =Convert.ToInt16( number) % 10;
			string lastDigit = number.Substring(number.Length - 1, 1);

			if (lastDigit=="0")
			{

				return "zero";
			}
			else if (lastDigit=="1")
			{
				return "one";
			}
			else if (lastDigit == "2")
			{
				return "two";
			}
			else if (lastDigit == "3")
			{
				return "three";
			}
			else if (lastDigit == "4")
			{
				return "four";
			}
			else if (lastDigit == "5")
			{
				return "five";
			}
			else if (lastDigit == "6")
			{
				return "six";
			}
			else if (lastDigit == "7")
			{
				return "seven";
			}
			else if (lastDigit == "8")
			{
				return "eight";
			}
			else
			{
				return "nine";
			}
		}
		static void Main(string[] args)
		{
			long number = long.Parse(Console.ReadLine());
			string lastDigit = Convert.ToString(number);
			string name=NameOfLastDigit(lastDigit);
			Console.WriteLine(name);
		}
	}
}
