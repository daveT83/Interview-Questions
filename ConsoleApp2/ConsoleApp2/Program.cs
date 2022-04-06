// See https://aka.ms/new-console-template for more information
using ConsoleApp2.Infrastructure;
using ConsoleApp2.Models;

Console.WriteLine("Hello, World!");
Employee emp = new Employee();
Examples ex = new Examples("1");

emp.EmployeeNumber = "3";

bool result = ex.Example2(new List<Employee>() { emp});

List<string> strs = Examples.Example1(0, 10);
Console.ReadLine();
