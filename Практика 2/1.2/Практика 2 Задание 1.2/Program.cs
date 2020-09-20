using System;
using System.IO;

namespace Практика_2_Задание_1._2
{
	class Program
	{
		public static bool EnabhngRaisingEvents { get; private set; }

		static void Main(string[] args)
		{
			FileSystemWatcher watcher = new FileSystemWatcher(Environment.SystemDirectory);
			watcher.Filter = "*.ini";
			watcher.IncludeSubdirectories = true;
			watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;
			watcher.Changed += new FileSystemEventHandler(watcher.Changed);
		}

		static void watcher_Changed(object sender, FileSystemEventArgs e)
		{
			Console.WriteLine("Changed: {0}", e.FullPath);
			EnabhngRaisingEvents = true;
		}
	}
}
