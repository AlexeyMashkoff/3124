// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

string ReadNumber(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine() ?? "";
}

int count = 0;
{
while(true)
{
    string answer = ReadNumber("Введите число и нажмите Enter, для остановки введите слово - stop");
    if (answer == "stop")
    {
        break;
    }
    else
    {
        int number = Convert.ToInt32(answer);
        if(number > 0)
        {
            count++;
        }
    }
}
}
Console.WriteLine(count);