// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


int thirdDigital (int num)
{
    if (num < 100) return -1;
    {
        while (num/100 > 9) num/=10;
        return num % 10;
    }
}
Console.WriteLine("Введите число.");
int number = Convert.ToInt32(Console.ReadLine());
int result = thirdDigital (number);
string res = result == -1 ? "Третьей цифры нет." : result.ToString();
Console.WriteLine($"{res}");