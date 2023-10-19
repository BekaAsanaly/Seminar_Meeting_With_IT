/*
Напишите программу, которая выводит случайное число из отрезка [10, 99]  и показывает наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8
*/

int randomNumber = new Random().Next(10, 100);
Console.WriteLine (randomNumber);

int number1 = randomNumber / 10;
int number2 = randomNumber % 10;

int max = number1;
if (number2 > number1) max = number2;

Console.WriteLine(max);