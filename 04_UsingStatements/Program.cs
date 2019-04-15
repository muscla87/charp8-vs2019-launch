using System;
using System.Collections.Generic;

namespace UsingStatements
{
	class Program
	{
		static void Main(string[] args)
		{
			int j = 0;
			Console.WriteLine($"Hello World! {j}");
		}

		static void WriteLinesToFileOld(IEnumerable<string> lines)
		{
			using (var file = new System.IO.StreamWriter("WriteLines2.txt"))
			{
				foreach (string line in lines)
				{
					// If the line doesn't contain the word 'Second', write the line to the file.
					if (!line.Contains("Second"))
					{
						file.WriteLine(line);
					}
				}
			} // file is disposed here
		}

		static void WriteLinesToFileNew(IEnumerable<string> lines)
		{
			using var file = new System.IO.StreamWriter("WriteLines2.txt");
			foreach (string line in lines)
			{
				// If the line doesn't contain the word 'Second', write the line to the file.
				if (!line.Contains("Second"))
				{
					file.WriteLine(line);
				}
			}
			// file is disposed here
		}
	}
}
