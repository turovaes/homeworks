Console.WriteLine("Введите первое число");

int number1;
int number2;
int number3;

while (!int.TryParse(Console.ReadLine(), out number1))
{
    Console.WriteLine("Вы ввели нецелое первое число");
}

Console.WriteLine("Введите второе число");

while (!int.TryParse(Console.ReadLine(), out number2))
{
    Console.WriteLine("Вы ввели нецелое второе число");
}

Console.WriteLine("Введите третье число");

while (!int.TryParse(Console.ReadLine(), out number3))
{
    Console.WriteLine("Вы ввели нецелое третье число");
}

int max = number1;

if (number2 > max)
{
    max = number2;
}
else if (number3 > max)
{
    max = number3;
}
Console.WriteLine("Max = " + max );
