// Задача 4: Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую, в обратном направлении.

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    while (0 < number)
    {
        Console.Write(number % 10 + ", ");
        number /= 10;
    }
}
else
{
    Console.WriteLine("Введено НЕ натуральное число.");
}