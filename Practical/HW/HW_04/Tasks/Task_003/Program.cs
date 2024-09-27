// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

// [1 3 5 6 7 8] => [8 7 6 5 3 1]


void Main()
{
    int[] arr = {1, 3, 5, 6, 7, 8};

    ReversedArray(arr);

    foreach (int number in arr)
        Console.Write(number + " ");
   
}

void ReversedArray(int[] arr)
{
    int length = arr.Length;
    int middle = length / 2;

    for (int i = 0; i < middle; i++)
    {
        int temp = arr[i];
        arr[i] = arr[length - 1 - i];
        arr[length - 1 - i] = temp;
    }
}

Main();