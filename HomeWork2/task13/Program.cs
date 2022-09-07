<<<<<<< HEAD
﻿// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число:");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2)
{
  Console.WriteLine(" третья цифра " + NumberText[2]);
}
else {
  Console.WriteLine(" третьей цифры нет ");
}
=======
﻿// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число:");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2)
{
  Console.WriteLine(" третья цифра " + NumberText[2]);
}
else {
  Console.WriteLine(" третьей цифры нет ");
}
>>>>>>> e58766c2c70a24b0fb0fae54db99f4a6e755609a
