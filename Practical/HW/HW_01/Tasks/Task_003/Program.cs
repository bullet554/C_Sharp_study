﻿// Напишите программу, которая на вход принимает число и
// выдаёт, является ли число чётным.
// 4 => да
// -3 => нет
// 7 => нет


Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

if (number % 2 == 0)
{
    Console.WriteLine($"{number} - чётное число.");
}
else
{
    Console.WriteLine($"{number} - нечётное число.");
}