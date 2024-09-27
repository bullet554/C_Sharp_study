// Массив на 10 элементов, заполнен чеслами из промежутка [-10, 10].
// Заменить положительные на отрицательные, а отрицательные на положительные.

int[] numbers = { 1, -5, 6, 6, 3, 9, -7 };

foreach (int number in numbers)
{
    Console.Write(number + "\t");
}
System.Console.WriteLine();

for (int i =0; i < numbers.Length; i++)
{
    numbers[i] *= -1;
}

foreach (int number in numbers)
{
    Console.Write(number + "\t");
}