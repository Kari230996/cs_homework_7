// 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());


double[,] twoDimArray = new double[m, n];

Random rnd = new Random();


void PrintArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { Console.Write(String.Format("{0,5:f1}", matr[i, j])); }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { matr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0); }
    }
}


FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);



// 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//    и возвращает значение этого элемента или же указание, что такого элемента нет.


/*
Console.WriteLine("Введите номер строки");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int m1 = Convert.ToInt32(Console.ReadLine());




int m = 3;
int n = 4;


double[,] twoDimArray = new double[m, n];

Random rnd = new Random();

if (n > twoDimArray.GetLength(0) || m > twoDimArray.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {twoDimArray[n-1,m-1]}");
}


void PrintArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { Console.Write($"{matr[i, j]} "); }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { matr[i, j] = Convert.ToInt32(rnd.Next(0, 100)); }
    }
}

FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);

*/

/*

Console.WriteLine("Введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[10, 10];

FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100) / 10;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
}


*/

// 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


/*
Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());


double[,] twoDimArray = new double[m, n];

Random rnd = new Random();


void PrintArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { Console.Write(String.Format("{0,5:f0}", matr[i, j])); }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { matr[i, j] = Convert.ToInt32(rnd.Next(0, 10)); }
    }
}


FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);
Console.WriteLine();

for (int j = 0; j < twoDimArray.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < twoDimArray.GetLength(0); i++)
    {
        avarage += twoDimArray[i, j];
    }

    avarage = avarage / n;

    Console.WriteLine("Среднее арифметическое число " + (j + 1) + " столбца равно " + avarage);
}

*/