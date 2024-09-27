// Программа получает от пользователя 2 числа. После этого проверяет краткость 1го числа ко 2му.

System.Console.Write("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue % secondValue == 0)
{
    System.Console.WriteLine($"{firstValue}, {secondValue} => Да");
}
else
{
    System.Console.WriteLine($"{firstValue}, {secondValue} => Нет, {firstValue % secondValue}");
}