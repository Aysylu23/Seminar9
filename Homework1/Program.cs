/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int n = ReadInt("Введите число n: ");
int number = 2;
PrintNumber(n, number);
Console.Write(1);

void PrintNumber(int n, int number)
{
    
    if(number > n)
   {
    return;
   } 
   PrintNumber(n, number + 1);
   Console.Write(number + " , ");
}


int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}