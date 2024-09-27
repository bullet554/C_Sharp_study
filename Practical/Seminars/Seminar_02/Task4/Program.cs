// Эта программа получает число от пользователя и вводит 3 цифру с конца.

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    System.Console.WriteLine(number % 1000 / 100);
}
else
{
    System.Console.WriteLine("Число НЕ трехзначное!");
}