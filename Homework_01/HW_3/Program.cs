﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("Число является чётным");
}
else
{
    Console.WriteLine("Число является не чётным");
}
