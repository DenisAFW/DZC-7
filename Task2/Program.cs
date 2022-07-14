// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int rows = 10;
int columns = 10;

int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

void InputPosition(int a, int b, int[,] array)
{
    if(a<= array.Length && b<=array.Length)
        Console.WriteLine(array[a,b] + " ");

    else Console.WriteLine("Число с заданными индексами отсутствует");
}

Console.WriteLine("Введите первый и второй индексы по очереди.");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(rows, columns, 1,9);
ShowArray(myArray);
Console.WriteLine();
InputPosition(a,b,myArray);