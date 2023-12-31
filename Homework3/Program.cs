﻿/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int m = ReadInt("Введите число: ");
int n = ReadInt("Введите число: ");
int AckermanFunktion = ack(m, n);

Console.Write($"Функция Аккермана = {AckermanFunktion} ");

int ack(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(n == 0)
    {
        return ack(m - 1, 1);
    }
    else
    {
       return ack(m - 1, ack (m, n - 1));
    }
  
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}