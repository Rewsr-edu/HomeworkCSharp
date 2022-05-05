/*
//Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int max(int a)
{
    int x = (a % 100)/10;
    return x ;
}
Console.WriteLine(a + "-->" + max(a));
//Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 100)
{
    int x = (a % 100)%10;
    Console.WriteLine(a + "-->" + x);
}
else
{
     Console.WriteLine("третье цифры нет");
}
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 5)
{
    Console.WriteLine(a + "->" + "нет");
}
if (a > 5)
{
    if (a <= 7)
    {
        Console.WriteLine(a + "->" + "да");
    }
    if (a > 7)
    {
        Console.WriteLine("некорректное число");
    }
}
*/