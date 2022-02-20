// Задача 14: Найти третью цифру числа или сообщить, что её нет.

Console.Clear();
Console.WriteLine("Введите любое число от 0 до 100 000: ");
int num = int.Parse(Console.ReadLine());
if (num < 0 || num > 100000) {

    Console.WriteLine("Число не соответствует заданым параметрам!");
    return;
}
// Поскольку мы не знаем, со сколькизначным числом придется работать, проще работать с числом, как со строкой
string str = "" + num; // преобразуем число в строку. 

// Console.WriteLine("Случайное число: " + str);
// Console.WriteLine(str.Length);

if (str.Length < 3)
    Console.WriteLine("Третья цифра отсутствует");
else
{
    Console.WriteLine($"Третья цифра числа {str} - это {str[2]}");
}
