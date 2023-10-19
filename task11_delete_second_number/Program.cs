/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
456 -> 46
782 -> 72
918 -> 98
*/

int randomThreeDigitNumber = new Random().Next(100, 1000);
Console.WriteLine(randomThreeDigitNumber);

int number1 = randomThreeDigitNumber / 100;
int number2 = randomThreeDigitNumber % 10;

int TwoDigitNumber = number1 * 10 + number2;
Console.WriteLine(TwoDigitNumber);