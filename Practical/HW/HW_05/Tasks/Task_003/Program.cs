// Задание 3: Транспонирование двумерного массива.

// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// транспонирует массив (меняет строки и столбцы местами).

// Пример входных данных:
// 1 2
// 3 4
// 5 6

// Пример результата:
// 1 3 5
// 2 4 6

// Подсказка: Создайте новый массив, который имеет размеры, поменянные местами.
// Заполните его значениями из исходного массива.


void Main()
{
    int[,] array =
    {
    { 1, 2 },
    { 3, 4 },
    { 5, 6 }
    };

    TransposeMatrix(array);
}

void TransposeMatrix(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[,] transposed = new int[cols, rows];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            transposed[j, i] = array[i, j];
        }
    }

    Console.WriteLine("Транспонированный массив:");
    for (int i = 0; i < transposed.GetLength(0); i++)
    {
        for (int j = 0; j < transposed.GetLength(1); j++)
        {
            Console.Write(transposed[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


Main();