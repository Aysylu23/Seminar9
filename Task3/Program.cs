int number = ReadInt("Введите число: ");
Console.WriteLine(SumOfDigits(number));

int SumOfDigits(int number)
{
    if(number == 0)
        return 0;

    int digit = number % 10;
    int nextDigit = SumOfDigits(number / 10);
    return digit + nextDigit;
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}