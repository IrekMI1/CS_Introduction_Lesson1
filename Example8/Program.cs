//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число больше 1: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;

if (N <= 1)
{
    Console.WriteLine("Нужно ввести число больше 1!");
}

else
{
    while (i < (N - 1))
    {
        Console.Write(i + ", ");
        i = i + 2;
    }
    Console.Write(i);
}