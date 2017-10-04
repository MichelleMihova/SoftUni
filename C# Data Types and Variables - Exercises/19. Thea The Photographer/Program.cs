using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
	class Program
	{
		static void Main(string[] args)
		{
			double takenPictures = double.Parse(Console.ReadLine());
			long filterTime = long.Parse(Console.ReadLine());
			long filterFactor = long.Parse(Console.ReadLine());
			long uploadingTime = long.Parse(Console.ReadLine());

			long filteredPictures = 0;
			filteredPictures =(long)Math.Ceiling( takenPictures * filterFactor / 100);
			long allTimeToFilter = 0;
			allTimeToFilter =(long) takenPictures * filterTime;
			long upload = 0;
			upload = filteredPictures * uploadingTime;
			long totalTime = 0;
			totalTime =allTimeToFilter +upload; //in seconds
			long secondsInMinutes = 0;
			long minutesToHours = 0;
			long hoursToDays = 0;
			if (totalTime>=60)
			{
				 secondsInMinutes = totalTime / 60; //minutes
				totalTime = totalTime % 60;
				if (secondsInMinutes>=60)
				{
					 minutesToHours = secondsInMinutes / 60; //hours
					secondsInMinutes = secondsInMinutes % 60;
					if (minutesToHours>=24)
					{
						hoursToDays =minutesToHours/24; //days
						minutesToHours = minutesToHours % 24;
						Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", hoursToDays, minutesToHours, secondsInMinutes, totalTime);

					}
					else
					{
						Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", hoursToDays, minutesToHours, secondsInMinutes, totalTime);

					}
				}
				else
				{
					Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}",hoursToDays,minutesToHours,secondsInMinutes,totalTime);
				}
			}
			else
			{
				Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", hoursToDays, minutesToHours, secondsInMinutes, totalTime);

			}
		}
	}
}
