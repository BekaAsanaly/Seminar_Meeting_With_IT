/* 
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Валерия:
a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет 
*/

Console.WriteLine("Enter the number1");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number2");

int number2 = Convert.ToInt32(Console.ReadLine());

int multiplication = number2 * number2;

if (multiplication == number1)
{
    Console.WriteLine("the first number is the square of the second number");
}

else
{
    Console.WriteLine("the first number isn't the square of the second number");
}