using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
			Console.WriteLine("Input Month No : ");
            string month = Console.ReadLine();
			int monthnumber = int.Parse(month);

			switch (monthnumber)

            {
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					Console.Write("Month  have 31 days. \n");
					break;
				case 2:
					Console.Write("The 2nd month is February and have 28 days. \n");
					Console.Write("in leap year February month  Have 29 days.\n");
					break;
				case 4:
				case 6:
				case 9:
				case 11:
					Console.Write("Month have 30 days. \n");
					break;
				default:
					Console.Write("invalid Month number.\nPlease try again ....\n");
					break;

			}

			Console.ReadLine();
            




        }
    }
}
