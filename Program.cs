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