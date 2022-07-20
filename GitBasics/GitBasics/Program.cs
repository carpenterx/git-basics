// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");
string? name = Console.ReadLine();
if (name != "")
{
    Console.WriteLine($"Hi, {name}!");
}
else
{
    Console.WriteLine("Hello, stranger!");
}

