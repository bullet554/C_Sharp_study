// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

void main()
{
    int sizeOfArray = ReadInt("Введите размер массива: ");
    // int[] array = GenerateArray(sizeOfArray); // Первый вариант.
    int[] array = GenerateArray(sizeOfArray, 10, 23); // Второй вариант. Более гибкий.
    PrintArray(array);
    System.Console.WriteLine(CountElements(array, 1, 7));
}

int CountElements(int[] array, int end, int div)
{
    int count = 0;

    foreach (int number in array)
        if (number % 10 == end && number % div == 0)
            count++;
    return count;
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
    System.Console.WriteLine();
}

// int[] GenerateArray(int size)
// {
//     int[] tempArray = new int[size];
//     for (int i = 0; i < tempArray.Length; i++)
//     {
//         tempArray[i] = new Random().Next(0, 10); // Первый вариант.
//     }

//     return tempArray;
// }

// int[] GenerateArray(int size, int minRange, int maxRange)
// {
//     int[] tempArray = new int[size];
//     for (int i = 0; i < tempArray.Length; i++)
//     {
//         tempArray[i] = new Random().Next(minRange, maxRange); // Второй вариант. Более гибкий.
//         // tempArray[i] = new Random().Next(minRange, maxRange + 1); // "+1" означает, что конечное значение диапазона будет включено.
//     }

//     return tempArray;
// }

int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random temp = new Random(); // Альтернативный вариант, который существенно экономит RAM. Не выделяет в каждом цикле 
                                // новый экземпляр Random, а в одном цикле использует один.

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = temp.Next(minRange, maxRange + 1); 
    }

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}

main();