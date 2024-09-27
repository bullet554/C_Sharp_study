Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(99 < number && number < 1000) // && - логическое "и". Означает что выполняется два условия.
{
    int leftDigit = number / 100;
    int rightDigit = number % 10;
    int result = leftDigit + rightDigit;
    Console.WriteLine(result);    
}
else
{
    System.Console.WriteLine("Число НЕ трехзначное");
}