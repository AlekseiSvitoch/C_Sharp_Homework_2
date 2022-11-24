Console.Clear();
Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine()); // ввод чисел
while (day < 1 || day > 7)
{
    Console.Write("Вы ошиблись!\nВведите номер дня недели: ");
    day = Convert.ToInt32(Console.ReadLine());    
}

if (day <= 5)
{
    Console.WriteLine("Рабочий");
}

else
{
    Console.WriteLine("Выходной");
}
