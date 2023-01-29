Console.WriteLine("Введите число ");

if (int.TryParse(Console.ReadLine(), out int number))
{
    int ost = number % 2;

    if (ost == 0)
    {
        Console.WriteLine("Число делится на 2 без остатка");
    }
    else
    {
        Console.WriteLine("Число не делится на 2 без остатка");
    }
}
else Console.WriteLine("Вы ввели нецелое число");


