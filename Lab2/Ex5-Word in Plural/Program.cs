using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Word_in_Plural
{
	class Program
	{
		static void Main(string[] args){
			string noun = Console.ReadLine();
			if (noun.EndsWith("y"))
			{
				string res = noun.Remove(noun.Length - 1);
				res = res + "ies";
				Console.WriteLine(res);

			}
			else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh")
				|| noun.EndsWith("x") || noun.EndsWith("z"))
			{
				//string res = noun.Remove(noun.Length - 1);
				noun = noun + "es";
				Console.WriteLine(noun);
			}
			else
			{
				noun = noun + "s";
				Console.WriteLine(noun);
			}
		}
	}
}
