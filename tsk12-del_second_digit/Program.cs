﻿// Задача 12: Удалить вторую цифру трёхзначного числа.

int num = new Random().Next(100,1000);
Console.Clear();
Console.WriteLine ($"Случайное трехзначное число: {num}");
num = num / 100 * 10 + num % 10; // выковыриваем вторую цифру
Console.WriteLine ($"После удаления второй цифры оно превращается в число {num}");
