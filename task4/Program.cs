Console.WriteLine("Введите число ");

if (int.TryParse(Console.ReadLine(), out int number))
{

    for (int i = 1; i <= number; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
}
else
{
    Console.WriteLine("Вы ввели нецелое число");
}