/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите произвольное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = number; i > 0; i = i / 10)
{
    result = result + i % 10;
}
Console.WriteLine($"Сумма цифр в числе {number} = " + result);