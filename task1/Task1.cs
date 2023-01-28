// Задача 1

Console.WriteLine("Введите первое число");

if (!int.TryParse(Console.ReadLine(), out int number1))
{
    Console.WriteLine("Вы ввели нецелое число");
}

Console.WriteLine("Введите второе число");

if (!int.TryParse(Console.ReadLine(), out int number2))
{
    Console.WriteLine("Вы ввели нецелое число");
}


if (number1 > number2)
{
    Console.WriteLine("Большее число = " + number1 + ", меньшее число = " + number2);
}
else
{
    Console.WriteLine("Большее число = " + number2 + ", меньшее число = " + number1);
}

