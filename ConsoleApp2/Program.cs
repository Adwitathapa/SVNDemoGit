// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Console.WriteLine("Hello, World!");
Console.WriteLine("Enter username:");
string userName = Console.ReadLine();
Console.WriteLine("Username is: " + userName);
Course obj = new Course("MBA");
obj.enrollStudent("Rahul");
