// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"

// N = 6 -> "1, 2, 3, 4, 5, 6"

int number = ReadInt("Введите число: ");
PrintNumbers(number);

void PrintNumbers(int n)
{
    if(n == 0)
        return;

    PrintNumbers(n - 1);
    Console.Write(n + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}