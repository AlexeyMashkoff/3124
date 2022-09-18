// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}
int Evencount(int[] Array1)
{
int count = 0;
for(int i = 0; i < Array1.Length; i++)
{
    if(Array1[i] % 2 == 0)
    {
        count += 1;  
    }
}
    return count;
}
int[] array = GetArray(4, 100, 999);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"количество чётных чисел = {Evencount(array)}");