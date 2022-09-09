// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.



Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine($"Сгенерировалось случайное число {number}");
int digit2 = (number % 100)/10;
int res = digit2;
Console.WriteLine(res);