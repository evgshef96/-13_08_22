// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

void CubedNumbersTable(int number)
{
    for(int i = 1; i <= number; i++)
    {
        int cubedNumber = i * i * i;
        Console.WriteLine($"{i}^3 = {cubedNumber}");
    }       
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
CubedNumbersTable(number);
