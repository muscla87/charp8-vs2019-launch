using System;
using System.Threading.Tasks;

namespace AsynchronousStreams
{
	class AsynchronousStreams
	{
		static void Main(string[] args)
		{
			MainAsync(args).Wait();
		}

		static async Task MainAsync(string[] args)
		{
			await foreach (var number in GenerateSequence())
			{
				Console.WriteLine(number);
			}
		}

		public static async System.Collections.Generic.IAsyncEnumerable<int> GenerateSequence()
		{
			for (int i = 0; i < 20; i++)
			{
				await Task.Delay(100);
				yield return i;
			}
		}

	}
}
