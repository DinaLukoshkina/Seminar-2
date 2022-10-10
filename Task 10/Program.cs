// Напишите программу, которая принимает на вход трезначное число и н выходе показывает вторую цифру этого числа. 
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
if (a > 99 && a <= 999)
{
    int num = (a / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {a} = {num}");
}
else
{
    Console.WriteLine($"{a} - Не трёхзначное число");
}