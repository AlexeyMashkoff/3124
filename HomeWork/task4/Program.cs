// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число a и нажмите Enter:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b и нажмите Enter:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c и нажмите Enter:");
int c = Convert.ToInt32(Console.ReadLine());
int max_number = 0;
if (a > max_number) max_number = a;
if (b > max_number) max_number = b;
if (c > max_number) max_number = c;
Console.WriteLine("Максимальное число "+max_number+"");