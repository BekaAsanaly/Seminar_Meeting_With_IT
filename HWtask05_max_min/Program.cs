﻿/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Enter the number1");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number2");

int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("max=" + number1);
    Console.WriteLine("min=" + number2);
}

else
{
    Console.WriteLine("max=" + number2);
    Console.WriteLine("min=" + number1);
}