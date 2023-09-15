/* git push origin main
Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/

Console.WriteLine("Enter the number");

int number = Convert.ToInt32(Console.ReadLine());
int a = number;

Console.Write(-a);
Console.Write(" ");
while(a > -a)

{
    Console.Write(-a + 1);
    Console.Write(" ");
    a = a - 1;
    
}

int b = 0;

while(b < number)
{
    Console.Write(b+1);
    Console.Write(" ");
    b = b + 1;
}

