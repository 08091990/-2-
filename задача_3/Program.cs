// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7:");
int a = int.Parse(Console.ReadLine());
if (a==1)
Console.WriteLine("Понедельник");
if (a==2)
Console.WriteLine("Вторник");
if (a==3)
Console.WriteLine("Среда");
if (a==4)
Console.WriteLine("Четверг");
if (a==5)
Console.WriteLine("Пятница");
if (a==6)
Console.WriteLine("{Суббота}->{Выходной}");
if (a==7)
Console.WriteLine("{Воскресение}->{Выходной}");