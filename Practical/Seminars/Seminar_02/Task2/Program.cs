// Эта программа получает от пользователя трехзначное число, и далее 2ю цифру возводится в степень, равную 3ей цифре.

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (99 < number && number < 1000)
{
    int middleDigit = number / 10 % 10;
    int rigthDigit = number % 10;
    int power = 1;

    for ( ; rigthDigit > 0; rigthDigit--) // i-- == декримент; i++ == инкримент
    {
        power *= middleDigit;
    }
    System.Console.WriteLine(power);
}
else
{
    System.Console.WriteLine("Число НЕ трехзначное!");
}
