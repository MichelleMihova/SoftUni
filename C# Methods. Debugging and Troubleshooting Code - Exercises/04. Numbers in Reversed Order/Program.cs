using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
	class Program
	{
		static string ReveredNumber(string number)
		{
			
			char[] cArray = number.ToCharArray();
			string reverse = String.Empty;
			for (int i = cArray.Length - 1; i > -1; i--)
			{
				reverse += cArray[i];
			}
			return reverse;
		}
		static void Main(string[] args)
		{
			double number = double.Parse(Console.ReadLine());
			string newNumber=number.ToString();
			string rev=ReveredNumber(newNumber);
			Console.WriteLine(rev);
		}
	}
}
