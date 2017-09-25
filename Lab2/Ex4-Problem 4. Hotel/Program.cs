using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Problem_4.Hotel
{
	class Program
	{
		static void Main(string[] args)
		{
			string month = Console.ReadLine();
			int nightCounts = int.Parse(Console.ReadLine());
			double studio;
			double doubleroom;
			double suite;

			if (month== "May" || month=="October")
			{
				studio = 50;
				doubleroom = 65;
				suite =75;
				if (month == "October")
				{
					if (nightCounts > 7)
					{
						studio = studio * (nightCounts - 1);
						studio = studio - (studio * 5 / 100);
						doubleroom = doubleroom * nightCounts;
						suite = suite * nightCounts;
						Console.WriteLine("Studio: {0:F2} lv.", studio);
						Console.WriteLine("Double: {0:F2} lv.", doubleroom);
						Console.WriteLine("Suite: {0:F2} lv.", suite);
						return;
					}
					else
					{
						studio = studio * nightCounts;
						doubleroom = doubleroom * nightCounts;
						suite = suite * nightCounts;
						Console.WriteLine("Studio: {0:F2} lv.", studio);
						Console.WriteLine("Double: {0:F2} lv.", doubleroom);
						Console.WriteLine("Suite: {0:F2} lv.", suite);
					}

				}
				else if (nightCounts > 7)
				{
					studio = studio * nightCounts;
					studio = studio - (studio * 5 / 100);
					doubleroom = doubleroom * nightCounts;
					suite = suite * nightCounts;
					Console.WriteLine("Studio: {0:F2} lv.", studio);
					Console.WriteLine("Double: {0:F2} lv.", doubleroom);
					Console.WriteLine("Suite: {0:F2} lv.", suite);
				}
				else
				{
					studio = studio * nightCounts;
					doubleroom = doubleroom * nightCounts;
					suite = suite * nightCounts;
					Console.WriteLine("Studio: {0:F2} lv.", studio);
					Console.WriteLine("Double: {0:F2} lv.", doubleroom);
					Console.WriteLine("Suite: {0:F2} lv.", suite);
				}
			}
			else if (month == "June" || month == "September" )
			{
				studio = 60;
				doubleroom = 72;
				suite = 82;
				if (month == "September")
				{
					if (nightCounts > 7)
					{
						studio = studio * (nightCounts - 1);
						doubleroom = doubleroom * nightCounts;
						suite = suite * nightCounts;
						Console.WriteLine("Studio: {0:F2} lv.", studio);
						Console.WriteLine("Double: {0:F2} lv.", doubleroom);
						Console.WriteLine("Suite: {0:F2} lv.", suite);
						return;
					}
					else
					{
						studio = studio * nightCounts;
						doubleroom = doubleroom * nightCounts;
						suite = suite * nightCounts;
						Console.WriteLine("Studio: {0:F2} lv.", studio);
						Console.WriteLine("Double: {0:F2} lv.", doubleroom);
						Console.WriteLine("Suite: {0:F2} lv.", suite);
					}
				}
				if (nightCounts > 14)
				{
					studio = studio * nightCounts;
					doubleroom = doubleroom * nightCounts;
					doubleroom = doubleroom - (doubleroom * 10/ 100);
					suite = suite * nightCounts;
					Console.WriteLine("Studio: {0:F2} lv.", studio);
					Console.WriteLine("Double: {0:F2} lv.", doubleroom);
					Console.WriteLine("Suite: {0:F2} lv.", suite);
				}
				else
				{
					studio = studio * nightCounts;
					doubleroom = doubleroom * nightCounts;
					suite = suite * nightCounts;
					Console.WriteLine("Studio: {0:F2} lv.", studio);
					Console.WriteLine("Double: {0:F2} lv.", doubleroom);
					Console.WriteLine("Suite: {0:F2} lv.", suite);
				}
			}
			else if (month == "July" || month == "August" || month=="December")
			{
				studio = 68;
				doubleroom = 77;
				suite = 89;
				if (nightCounts > 14)
				{
					studio = studio * nightCounts;
					doubleroom = doubleroom * nightCounts;
					suite = suite * nightCounts;
					suite = suite - (suite * 15 / 100);
					
					Console.WriteLine("Studio: {0:F2} lv.", studio);
					Console.WriteLine("Double: {0:F2} lv.", doubleroom);
					Console.WriteLine("Suite: {0:F2} lv.", suite);
				}
				else
				{
					studio = studio * nightCounts;
					doubleroom = doubleroom * nightCounts;
					suite = suite * nightCounts;
					Console.WriteLine("Studio: {0:F2} lv.", studio);
					Console.WriteLine("Double: {0:F2} lv.", doubleroom);
					Console.WriteLine("Suite: {0:F2} lv.", suite);
				}
			}
		}
	}
}
