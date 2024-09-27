// Задача 3: Напишите программу, которая принимает на вход целое число из
// отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Write("Введите число от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <= 99)
{
    int lefftDigit = number / 10;
    int rigthDigit = number % 10;
    if (lefftDigit > rigthDigit)
    {
        Console.WriteLine(lefftDigit);
    }
    else if (lefftDigit < rigthDigit)
    {
        Console.WriteLine(rigthDigit);
    }
    else
    {
        Console.WriteLine("Цифры равны.");
    }
}
else
{
    Console.WriteLine("Введенное число не входит в диапазон [10, 99]!!!");
}