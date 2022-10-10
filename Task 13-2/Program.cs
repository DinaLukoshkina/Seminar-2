// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Console.Clear(); 
Console.WriteLine("Введите число: "); 
int a = int.Parse(Console.ReadLine()!); 
int digitCount = (int)Math.Log10(a) + 1; 
int i; 
if (digitCount > 2) 
{ 
i = a / (digitCount - 2) % 10; 
Console.WriteLine($"Третья цифра = {i}"); 
} 
else 
{ 
Console.WriteLine($"Третьей цифры нет"); 
}