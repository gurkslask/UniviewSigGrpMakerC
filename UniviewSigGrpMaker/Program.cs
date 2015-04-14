using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UniviewSigGrpMaker
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] stringlist = new string[3] ("CR23", "CR2321", "CR1337");
			foreach (string variabel in stringlist) {
				Console.WriteLine (variabel);
			}
			Console.WriteLine ("Hello World!");
		}
		public static void remove_chars_from_string (string[] args)
		{

		}
	}
}
