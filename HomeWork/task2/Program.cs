﻿// Напишите программу, которая на вход принимает
//  два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
     Console.WriteLine("Число "+ a +" является максимальным");
     Console.Write("Число "+ b +" является минимальным");
}
else if (a==b)
{
    Console.WriteLine("Число "+ a +" равно числу "+ b +"");
}
else
{
    Console.WriteLine("Число "+ b +" является максимальным");
    Console.Write("Число "+ a +" является минимальным");
}
