/*
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число некратно первому, 
то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

Console.WriteLine("Enter the first number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number");
int number2 = Convert.ToInt32(Console.ReadLine());

int divisionReminder = number1 % number2;

if (number1 % number2 == 0)
{
    Console.WriteLine("the second number is a multiple of the first number");
}

else 
{
    Console.WriteLine("Division reminder is" + " " + "-" + " " + divisionReminder);
}


