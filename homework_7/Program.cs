// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// double[,] CreateRandom2Array(int rows, int columns)
// {
//     double[,] array = new double[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++) 
//         array[i,j] =Math.Round( new Random(). NextDouble(),2);

//     }
//     return array;

// }
// void ShowArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
            
     
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("input rows of array: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("input columns of array: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] array2 = CreateRandom2Array(rows,columns);
// ShowArray(array2);

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.



// int[,] CreateRandom2Array(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         array[i,j] = new Random().Next( min, max + 1);

//     }    
//     Console.WriteLine();
// return array;
// }

// void ShowArray(int [,] array)
// {
// Console.WriteLine();
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
// Console.WriteLine();
// }

// void ShowFindNum(int[,] array, int i  , int j)
// {

// if(i > array.GetLength(0) || j > array.GetLength(1) )  
// Console.WriteLine("Error");
// else
// Console.WriteLine($"Your num is  {array[i ,j ]} ");


    
// }
// Console.Write("Input rows of array: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns of array: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int[,] arr = CreateRandom2Array(a,b,1,10);
// Console.Write("Input rows find num: ");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns find num: ");
// int d = Convert.ToInt32(Console.ReadLine());
// ShowArray(arr);
// ShowFindNum( arr, c , d );

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int [,] CreateRandom2Array(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++) 
        array[i,j] =new Random().Next(min, max);

    }
    return array;

}
void ShowArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
            
     
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
    Console.Write(array[i] + " ");
            
    }
    Console.WriteLine();
}


double[] Arithmetic(int[,] array)
{
    double sum = 0;
    double[] arithmeticArray = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++ )
    {

        for(int j = 0; j < array.GetLength(0); j++)
        {
        sum += array[j, i];
        }
     arithmeticArray[i] = Math.Round( sum / array.GetLength(0),2);
     sum = 0;
    }   
    return arithmeticArray;
}

Console.Write("Input rows of array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns of array: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] arr =( CreateRandom2Array(a,b,1,10));
double[] arra2 = Arithmetic(arr);
ShowArrayInt(arr);
ShowArrayDouble( arra2);


