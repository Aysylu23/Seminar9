/*Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/


int numberM = ReadInt("Введите число M: ");
int numberN = ReadInt("Введите число N: ");

int PrintNumbers(int M, int N)
{
    if(M == N)
       Console.WriteLine(M);
       return;
    else 
       
}


int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}