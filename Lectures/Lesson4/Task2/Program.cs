int[,] CreateMatrix(int rowCount, int colCount)
{
    int[,] matrix = new int[rowCount, colCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(1, 1000);
    }
    return matrix;
}

int[,] matrix = CreateMatrix(3, 4);

foreach (int e in matrix)
{
    if (IsInteresting(0) == true)
        Console.WriteLine(e);
}
bool IsInteresting()
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
        return true;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}