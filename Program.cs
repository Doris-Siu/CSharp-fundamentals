// See https://aka.ms/new-console-template for more information
using CSharp_fundamentals;
using CSharp_fundamentals.Math;

Console.WriteLine("Hello, World!");


var person = new Person();
person.FirstName = "Doris";
person.LastName = "Siu";
//string concatenation
person.Introduce();

// string format
var myFullName = string.Format("My name is {0} {1}.", person.FirstName, person.LastName);
Console.WriteLine(myFullName);

//string - combine elements of an array
var names = new string[3] { "Doris", "Janice", "Sabrina" };
var formattedNames = string.Join(",", names);
Console.WriteLine(formattedNames);


//verbatim string
var text = @"Hi Doris
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";

Console.WriteLine(text);

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


//Enum
var method = ShippingMethod.Express;
Console.WriteLine((int)method);

var methodId = 3;
Console.WriteLine((ShippingMethod)methodId);

//type convesion to string
Console.WriteLine(method.ToString());

//parse string into an enum
var methodName = "Express";
var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

Console.WriteLine(shippingMethod);

//Condtional flow
bool isGoldCustomer = true;

//float price;
//if (isGoldCustomer)
//    price = 19.95f;
//else
//    price = 29.95f;


//conditional operator
float price = (isGoldCustomer) ? 19.95f : 29.95f;
Console.WriteLine(price);

//switch/case statements
var season = Season.Autumn;

switch (season) {
    case Season.Autumn:
    case Season.Summer:
        Console.WriteLine("We've got promoted!");
        break;

    default:
        Console.WriteLine("I don't know about that season!");
        break;
}


// create a random char password

var random = new Random();

const int passwordLength = 10;

var buffer = new char[passwordLength];

for (var i = 0; i < passwordLength; i++)
    buffer[i] = (char)('a' + random.Next(0, 26));

var password = new string(buffer);

Console.WriteLine(password);


// arrays

var odds = new int[] { 1, 5, 7, 11, 9, 3};

// Length
Console.WriteLine("Length: " + odds.Length);

// IndexOf()
var index = Array.IndexOf(odds, 9);
Console.WriteLine("Index of 9: " + index);

// Clear()
Array.Clear(odds, 0, 2);

Console.WriteLine("Effect of Clear(): ");
foreach (var n in odds)
    Console.Write(n);
Console.WriteLine();

// Copy()
var anotherArr = new int[3];
Array.Copy(odds, anotherArr, 3);
Console.WriteLine("Effect of Copy(): ");
foreach (var n in anotherArr)
    Console.Write(n);
Console.WriteLine();

// Sort()
Array.Sort(odds);
Console.WriteLine("Effect of Sort(): ");
foreach (var n in odds)
    Console.Write(n);
Console.WriteLine();


// Reverse()
Array.Reverse(odds);
Console.WriteLine("Effect of Reverse(): ");
foreach (var n in odds)
    Console.Write(n);
Console.WriteLine();
