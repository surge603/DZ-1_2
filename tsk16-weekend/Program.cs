// Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным

string[] week = {"Бездельник", "Повторник", "Бреда", "Чертегдерг", "Раслаблянница", "Клуббота", "Высплюсенье"};

Console.Clear();
Console.WriteLine("Введите номер дня недели (1-7): ");
int num = int.Parse(Console.ReadLine());
if (num < 1 || num > 7) {
    Console.WriteLine("Число не соответствует заданым параметрам!");
    return;
}

    Console.Write($"{num}-й день недели ({week[num-1]}) - это ");
if (num>5)
{
    Console.WriteLine("ВЫХОДНОЙ!!");
}
else 
    Console.WriteLine("будний день((");