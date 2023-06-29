using System;
namespace CSharp_fundamentals
{
	public class Strings
	{
		public static void Exercise1()
		{
			Console.Write("Enter a few numbers (eg 1-2-3-4): ");

			var input = Console.ReadLine();

			var numbersList = new List<int>();

			foreach (var num in input.Split('-'))
			{
				numbersList.Add(Convert.ToInt32(num));
			}

			numbersList.Sort();
			var isConsecutive = true;

			for (var i = 1; i < numbersList.Count; i++)
			{
				if (numbersList[i] != numbersList[i - 1] + 1)
				{
					isConsecutive = false;
					break;
				}
			}

			var message = (isConsecutive) ? "Consecutive." : "Not consecutive.";
			Console.WriteLine(message);

		}


		public static void Exercise2()
		{
			Console.Write("Enter a few numbers (eg 1-2-3-4): ");

            var input = Console.ReadLine();

            var numbersList = new List<int>();
			var uniquesList = new List<int>();
			var includesDuplicates = false;

			if (string.IsNullOrWhiteSpace(input))
				return;

			foreach (var num in input.Split('-'))
			{
				numbersList.Add(Convert.ToInt32(num));
			}

			foreach (var num in numbersList)
			{
				if (!uniquesList.Contains(num))
					uniquesList.Add(num);
				else
				{
					includesDuplicates = true;
					break;
				}
            }

			var message = (includesDuplicates) ? "Duplicate" : "No duplicate.";

			Console.WriteLine(message);
        }


		public static void Exercise3()
		{
			Console.Write("Enter a time format (eg 19:00): ");
			var input = Console.ReadLine();

			if (string.IsNullOrWhiteSpace(input))
			{
                Console.WriteLine("Invalid time.");
				return;
            }

			var components = input.Split(':');

			if (components.Length != 2)
            {
                Console.WriteLine("Invalid time.");
                return;
            }

			try
			{
				var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

				if ((hour >= 0 && hour <= 23 ) && (minute >= 0 && minute <= 59))
					Console.WriteLine("OK.");

				else
					Console.WriteLine("Invalid time.");
            }
			catch (Exception)
			{
                Console.WriteLine("Invalid time.");
            }
        }


		public static void Exercise4()
		{
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error.");
                return;
            }

			var variableName = "";

			foreach (var word in input.Split(' '))
			{
				var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
				variableName += wordWithPascalCase;

			}

			Console.WriteLine(variableName);
        }


		public static void Exercise5()
		{
            Console.Write("Enter a word: ");
            var input = Console.ReadLine().ToLower();


			var vowelsList = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
			var count = 0;


			foreach (var character in input)
				{
				if (vowelsList.Contains(character))
				{
					count++;
				}
			}

			Console.WriteLine(count);
        }
    }
}
