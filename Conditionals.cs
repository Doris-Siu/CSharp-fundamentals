using System;
namespace CSharp_fundamentals
{
    public class Conditionals
    {
        public static void Exercise1()
        {
            Console.Write("Enter a number from 1 to 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid.");
            else
                Console.WriteLine("Invalid.");
        }

        public static void Exercise2()
        {
            Console.Write("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;

            Console.WriteLine(max);
        }

        public static void Exercise3()
        {
            Console.Write("Enter image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = (width > height) ? "Landscape" : "Portrait";

            Console.WriteLine("Image orientation is " + orientation);
        }


        public static void Exercise4()
        {
            Console.Write("Enter speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter car speed: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("OK.");

            else
            {
                const int kmPerPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License suspended.");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }

        }

    }
}
    




