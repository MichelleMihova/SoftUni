﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
	class Program
	{
		static void Main(string[] args)
		{
			float distance = float.Parse(Console.ReadLine());
			byte hours = byte.Parse(Console.ReadLine());
			byte minutes = byte.Parse(Console.ReadLine());
			byte seconds = byte.Parse(Console.ReadLine());
			float hourTime = hours + minutes / 60.0f + seconds / 3600.0f;
			float kmSpeed = (distance / 1000.0f) / hourTime;
			float metersSpeed = kmSpeed / 3.6f;
			float milesSpeed = (distance / 1609.0f) / hourTime;

			Console.WriteLine("{0}", metersSpeed);
			Console.WriteLine("{0}", kmSpeed);
			Console.WriteLine("{0}", milesSpeed);
		}
	}
}
