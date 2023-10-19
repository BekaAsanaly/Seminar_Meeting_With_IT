/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет5 
*/

Console.WriteLine("Enter the number1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number2");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 * number1 == number2 || number2 * number2 == number1)
{
    Console.WriteLine("one number is the square of the another number");
}

else 
{
    Console.WriteLine("one number isn't the square of the another number");
}