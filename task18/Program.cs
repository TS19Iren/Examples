/*Напишите программу которая по заданному номеру четверти показывает диапазон возможных координат точек
этой четверти (x и y)*/
Console.WriteLine("Введите номер четверти плоскости: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string Quarter(int quarterXY)
{
    if (quarterXY==1) return "x>0&&y>0";
    if (quarterXY==2) return "x<0&&y>0";
    if (quarterXY==3) return "x<0&&y<0";
    if (quarterXY==4) return "x>0&&y<0";
    return "Введен некорректный номер четверти";
}

string xy = Quarter (quarter);
Console.WriteLine(xy);
