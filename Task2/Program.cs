// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


int numberM = ReadIntInput("Введите число M: ");
int numberN = ReadIntInput("Введите число N: ");

PrintNumbers(numberM, numberN);

void PrintNumbers(int M, int N)
{

    if (M == N)
    {
        Console.Write(M + " ");
        return;
    }
    else if (M < N)
    {
        PrintNumbers(M, N - 1);
        Console.Write(N + " ");
    }
    else
    {
        Console.Write(M + " ");
        PrintNumbers(M - 1, N);
    }
    
}

int ReadIntInput(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    return int.Parse(input);
}