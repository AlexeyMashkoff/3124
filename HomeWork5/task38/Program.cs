// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max +1);
    }
    return arr;
}
int MaxElement(int[] array)
{
    int max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
int MinElement(int[] array)
{
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
int[] array = GetArray(10, 0, 50);

Console.WriteLine(string.Join(", ", array));

int MaxN = MaxElement(array);

int MinN = MinElement(array);

int diff = MaxN - MinN;

Console.WriteLine($"Разница между максимальным и минимальным значением = {diff}");
