/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Enter the number of day");

int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
    if (number == 1)
    {
        Console.WriteLine("Monday");
    }

    if (number == 2)
    {
        Console.WriteLine("Tuesday");
    }

    if (number == 3)
    {
        Console.WriteLine("Wednesday");
    }

    if (number == 4)
    {
        Console.WriteLine("Thursday");
    }

    if (number == 5)
    {
        Console.WriteLine("Friday");
    }

    if (number == 6)
    {
        Console.WriteLine("Saturday");
    }

    if (number == 7)
    {
        Console.WriteLine("Sunday");
    }

    if (number == 6 || number ==7)
    {
        Console.WriteLine("this day is a weekend");
    } 

    else
    {
        Console.WriteLine("this day is a weekday");
    }
}

else 
{
    System.Console.WriteLine("there is no such day of the week");
}











