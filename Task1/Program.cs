// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] ArrayOfRealNumbers(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    return newArray;
}

void ShowArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j], 1) + " ");
        Console.WriteLine();
    }
}

Console.WriteLine("Input number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = ArrayOfRealNumbers(m,n,1,9);
ShowArray(myArray);