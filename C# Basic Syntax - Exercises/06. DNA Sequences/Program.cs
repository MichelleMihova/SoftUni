using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
	class Program
	{
		static void Main(string[] args)
		{
			int Num = int.Parse(Console.ReadLine());
			int count = 0;
			int sum = 0;

			for (char i = 'A' ; i <= 'T'; i++)
			{
				for (char j =  'A'; j <= 'T'; j++)
				{
					for (char k = 'A'; k <='T'; k++)
					{
						if ((i == 'A' || i == 'C' || i == 'G' || i == 'T') &&
						   (j == 'A' || j == 'C' || j == 'G' || j == 'T') &&
						   (k == 'A' || k == 'C' || k == 'G' || k == 'T'))
						{
							if (i == 'A')
							{
								sum = sum + 1;
								if (j == 'A')
								{
									sum = sum + 1;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
								else if (j == 'C')
								{
									sum = sum + 2;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
								else if (j == 'G')
								{
									sum = sum + 3;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
								else if (j == 'T')
								{
									sum = sum + 4;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
							}
							else if (i == 'C')
							{
								sum = sum + 2;
								if (j == 'A')
								{
									sum = sum + 1;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
								else if (j == 'C')
								{
									sum = sum + 2;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
								else if (j == 'G')
								{
									sum = sum + 3;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
								}
								else if (j == 'T')
								{
									sum = sum + 4;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
							}
							else if (i == 'G')
							{
								sum = sum + 3;
								if (j == 'A')
								{
									sum = sum + 1;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
								else if (j == 'C')
								{
									sum = sum + 2;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
								else if (j == 'G')
								{
									sum = sum + 3;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
								else if (j == 'T')
								{
									sum = sum + 4;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
							}
							else if (i == 'T')
							{
								sum = sum + 4;
								if (j == 'A')
								{
									sum = sum + 1;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
								else if (j == 'C')
								{
									sum = sum + 2;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
								else if (j == 'G')
								{
									sum = sum + 3;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
								else if (j == 'T')
								{
									sum = sum + 4;
									if (k == 'A')
									{
										sum = sum + 1;
									}
									else if (k == 'C')
									{
										sum = sum + 2;
									}
									else if (k == 'G')
									{
										sum = sum + 3;
									}
									else if (k == 'T')
									{
										sum = sum + 4;
									}
									
								}
							}

							if (sum>= Num)
							{
								if (count==4)
								{
									count = 0;
									Console.WriteLine();
									Console.Write("O");
									Console.Write("{0}{1}{2}", i, j, k);
									Console.Write("O ");
								}
								else
								{
									Console.Write("O");
									Console.Write("{0}{1}{2}", i, j, k);
									Console.Write("O ");
								}
								
							}
							else
							{
								if (count==4)
								{
									count = 0;
									Console.WriteLine();
									Console.Write("X");
									Console.Write("{0}{1}{2}", i, j, k);
									Console.Write("X ");
								}
								else
								{
									Console.Write("X");
									Console.Write("{0}{1}{2}", i, j, k);
									Console.Write("X ");
								}
								
							}
							sum = 0;
							count++;
						}
					}
				}
			}
			Console.WriteLine();

			
		}
	}
}
