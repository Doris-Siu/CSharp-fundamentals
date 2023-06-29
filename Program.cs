// See https://aka.ms/new-console-template for more information
using System.Text;
using System.IO;
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


// List : generic type
var integers = new List<int>() { 1, 2, 3, 4 };

// add more elements
integers.Add(1);
integers.AddRange(new int[] { 5, 6, 7 });

foreach (var n in integers)
    Console.Write(n);
Console.WriteLine();

// IndexOf()
Console.WriteLine("Index of 1: " + integers.IndexOf(1));
Console.WriteLine("Last Index of 1: " + integers.LastIndexOf(1));

// Count
Console.WriteLine("Count: " + integers.Count);

// Remove() : remove the 1st of that particular element
// use a for loop to remove all particular elements, but not a foreach loop

for (var i = 0; i < integers.Count; i++)
{
    if (integers[i] == 1)
        integers.Remove(integers[i]);
}

foreach (var n in integers)
    Console.Write(n);
Console.WriteLine();

// Clear()
integers.Clear();
Console.WriteLine("Count: " + integers.Count);


// DateTime structure in System

//var dateTime = new DateTime(2021, 1, 1);
var now = DateTime.Now;
var today = DateTime.Today;

Console.WriteLine("Hour: " + now.Hour);
Console.WriteLine("Minute: " + now.Minute);

var tomorrow = now.AddDays(1);
var yesterday = now.AddDays(-1);

Console.WriteLine(now.ToLongDateString());
Console.WriteLine(now.ToShortDateString());
Console.WriteLine(now.ToLongTimeString());
Console.WriteLine(now.ToShortTimeString());
Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));


// TimeSpan
// creaing a timespan object
var timeSpan = new TimeSpan(1, 2, 3);

var timeSpan1 = new TimeSpan(1, 0, 0);
var timeSpan2 = TimeSpan.FromHours(1);

var start = DateTime.Now;
var end = DateTime.Now.AddMinutes(2);

var duration = end - start;
Console.WriteLine("Duration: " + duration);


// properties
Console.WriteLine("Minutes: " + timeSpan.Minutes);
Console.WriteLine("Minutes: " + timeSpan.TotalMinutes);


// modify timespan: return a new timespan
Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));


// ToString(), Parse
Console.WriteLine("ToString: " + timeSpan.ToString());
Console.WriteLine("ParseString: " + TimeSpan.Parse("01:02:03"));


// Class string methods

var fullName = "Doris Siu ";

Console.WriteLine("Trim: '{0}'", fullName.Trim());
Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

// splitting the full name
// 1. IndexOf + Substring
var id = fullName.IndexOf(' ');

var firstName = fullName.Substring(0, id);
var lastName = fullName.Substring(id + 1);
Console.WriteLine("First Name: " + firstName);
Console.WriteLine("Last Name: " + lastName);

// 2. use Split
var namesArr = fullName.Split(' ');

Console.WriteLine("First Name: " + namesArr[0]);
Console.WriteLine("Last Name: " + namesArr[1]);

// Replace
Console.WriteLine(fullName.Replace("Doris", "Mei"));


// input invalid checking
if (String.IsNullOrWhiteSpace(""))
    Console.WriteLine("Invalid.");

// convert str to numbers
var str = "25";
var age = Convert.ToByte(str);
Console.WriteLine(age);

//convert numbers to str
float money = 29.95f;
Console.WriteLine(money.ToString("C0"));


// summarising long text
var sentence = "This is a really really really really really really long text";
var summary = StringUtility.SummarizeText(sentence, 30);
Console.WriteLine(summary);


// StringBuilder Class
var builder = new StringBuilder("Hello World");
builder.Append('-', 10).AppendLine().Append("Header").AppendLine().Append('-', 10).Replace('-', '+').Remove(0, 10).Insert(0, new string('-', 10));

Console.WriteLine(builder);

Console.WriteLine("First char: " + builder[0]);


// File (provide static methods), FileInfo (provide instance methods) Class
// File Class
var path = @"c:\somefile.jpg";

if (File.Exists(path))
{
    File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
    File.Delete(path);
    var content = File.ReadAllText(path);
}


// FileInfo Class
var fileInfo = new FileInfo(path);

if (fileInfo.Exists)
{
    fileInfo.CopyTo("");
    fileInfo.Delete();
}


// Directory, DirectoryInfo Class
// Directory
// Directory.CreateDirectory(@"c:\temp\folder1");

if (Directory.Exists(@"c:\\Projects\\CSharp-fundamentals\"))
    {
    var files = Directory.GetFiles(@"c:\Projects\CSharp-fundamentals", "*.sln", SearchOption.AllDirectories);
    foreach (var file in files)
        Console.WriteLine(file);


    var directories = Directory.GetDirectories(@"c:\Projects\CSharp-fundamentals", "*.*", SearchOption.AllDirectories);
    foreach (var dir in directories)
        Console.WriteLine(dir);
}

// DirectoryInfo
var directoryInfo = new DirectoryInfo("...");

if (directoryInfo.Exists)
{
    directoryInfo.GetFiles();
    directoryInfo.GetDirectories();
}


// Path Class
//var pathStr = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";
var pathStr = @"/Users/dorissiu/Projects/CSharp-fundamentals/helloWorld/HelloWorld.sln";
Console.WriteLine("Extension: " + Path.GetExtension(pathStr));
Console.WriteLine("File Name: " + Path.GetFileName(pathStr));
Console.WriteLine("File Name without extension: " + Path.GetFileNameWithoutExtension(pathStr));
Console.WriteLine("Directory Name: " + Path.GetDirectoryName(pathStr));






