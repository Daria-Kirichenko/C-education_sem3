// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int N = ReadNumber("Введите любое число (пятизначное):");
if(N > 9999 && N < 100000)
{
    int firstHalf = N / 1000;
    int lastDigit = N % 10;
    int preLastDigit = (N / 10) % 10;
    int secondHalf = lastDigit * 10 + preLastDigit;

    //Console.WriteLine(secondHalf);
    if (firstHalf == secondHalf)
    {
        Console.WriteLine("Ваше число является палиндромом");
    }
    else Console.WriteLine("Ваше число не палиндром");
}
else Console.WriteLine("Читайте условие внимательнее - число должно быть пятизначным");