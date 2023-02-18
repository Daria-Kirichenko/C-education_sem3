// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Ax = ReadNumber("Введите координату х для точки А");
int Ay = ReadNumber("Введите координату y для точки А");
int Az = ReadNumber("Введите координату z для точки A");
int Bx = ReadNumber("Введите координату x для точки В");
int By = ReadNumber("Введите координату y для точки B");
int Bz = ReadNumber("Введите координату z для точки B");

double res = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2) + Math.Pow((Bz - Az), 2));
Console.WriteLine(res);