New Change Git
Change Tourt
Original
Change GIT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var sp = n - 1;
			var stars = 1;
			for (int i = 1; i <= n; i++) Console.Write(" ");
			Console.WriteLine(" |");
			for(int i=1;i<=n;i++)
			{
				for (int j = 1; j <= sp; j++) Console.Write(" ");
				for (int j = 1; j <= stars; j++) Console.Write("*");
				Console.Write(" | ");
				for (int j = 1; j <= stars; j++) Console.Write("*");
				Console.WriteLine();
				sp--;
				stars++;
			}

		}
	}
}
