// Эта программа получает число от пользователя и вводит 3 цифру с начала.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number > 999) // {} - для одной строки в цикле не обязательно ставить.
        number /= 10; // number = number / 10

    Console.WriteLine(number % 10);
}
else
{
    Console.WriteLine("Число НЕ трехзначное!");
}