using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
	class Program
	{
		static void Main(string[] args)
		{
			char something = char.Parse(Console.ReadLine());
			if (something == 'a' || something =='o'||something=='u'||something=='e'||something=='i')
			{
				Console.WriteLine("vowel");
			}
			else if (something>='0' && something<='9')
			{
				Console.WriteLine("digit");
			}
			else
			{
				Console.WriteLine("other");
			}
				
			
			
		}
	}
}
