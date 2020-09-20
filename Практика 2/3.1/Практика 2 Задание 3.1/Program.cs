using System;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace Практика_2_Задание_3._1
{
	class Program
	{
		static void Main(string[] args)
		{
			CompressFile(@"boot.ini", @"boot.ini.gz");
			UncompressFile(@"boot.ini.gz", @"boot.ini.test");
		}

		static void CompressFile(string inFilename, string outFilename)
		{
			FileStream sourceFile = File.OpenRead(inFilename);
			FileStream destFile = File.Create(outFilename);

			GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);

			int theByte = sourceFile.ReadByte();
			while (theByte != -1)
			{
				compStream.WriteByte((byte)theByte);
				theByte = sourceFile.ReadByte();
			}

			
		}

		static void UncompressFile(string inFilename, string outFilename)
		{
			FileStream sourceFile = File.OpenRead(inFilename);
			FileStream destFile = File.Create(outFilename);

			GZipStream compStream = new GZipStream(sourceFile, CompressionMode.Decompress);

			int theByte = compStream.ReadByte();
			while (theByte != -1)
			{
				destFile.WriteByte((byte)theByte);
				theByte = compStream.ReadByte();
			}


		}
	}
}
