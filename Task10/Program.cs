// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число и нажмите Enter.");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 >= 1 && number / 100 <= 9) Console.WriteLine($"{number} -> Трехзначное число.");
else Console.WriteLine($"Вы ввели не трехзначное число.");
