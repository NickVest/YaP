﻿using System;
using System.IO;

namespace Практика_2_Задание_1._1
{
	class Program
	{
		static void Main(string[] args)
		{
			DirectoryInfo dir = new DirectoryInfo(Environment.SystemDirectory); ShowDirectory(dir);
		}
		static void ShowDirectory(DirectoryInfo dir)
		{
			// Показать все файлы
			foreach (FileInfo file in dir.GetFiles())
			{
				Console.WriteLine("File: {0}", file.FullName);
			}
			foreach (DirectoryInfo subDir in dir.GetDirectories())
			{
				ShowDirectory(subDir);
			}
		}
	}
}
