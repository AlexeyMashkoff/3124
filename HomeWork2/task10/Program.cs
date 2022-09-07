<<<<<<< HEAD
﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine($"Сгенерировалось случайное число {number}");
int digit2 = (number % 100)/10;
int res = digit2;
Console.WriteLine(res);
=======
﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine($"Сгенерировалось случайное число {number}");
int digit2 = (number % 100)/10;
int res = digit2;
Console.WriteLine(res);
>>>>>>> e58766c2c70a24b0fb0fae54db99f4a6e755609a
