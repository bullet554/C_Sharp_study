// Задание 4: Замена отрицательных элементов в двумерном массиве.

// Описание: Задайте двумерный массив. Замените все отрицательные числа на их
// абсолютные значения.

// Пример входных данных:
// 1 -2 3
// -4 5 -6
// 7 -8 9

// Пример результата:
// 1 2 3
// 4 5 6
// 7 8 9

// Подсказка: Проходите по всем элементам массива. Если элемент отрицательный,
// замените его на его абсолютное значение.


void Main()
{
    int[,] array =
    {
    { 1, -2, 3 },
    { -4, 5, -6 },
    { 7, -8, 9 }
    };

    ReplaceNegativeNumbers(array);
}

void ReplaceNegativeNumbers(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (array[i, j] < 0)
            {
                array[i, j] *= -1;
            }
        }
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Main();