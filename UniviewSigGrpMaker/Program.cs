using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace UniviewSigGrpMaker
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.WriteLine ("Hello World!");
            string[] stringlist = {"CR23", "CR2321", "CR1337"};
			remove_chars_from_string (stringlist);
            Thread.Sleep(5000);
		}
		public static void remove_chars_from_string (string[] args)
		{
			foreach (string variabel in args) {
                    Match iteration_string = Regex.Match(variabel, @"\d+");
					Console.WriteLine ("Original {0}, efter regex: {1}", variabel, iteration_string);
                }
		}
	}
}

