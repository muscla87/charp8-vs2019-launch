using System;
using System.Linq;

namespace RangesAndIndices
{
	class RangesAndIndices
	{
		//Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday

		static void Main(string[] args)
		{
			string[] week = Enum.GetNames(typeof(DayOfWeek));
			Console.WriteLine($"All Days: {string.Join(",", week)}");
			Console.ReadLine();
			IndexOld();
			Console.ReadLine();
			IndexNew();
			Console.ReadLine();
			RangeOld();
			Console.ReadLine();
			RangeNew();
			Console.ReadLine();
			OpenEndedRanges();
		}

		static void IndexOld()
		{
			string[] week = Enum.GetNames(typeof(DayOfWeek));
			int d1 = 2; // number 2 from beginning  
			int d2 = week.Length - 3; // number 3 from end  

			Console.WriteLine($"OldIndex: {week[d1]}, {week[d2]}"); // Tuesday, Thursday 
		}

		static void IndexNew()
		{
			Index d1 = 2; // number 2 from beginning  
			Index d2 = ^3; // number 3 from end  
			string[] week = Enum.GetNames(typeof(DayOfWeek));

			Console.WriteLine($"NewIndex: {week[d1]}, {week[d2]}"); // Tuesday, Thursday 
		}

		static void RangeOld()
		{
			string[] week = Enum.GetNames(typeof(DayOfWeek));
			var days = week.ToList().GetRange(2, 3); // Wednesday,Thursday,Friday  
													 //or  
			var days2 = week.Skip(2).Take(3); // Wednesday,Thursday,Friday  
											  //New Style  

			Console.WriteLine($"OldRange: {string.Join(",", days)}");
			Console.WriteLine($"OldRange2: {string.Join(",", days2)}");
		}

		static void RangeNew()
		{
			string[] week = Enum.GetNames(typeof(DayOfWeek));
			Range range = 2..^2;
			var days = week[range]; // Wednesday,Thursday,Friday  
									//						// [2..^2] mean   
									//						//  2 : skip elements from the begining until the index 1  
									//						// ^2 : skip 2 element from the end  
			Console.WriteLine($"NewRange: {string.Join(",", days)}");
		}

		static void OpenEndedRanges()
		{
			var words = new string[]
			{
							// index from start    index from end
				"The",      // 0                   ^9
				"quick",    // 1                   ^8
				"brown",    // 2                   ^7
				"fox",      // 3                   ^6
				"jumped",   // 4                   ^5
				"over",     // 5                   ^4
				"the",      // 6                   ^3
				"lazy",     // 7                   ^2
				"dog"       // 8                   ^1
			};

			var allWords = words[..]; // contains "The" through "dog".
			var firstPhrase = words[..4]; // contains "The" through "fox"
			var lastPhrase = words[6..]; // contains "the, "lazy" and "dog"
			int i = 3;
			var dynamicRange = new Range(1, ^i);
			var withDynamicRange = words[dynamicRange]; // contains "the, "lazy" and "dog"

		}
	}
}
