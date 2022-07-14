//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int[] ColumnsSum(int[,] array, int columns)
{
    int[] sum = new int[columns];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sum[i] = sum[i] + array[j, i];
    return sum;
}

double[] ArithmeticMean(int[] array, int columns)
{
    double[] AM = new double[columns];

    for (int i = 0; i < array.Length; i++)
        AM[i] = (double)array[i] / columns;
    
    return AM;
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(m, n, 1, 9);
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine(string.Join(",", ColumnsSum(myArray, m)));
Console.WriteLine();
Console.WriteLine(string.Join(";", ArithmeticMean(ColumnsSum(myArray, m), m)));



