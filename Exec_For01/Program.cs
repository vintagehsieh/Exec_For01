using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_For01
			//倒星三角形
			//做出一個共五排，從上到下依序減少星星數的倒三角形

			for (int i = 0; i <= 5; i++)
			{
				int countOfStars = 2 * (5 - i) + 1;
				int countOfSpace = i;
				string result = new string(' ', countOfSpace) + new string('*', countOfStars);
				Console.WriteLine(result);
			}
	}
}
