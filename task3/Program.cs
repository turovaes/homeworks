Console.WriteLine ("Введите число ");

if (int.TryParse(Console.ReadLine(), out int number))
{
    int mod = number % 2;
}
else Console.WriteLine("Вы ввели нецелое число")

if(mod == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
