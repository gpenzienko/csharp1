// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Привет! Давай найдем максимальное значение из трех введеных тобой чисел =) ");
Console.WriteLine("Введи первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третье число:");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > numberA)
    max = numberB;
if (numberC > max)
    max = numberC;

Console.WriteLine("Число " + max + " максимальное");