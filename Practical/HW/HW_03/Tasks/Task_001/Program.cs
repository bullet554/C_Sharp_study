// Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90]. 

// массив [10 21 14 93 23] => 2

int[] numbers = { 10, 21, 14, 93, 23 };
int counter = 0;

foreach (int number in numbers)
{
    if (number >= 20 && number <= 90)
    {
        counter += 1;
    }
}
Console.Write(counter);