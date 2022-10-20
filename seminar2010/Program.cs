/*Напишите программу которая принимает 
1.на вход координаты точки x и y (x и y не равны нулю)
2.на выходе выдает номер четверти плоскости в которой находится точка*/

Console.WriteLine("Введите координаты точки: ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if (xc>0&&yc>0) return 1;
    if (xc<0&&yc>0) return 2;
    if (xc<0&&yc<0) return 3;
    if (xc>0&&yc<0) return 4;
    return 0;
}
int quarter = Quarter(x,y);
string result = quarter>0 
    ? $"Указанные координаты соответствуют четверти: -> {quarter}"
    :"Введены некорректные координаты";
    //если результат переменной больше нуля, то 21 строка, иначе 22 строка

Console.WriteLine(result);

