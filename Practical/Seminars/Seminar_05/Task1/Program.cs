int[,] numbers =
{
    {1, 5, -23, -3},
    {1, 5, 2, 34},
    {5, 2, 3, 4}
};

numbers[0, 1] = 99;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write(numbers[i, j] + "\t");
    }
    Console.WriteLine();
}