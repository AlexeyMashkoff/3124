// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int i=1;
Console.WriteLine("Введите число N и нажмите ENTER:");
int number = Convert.ToInt32(Console.ReadLine());

while(i <= number)
{
    if (i%2 == 0)
    {
        Console.Write(i + " ");
    }
i++;
}


