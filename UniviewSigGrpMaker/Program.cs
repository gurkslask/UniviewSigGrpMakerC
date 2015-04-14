using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UniviewSigGrpMaker
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.WriteLine ("Hello World!");
			remove_chars_from_string ();
		}
		public static void remove_chars_from_string ()
		{
			string[] stringlist = {"CR23", "CR2321", "CR1337"};
			string iteration_string = "";
			Regex pattern = new Regex("[A-Z a-z]");
			foreach (string variabel in stringlist) {
					pattern.Replace(variabel, "");
					Console.WriteLine (iteration_string);

				}
		}
	}
}

