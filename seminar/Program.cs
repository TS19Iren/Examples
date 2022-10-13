//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 5; b = 25 -> да 
//a = 2 b = 10 -> нет 
//a = 9; b = -3 -> нет 
//a = -3 b = 9 -> да

Console.Write("Введите число 1: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberB = int.Parse(Console.ReadLine());
if((numberB/numberA) == numberA) 
{
    Console.Write($"Число {numberB} является квадратом числа {numberA}");
}
else Console.Write($"Число {numberB} не является квадратом числа {numberA}");

