// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
if (a < 100)
Console.WriteLine("третьей цифры нет");
if (a > 100 & a < 1000)
Console.WriteLine(a%10);
if (a >= 10000 & a < 100000)
{
a=a/100;
Console.WriteLine(a%10);
}