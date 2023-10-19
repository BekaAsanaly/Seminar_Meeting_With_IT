/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Enter the three digit number");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int remainder1 = number % 10;
    int TwoDigitNumber = (number - remainder1) / 10;
    int resultRemainder = TwoDigitNumber % 10;
    Console.WriteLine($"second digit of this number - {resultRemainder}");
}
else 
{
    Console.WriteLine(" Error. Enter the three digit number");
}



