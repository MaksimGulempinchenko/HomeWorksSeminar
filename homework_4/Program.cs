// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// int Stepe(int num, int step)
// {
//     int sum = 1;
//     for(int current = 0; current < step; current++)
//     sum *= num;
// return sum;
// }



// Console.WriteLine(" ВВедите чило : ");
//  int a = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine(" ВВедите степень : ");
//  int a1 = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine($" Число {a} в степени {a1} = {Stepe(a,a1)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// int SumOfNumbers( int num)
// {
//  int sum = 0;
//         if(num == 0)
//         sum = -1;
//     while(num != 0)
//     {
//     sum += num % 10;
//     num = num / 10;
//     }
//     return sum;

// }
//     Console.Write("Input a num: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.Write($"sum numbers of number {a} is {SumOfNumbers(a)}");




// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.


// int[] array( int size)
// {
// int[] array = new int[size];
// for(int index = 0; index < size; index++)
// {
// Console.Write($"Input element of array {index + 1}: ");
// array[index] = Convert.ToInt32(Console.ReadLine());
// }
// return array;
// }

// void ShowArray(int[] array)
// {
//      for(int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = array(size);
// ShowArray(arr);






