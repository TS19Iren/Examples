//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
 // 3 -> Среда 
//5 -> Пятница
Console.Write("Введите порядковый номер дня недели ");
int number = int.Parse(Console.ReadLine());
if(number==1){
    Console.WriteLine("понедельник");
}
if(number==2){
    Console.WriteLine("вторник");
}
if(number==3){
    Console.WriteLine("среда");
}
if(number==4){
    Console.WriteLine("четверг");
}
if(number==5){
    Console.WriteLine("пятница");
}
if(number==6){
    Console.WriteLine("суббота");
}
if(number==7){
    Console.WriteLine("воскресенье");
}