Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write((num / 10) % 10);