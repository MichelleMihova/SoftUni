using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Problem_11._5_Different_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			if ((b-a)<5)
			{
				Console.WriteLine("No");
			}
			else
			{
				for (int i = a; i <=b; i++)
				{
					for (int j = i; j <= b; j++)
					{
						for (int k = j; k <=b; k++)
						{
							for (int l = k; l <= b; l++)
							{
								for (int o = l; o <= b; o++)
								{
									if (i < j && j < k && k < l && l < o)
									{

										Console.WriteLine("{0} {1} {2} {3} {4} ", i, j, k, l, o);
									}
								}
								//Console.Write("{0} ", l);
							}
							//Console.Write("{0} ", k);
						}
						//Console.Write("{0} ",j);
					}
					
				}
				
			}
		}
	}
}
