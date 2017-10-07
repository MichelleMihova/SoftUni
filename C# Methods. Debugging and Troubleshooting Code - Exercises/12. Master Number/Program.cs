using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
	class Program
	{
		static bool IsPalindrome(int number)
		{
			string str = number.ToString();
			if (str.Length < 4 && str[0] == str[str.Length - 1])
			{
				return true;
			}
			else if (str.Length < 6 &&
				(str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2]))
			{
				return true;
			}
			else if (str.Length < 8 &&
			   (str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2]
			   && str[2] == str[str.Length - 3]))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static bool SumOfDigits(int num)
		{
			int sum=0;
			int digit = num.ToString().Count();
			int n = num;
			for (int j = 1; j <= digit; j++)
			{
				sum += n % 10;
				n /= 10;
			}
			if (sum % 7 == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		static bool ContainsEvenDigit(int num)
		{
			int digit = num.ToString().Count();
			int n = num;
			int number = 0;
			for (int j = 1; j <= digit; j++)
			{
				number = n % 10;
				n /= 10;
				if (number % 2 == 0)
				{
					return true;
				}
			}
			return false;
		}

		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			for (int i = 1; i < number; i++)
			{
				if (IsPalindrome(i) == true && SumOfDigits(i) == true
					&& ContainsEvenDigit(i) == true)
				{
					Console.WriteLine(i);
				}
			}
		}
		
	}
}
