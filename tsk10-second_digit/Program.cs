// Задача 10: Показать вторую цифру трёхзначного числа.

int num = new Random().Next(100,1000);
Console.Clear();
Console.WriteLine ($"Вторая цифра числа {num} - это " + num%100/10);