// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

// [344 452 341 125] => 2


void main()
{
    int sizeOfArray = ReadInt("Введите размер массива: ");

    if (sizeOfArray < 1)
    {
        System.Console.WriteLine("Размер массива должен быть > 1.");
        return;
    }
    int[] array = GenerateArray(sizeOfArray, 100, 1000); 
    PrintArray(array);

    System.Console.WriteLine(EvenNumber(array));
}


int EvenNumber(int[] array)
{
    int count = 0;
    foreach (int number in array)
        if (number % 2 == 0)
            count++;
            
    return count;
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