using System;
namespace CSharp_fundamentals
{
	public class Loops
	{
		public static void Exercise1()
		{
            var count = 0;

            for (var i = 1; i<= 100; i++)
			{
				if (i % 3 == 0 )
				{
					count++;
				}
			};

				Console.WriteLine("There are {0} numbers divisible by 3 beteween 1 and 100", count);
		}


        public static void Exercise2()
        {
            var sum = 0;

            while (true)
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")

                    break;

                sum += Convert.ToInt32(input);
            }

            Console.WriteLine("Sum of all numbers: " + sum);
        }

        public static void Exercise3()
        {
            Console.Write("Enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;

            for (var i = 1; i <= input; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", input, factorial);
        }


        public static void Exercise4 ()
        {
            var number = new Random().Next(1, 10);
            Console.WriteLine("Secret is: " + number);

            for (var i = 0; i < 4; i++)
            {
                Console.Write("Enter your guess: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                Console.WriteLine("You lose!");
            }
        }


        public static void Exercise5()
        {
            Console.Write("Enter comma seperated numbers: ");
            var numbersArr = Console.ReadLine().Split(',');

            var max = numbersArr[0];

            foreach (var num in numbersArr)
            {
                if (Convert.ToInt32(num) >= Convert.ToInt32(max))
                    max = num;
            }

            Console.WriteLine("Max is " + max);
        }

    }


}

