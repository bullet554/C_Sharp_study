// Эта программа получает от пользователя трехзначное число и выводит первую и последнюю цифры.

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (99 < number && number < 1000)
{
    int lefftDigit = number / 100;
    int rigthDigit = number % 10;
    int result = lefftDigit * 10 + rigthDigit;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Число НЕ трехзначное!");
}
