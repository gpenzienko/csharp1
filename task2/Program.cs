// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Привет! Введи, пожалуйста, два числа и мы посмотрим какое из них больше, а какое меньше =) ");
Console.WriteLine("Введи первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
Console.WriteLine(numberA + " max, min " + numberB);
}
else

Console.WriteLine(numberB + " max, min " + numberA);