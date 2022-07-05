﻿
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
while (num > 0)
{
    sum = sum + num % 10;
    num = num / 10;
}

Console.WriteLine($"Сумма цифр введенного числа = {sum}");
