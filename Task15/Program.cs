// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int dayofWeek (int num)
{
    if (num >= 1 && num <= 5) return 1;
    else if (num >= 6 && num <= 7) return 2;
    else return 3;       // else if (num >= 6 && num <=7) return 2;
}
Console.WriteLine("Введите номер дня недели и нажмите Enter.");
int number = Convert.ToInt32(Console.ReadLine());
int result = dayofWeek (number);
if (result == 3) Console.WriteLine("Введите корректное число.");
else if (result == 1) Console.WriteLine("Нет.");
else if (result == 2) Console.WriteLine("Да.");
