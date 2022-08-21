//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое положительное число");
int a = Convert.ToInt32(Console.ReadLine());

int number = 1;
while (number <= a)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number);
    }
    number++;
}
if (a < 2)
{
    Console.WriteLine("Нет четных чисел до данного числа");
}
