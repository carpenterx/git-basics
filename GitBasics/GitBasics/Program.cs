﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");
string? name = Console.ReadLine();
Console.WriteLine("What is your preferred greeting?");
string? greeting = Console.ReadLine();
if (greeting != "")
{
    if (name != "")
    {
        Console.WriteLine($"{greeting}, {name}!");
    }
    else
    {
        Console.WriteLine($"{greeting}, stranger!");
    }
}
else
{
    Console.WriteLine("Please provide a greeting!");
}

