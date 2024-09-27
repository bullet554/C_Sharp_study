// Программа, определяющая существует ли данное число в массиве. Ответ да/нет.

int[] numbers = { 1, 3, 4, 19, 3 };

// for (int i = 0; i < numbers.Length; i++)                     // Можно делать с данными что угодно (читать, изменять)
// {
//     System.Console.WriteLine(numbers[i] + " ");
// }



foreach (int number in numbers)                                 // Данные можно только читать. Изменять их нельзя!!
{
    Console.Write(number + " ");
}

Console.WriteLine();
Console.Write("Введите число: ");
int numberToFind = Convert.ToInt32(Console.ReadLine());

bool numberIsFind = false;                                      // Мы ещё не нашли переменную

foreach (int number in numbers)
{
    if (number == numberToFind)
        numberIsFind = true;                                    // Мы нашли переменную
}

if (numberIsFind)
    System.Console.WriteLine("Значение найдено!");
else
    System.Console.WriteLine("Значения НЕТ!");