// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Diagnostics;

Console.WriteLine("Hello, World!!");
string name1;
string name2;
string grade;
string ID;
Console.WriteLine("What is first your name?");
name1= Console.ReadLine();
Console.WriteLine("What is last your name?");
name2 = Console.ReadLine();
Console.WriteLine($"Nice to meet you {name1} {name2}, what grade are you in?");
grade= Console.ReadLine();
Console.WriteLine("And what is last your student ID?");
ID= Console.ReadLine();
Console.WriteLine($"Information:");
Console.WriteLine($"First name: {name1}");
Console.WriteLine($"Last name: {name2}");
Console.WriteLine($"Grade: {grade}");
Console.WriteLine($"Student ID: {ID}");
