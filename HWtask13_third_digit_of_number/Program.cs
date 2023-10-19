/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigitNumber = 0;
if (number > 99)
{
    if (number > 99 && number < 999)
    {
        thirdDigitNumber = number % 10;
    }
    
    while (number > 999)
    {
        number = number / 10;
        thirdDigitNumber = number % 10;
    }
    System.Console.WriteLine(thirdDigitNumber);
}

else
{
    Console.WriteLine("there is no third digit");
}
