// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Привет! Давай проверим число на четность =) ");
Console.WriteLine("Введи число:");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 2 == 0)
{
    Console.WriteLine("четное число");
           
}
 else
{
    Console.WriteLine("число нечетное");
 }
