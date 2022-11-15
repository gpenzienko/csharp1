// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Привет! Давай проверим какие четные числа идут до твоего числа ");
Console.WriteLine("Введи число:");
int numberA = Convert.ToInt32(Console.ReadLine());
int res = 1;

while (res < numberA)
{
Console.WriteLine(res+1);
res+= 2;
}
