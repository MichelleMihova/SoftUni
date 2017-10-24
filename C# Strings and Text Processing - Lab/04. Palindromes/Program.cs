using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
	class Program
	{
		static void Main(string[] args)
		{
			var words = Console.ReadLine().Split(new char[] { ' ', ',','.','?','!' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			List<string> all = new List<string>();
			foreach (var item in words)
			{
				var newItem=item.ToCharArray();
				
					for (int i = 0; i < newItem.Length / 2; i++)
					{
						if (newItem[i] == newItem[newItem.Length - i - 1])
						{
							all.Add(item);
							break;
						}
					}
				if (newItem.Length == 1)
				{
					all.Add(item);
				}
			}
			all.Sort();
			Console.WriteLine("{0}", string.Join(", ", all.Distinct()));
		}
	}
}
