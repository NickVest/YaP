using System;
using System.IO;

namespace Практика_2_Задание_1._2
{
	class Program
	{
		static void watcher_Changed(object sender, FileSystemEventArgs e)
		{
			Console.WriteLine("Changed: {0}", e.FullPath);
		}
		static void Main(string[] args)
		{
			FileSystemWatcher watcher = new FileSystemWatcher(Environment.SystemDirectory);
			watcher.Filter = "*.ini";
			watcher.IncludeSubdirectories = true;
			watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;
			watcher.EnableRaisingEvents = true;
			watcher.Changed += new FileSystemEventHandler(watcher_Changed);
		}

		
	}
}
