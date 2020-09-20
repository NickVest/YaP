using System;
using System.IO;

namespace Практика_2_Задание_2._1
{
	class Program
	{
		static void Main(string[] args)
		{
			StreamWriter writer = File.CreateText(@"newfile.txt");
			writer.WriteLine("This is my new file");
			writer.WriteLine("Do you like its format?"); writer.Close();

			StreamReader reader = File.OpenText(@"newfile.txt");
			string contents = reader.ReadToEnd();
			reader.Close();
			Console.WriteLine(contents);
		}
	}
}
