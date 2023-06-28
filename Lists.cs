using System;

namespace CSharp_fundamentals
{
	public class Lists
	{
		public static void Exercise1()
		{
			var namesList = new List<string>();

			while (true) {
				Console.Write("Enter a name (or hit Enter to quit): ");
				var input = Console.ReadLine();

				if (String.IsNullOrWhiteSpace(input))
					break;

				namesList.Add(input);

				if (namesList.Count > 2)
					Console.WriteLine("{0}, {1} and {2} others like your post.", namesList[0], namesList[1], namesList.Count - 2);
				else if (namesList.Count == 2)
					Console.WriteLine("{0}, {1} like your post.", namesList[0], namesList[1]);
				else if (namesList.Count == 1)
					Console.WriteLine("{0} likes your post.", namesList[0]);
				else
					Console.WriteLine();

			}
		}


		public static void Exercise2()
		{
			Console.Write("Enter your name: ");
			var input = Console.ReadLine();


			var charArr = input.ToCharArray();
			var reversedArr = charArr.Reverse();

			Console.WriteLine(string.Join("", reversedArr));

		}


		public static void Exercise3()
		{
			var numbersList = new List<int>();

			while (numbersList.Count < 5)
			{
                Console.Write("Enter a number: ");
				var input = Convert.ToInt32(Console.ReadLine());

				if (numbersList.Contains(input)) {
                    Console.WriteLine("You have previously entered this number.");
					continue;

                }
				numbersList.Add(input);

            };
			numbersList.Sort();

			foreach (var num in numbersList)
				Console.WriteLine(num);
        }


		public static void Exercise4()
		{
			var numbersList = new List<int>();
			var uniquesList = new List<int>();

			while (true)
			{
				Console.Write("Enter a number (or 'Quit' to exit): ");
				var input = Console.ReadLine();

				if (input.ToLower() == "quit")
					break;

				numbersList.Add(Convert.ToInt32(input));

			}

			foreach (var num in numbersList)
			{
                if (!uniquesList.Contains(num))
                    uniquesList.Add(num);

            };

			Console.WriteLine("Unique numbers: ");
			foreach (var num in uniquesList)
				Console.WriteLine(num);
		}


		public static void Exercise5()
		{
			var numbersList = new List<int>();

			while (true) {
                Console.Write("Enter a list of comma-seperated numbers: ");

                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input) || input.Split(',').Length < 5)
                {
                    Console.WriteLine("Invalid List.");
                    continue;
                };

                foreach (var num in input.Split(','))
                {
                    numbersList.Add(Convert.ToInt32(num));
                };

                break;
            }

            numbersList.Sort();
			Console.WriteLine("The 3 smallest numbers are {0}, {1} and {2}", numbersList[0], numbersList[1], numbersList[2]);
        }


    }
}

