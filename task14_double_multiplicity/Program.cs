﻿/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
14 -> нет
46 -> нет
161 -> да
*/

Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 ==0)
{
    System.Console.WriteLine("number is a multiple of 7 and 23");
}

else 
{
    System.Console.WriteLine("number isn't a multiple of 7 and 23");
}