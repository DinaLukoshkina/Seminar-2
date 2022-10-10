// Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным. 
Console.Clear(); 
Console.WriteLine("Введите цифру от 1 до 7: "); 
Console.WriteLine("1 - Понедельник"); 
Console.WriteLine("2 - Вторник"); 
Console.WriteLine("3 - Среда"); 
Console.WriteLine("4 - Четверг"); 
Console.WriteLine("5 - Пятница"); 
Console.WriteLine("6 - Суббота"); 
Console.WriteLine("7 - Воскресенье"); 
int a = int.Parse(Console.ReadLine()!); 
if (a >= 1 && a <= 7) 
{ 
if (a == 6 || a == 7) 
{ 
Console.WriteLine($"{a} - Это выходной день"); 
} 
else 
{ 
Console.WriteLine($"{a} - Это рабочий день"); 
} 
} 
else 
{ 
Console.WriteLine($"{a} - Цифра не находится от 1 до 7"); 
}