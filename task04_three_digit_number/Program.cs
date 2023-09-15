/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Enter a three-digit number");

int number = Convert.ToInt32(Console.ReadLine());

int lust_number = 0;

if(number < 100 || number > 999)
{
    Console.WriteLine("Error, enter a three-digit number ");
}
else
{
    lust_number = number % 10;
    Console.WriteLine(lust_number);
}

