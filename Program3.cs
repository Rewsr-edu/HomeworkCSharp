// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int t1 , FirstNum , SecondNum , fourthNum , FifthNum;
t1 = number;
FirstNum = t1 / 10000;
t1 = t1 % 10000;
SecondNum = t1 / 1000;
t1 = t1 % 1000;
t1 = t1 % 100;
fourthNum = t1 / 10;
t1 = t1 % 10;
FifthNum = t1;
if (FirstNum == FifthNum)
{
    if(SecondNum == fourthNum)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
     Console.WriteLine("Нет");
}
return;
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double GetDistance (double x1, double y1, double x2, double y2, double z1, double z2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance = z2 - z1;
     double result =  Math.Sqrt(Math.Pow(xDistance,2) + Math.Pow(yDistance,2) + Math.Pow(zDistance,2) );
     return result;
}
double xA , yA, xB , yB , zA , zB ; 
double distance;
Console.Write("input X of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("input Y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("input Z of point A: ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("input X of point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("input Y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("input Z of point B: ");
zB = Convert.ToDouble(Console.ReadLine());
distance= GetDistance(xA, xB, yA, yB, zA, zB);
Console.WriteLine(distance); 
*/

