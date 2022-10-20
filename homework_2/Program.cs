// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.



// int Number(int num)
// {
//     int des = num % 100;
//     int ed = des / 10;
// return ed;
// }


// Console.WriteLine("Input three - digit");
// int threeDigit = Convert.ToInt32(Console.ReadLine());
// int answer = Number(threeDigit);
// Console.WriteLine(answer);


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int FindNum(int num)                                                
// {
 
// while(num >= 1000)
//     {
//     num = num /10;
//     }
//        if(num >= 101 && num <= 1001) 
//         {
//         num = num % 10;
//         }
        
//          else
//           num = -1;
// return num;
// }

// Console.WriteLine("Input a number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
//  int answer = FindNum(num1);
//  Console.WriteLine(answer);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

 /*/ bool DaysOfWeek(int numDay)
{
    if(numDay == 6 || numDay == 7)
        return true;
    else
        return false;

}
Console.Write(" Input a number day of week: ");
int day = Convert.ToInt32(Console.ReadLine()); 
bool answer = DaysOfWeek(day);
Console.WriteLine($"This day {day} is {answer}"); /*/