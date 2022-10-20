﻿/*Напишите программу которая принимает на вход координаты двух точек и находит расстояние
между ними в 2Д пространстве
А(3,6);B(2,1)  =5,09*/
Console.WriteLine("Введите координаты точки А:");
Console.Write("Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double GetDist(int xc1, int xc2, int yc1, int yc2) 
{
    double d = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    d = Math.Round(d, 2, MidpointRounding.ToZero);
    return d;
}

double res = GetDist(x1, x2, y1, y2);
Console.WriteLine(res);
