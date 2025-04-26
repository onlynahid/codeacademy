// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int min = x;
if(y < min)
{
    min = y;

}
if (z < min)
{
    min = z;

}
Console.WriteLine(min);