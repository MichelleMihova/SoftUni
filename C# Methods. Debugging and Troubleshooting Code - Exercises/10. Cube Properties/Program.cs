
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
	class Program
	{
		static void Main(string[] args)
		{
			double size = double.Parse(Console.ReadLine());
			string type = Console.ReadLine();

			if (type=="face")
			{
				double face = Math.Sqrt(2*Math.Pow(size,2));
				Console.WriteLine("{0:F2}", face);

			}
			else if (type=="space")
			{
				double space = Math.Sqrt(3 * Math.Pow(size, 2));
				Console.WriteLine("{0:F2}",space);
			}
			else if (type=="volume")
			{
				double volume = Math.Pow(size, 3);
				Console.WriteLine("{0:F2}",volume);
			}
			else if (type=="area")
			{
				double area = 6 *Math.Pow(size,2);
				Console.WriteLine("{0:F2}",area);
			}
		}
	}
}
