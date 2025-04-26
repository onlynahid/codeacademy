// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");
int say = 0;
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a> 0)
{
    Console.WriteLine("bu musbetdir");

    say++;

}

if (b > 0)
{
    Console.WriteLine("bu musbetdir");

    say++;

}

if (c > 0)
{
    Console.WriteLine("bu musbetdir");
    say++;


}


Console.WriteLine(say);