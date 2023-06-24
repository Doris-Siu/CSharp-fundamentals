// See https://aka.ms/new-console-template for more information
using CSharp_fundamentals;
using CSharp_fundamentals.Math;

Console.WriteLine("Hello, World!");


var person = new Person();
person.FirstName = "Doris";
person.LastName = "Siu";
person.Introduce();

var calculator = new Calculator();
var result = calculator.Add(1, 2);
Console.WriteLine(result);


var numbers = new int[3];
numbers[0] = 1;

Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[2]);

var flags = new bool[3];
flags[0] = true;

Console.WriteLine(flags[0]);
Console.WriteLine(flags[1]);
Console.WriteLine(flags[2]);

var names = new string[3] { "Doris", "Janice", "Sabrina" }; 