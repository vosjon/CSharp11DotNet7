﻿object height = 1.88;
object name = "Amir";

Console.WriteLine($"{name} is {height} meters tall.");

int length1 = ((string)name).Length;
Console.WriteLine($"{name} has {length1} characters.");


Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default: {number}");
