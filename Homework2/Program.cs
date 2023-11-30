/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int M = ReadInt("Введите число: ");
int N = ReadInt("Введите число: ");
int sum = 0;

if (M == N || M > N)
    {
        return;
    }

PrintNumbers(M, N, sum);

void PrintNumbers(int M, int N, int sum)
{
    
    sum = sum + N;
    if (N <= M)
    {
        Console.Write(sum);
        return;
    }
    PrintNumbers(M, N - 1, sum);
    
    
    
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
