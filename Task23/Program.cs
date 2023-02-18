// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int N = ReadNumber("Введите любое число:");
for(int i = 1; i <= N; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}