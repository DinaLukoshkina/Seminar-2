// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Console.Clear(); 
Console.WriteLine("Введите число: "); 
int a = int.Parse(Console.ReadLine()); 
double i = Math.Abs(a); 
double result; 
if (i > 99) 
{ 
while (i > 999) 
{ 
i = i / 10; 
} 
i = Math.Truncate(i); 
result = i % 10; 
Console.WriteLine($"Третья цифра числа = {result}"); 
} 
else 
{ 
Console.WriteLine("Третьей цифры нет"); 
}