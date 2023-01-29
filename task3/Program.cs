Console.WriteLine("Введите число ");

if (int.TryParse(Console.ReadLine(), out int number))
{
    int ost = number % 2;

    if (ost == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else Console.WriteLine("Вы ввели нецелое число");


