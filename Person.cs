using System;
namespace CSharp_fundamentals
{
	public class Person
	{

        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);

        }


    }
}

