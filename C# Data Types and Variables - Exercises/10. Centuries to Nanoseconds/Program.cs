using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
	class Program
	{
		static void Main(string[] args)
		{
			byte centuries = byte.Parse(Console.ReadLine());
			int year = centuries * 100;
			int days = (int)(year * 365.2422);
			uint hours = (uint)(days * 24);
			long minutes =(long)( hours * 60);
			ulong seconds =(ulong)(minutes * 60);
			ulong milliseconds = (ulong)(seconds * 1000);
			decimal microseconds =(decimal)( milliseconds * 1000);
			decimal nanoseconds = (microseconds * 1000);
			Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds =" +
				" {6} milliseconds = {7} microseconds = {8} nanoseconds",centuries,year,days,hours,minutes,seconds,milliseconds,microseconds,nanoseconds);
			//years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.
		}
	}
}
