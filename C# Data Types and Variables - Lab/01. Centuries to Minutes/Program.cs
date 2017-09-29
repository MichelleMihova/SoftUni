using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables___Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			int centuries = int.Parse(Console.ReadLine());
			int year = centuries * 100;
			int days =(int)( year * 365.2422);
			int hours = days * 24;
			int minutes = hours * 60;
			Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",centuries,year,days,hours,minutes);
		}
	}
}
