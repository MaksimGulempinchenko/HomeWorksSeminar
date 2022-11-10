// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void CheckPalindromic(int number)
// {
//     if(number >= 10000)
//     {
//         int division1 = number / 10000;
//         int remainder1 = number % 10;
 
//             if(division1 == remainder1)
//             {
//                 number = number / 10;
//                 int division2 = (number / 100) % 10;
//                 int remainder2 = number % 10;
//                 if(division2 == remainder2)
//                     Console.WriteLine("Yes");
//             }
//             else 
//             Console.WriteLine("No");
            
//     }
//     else
//     Console.WriteLine("Wrong number");
// }
 
// Console.WriteLine("Imput a five-digit: ");
// int number = Convert.ToInt32(Console.ReadLine());
// CheckPalindromic(number);






// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.



// void Task(int num)
// {
//  int current = 1;
//  while (current <= num)
// {
//     double result = Math.Pow(current,3);
//     Console.Write(result + " ");
//     current++;
// }
// }
// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Task(a);


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// double FindPoint(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double pointX = x1 - x2;
//     double pointY = y1 - y2;
//     double poitZ = z1 - z2;
//     double result = Math.Sqrt(pointX*pointX + pointY*pointY + poitZ*poitZ);
//     return result;
// }

// Console.Write(" Введите координаты х1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write(" Введите координаты y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write(" Ввеите координаты z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write(" Ввудите координаты х2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write(" Введите координаты y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write(" Введите координаты z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());


// double answer = FindPoint(x1, y1, z1, x2,y2,z2);
// double answer1= Math.Round(answer,2);
// Console.WriteLine($"Answer: {answer1} ");