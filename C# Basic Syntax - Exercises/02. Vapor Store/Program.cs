using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
	class Program
	{
		static void Main(string[] args)
		{
			float widht =float.Parse(Console.ReadLine());
			float height = float.Parse(Console.ReadLine());
			float sum;
			sum = widht * height;
			Console.WriteLine("{0:F2}",sum);
		}
	}
}
