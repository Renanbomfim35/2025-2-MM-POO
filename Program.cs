// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

Televisao tv = new Televisao();

tv.Tamanho = 22.5f;

Console.WriteLine($" A tv tem o tamanho{ tv.Tamanho}");

tv.Volume = -35;
Console.WriteLine($"volume{tv.Volume}");

tv.Volume = 120;

Console.WriteLine($"volume{tv.Volume}");
