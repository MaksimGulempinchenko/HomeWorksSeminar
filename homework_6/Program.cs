// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[] Array(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//     Console.Write($"Input element {i + 1} of array: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     }
   
//     return array;

// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++){
//     Console.Write(array[i] + " ");}
// Console.WriteLine();

// }

// int MoreNull(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     if(array[i] > 0)
//     count += 1;
// return count;
// }
// Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = Array(size);
// ShowArray(arr);
// Console.WriteLine(MoreNull(arr));

//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void Point(double k1, double b1, double k2, double b2)
// {
// double x = (b1-b2)/(k2-k1);
// double y = (k2*b1-k1*b2)/(k2-k1);
// if(k1==k2) Console.Write("Заданные прямые не пересекаются!");
// else
// Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
// }

// Console.WriteLine("Input b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Point(k1,b1,k2,b2);