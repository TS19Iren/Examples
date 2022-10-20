/*Задача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.*/

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count=1;

void ToQuad (int n1)
{
    if (n1>0)
    {
        for (int i=1; i<=n1;i++)
        {
            Console.WriteLine($"{i,4}  {i*i,4}");
        }
    }
    else {
        Console.WriteLine("Введите значение больше нуля");
    }
}
ToQuad(n);