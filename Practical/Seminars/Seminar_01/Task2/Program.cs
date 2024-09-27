Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

// int i = -number; // упрощенное от "int i = number * -1;"

// while (i <= number)
// {
//     // где-то проблема
//     Console.Write(i + " ");
//     i++; // упрощенное от "i = i + 1;" или "i += 1;"
// }

for(int i = -number; i <= number; i++)
{
    Console.Write(i + " ");
}