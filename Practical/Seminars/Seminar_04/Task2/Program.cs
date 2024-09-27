// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

void main()
{
    int sizeOfArray = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(sizeOfArray, 0, 9); 
    if (sizeOfArray < 1 || sizeOfArray > 8)
    {
        System.Console.WriteLine("Размер массива должен быть в диапазоне от 1 до 8.");
        return;
    }
    PrintArray(array);
    // System.Console.WriteLine(Convert.ToInt32(string.Concat(array))); // Конкатинация. Этот метод объединяет все 
                                                                        // элементы массива в одну цельную строку.
                                                                        // Метод ToInt32() конвертирует строку в целое число.
    System.Console.WriteLine(FromArrayToNumber(array));
}

int FromArrayToNumber(int[] array) // Математический способ.
{
    int resultNumber = 0;

    foreach (int element in array)
    {
        resultNumber *= 10;
        resultNumber += element;
    }

    return resultNumber;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]"); // Метод вывода массива одной строкой с разделетелем.
}

int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random temp = new Random(); 
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