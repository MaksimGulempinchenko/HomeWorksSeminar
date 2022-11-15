// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] CreateArray(int size, int min, int max)
// {
//     int [] array = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");
// Console.WriteLine();
// }

// int CountEvenNum(int[] array)
// {
//     int current = 0;
//     for(int i = 0; i < array.Length; i++ )
//     if(array[i] % 2 == 0)
//     current++;
//     return current;
// }
// Console.Write("Input size of array: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = CreateArray(a, 100, 1000);
// ShowArray(arr);
// Console.Write($"count even numbers of array is {CountEvenNum(arr)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreatArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(min, max);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");
//  Console.WriteLine();

// }

// int SumElements(int[] array)
// {
//     int sum = 0;
//     for( int i = 0; i < array.Length; i++)
//     if(i % 2 != 0)
//     sum += array[i];
//     return sum;
// }

// Console.Write("Input size of array: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = CreatArray(a, 1, 300);
// ShowArray(arr);
// Console.Write($"Sum uneven numbers of array is {SumElements(arr)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] CreateArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < array.Length; i++)
    array[i] =new Random(). NextDouble();
    return array;

}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(Math.Round( array[i], 2)  + " ");
Console.WriteLine();

}

double Difference(double[] array)
{
    int min = 0;
    int max = 1;
    double diff = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[min])
        array[min] = array[i];
        
        if ( array[i] > array[max] )
        array[max] = array[i];
    
    }
    
   diff =  array[max] - array[min];
    
 return diff;

}

Console.Write("input size of array: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(a);
ShowArray(array);
double diff = Difference(array);

Console.Write(Math.Round( diff, 2));
