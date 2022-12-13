// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.WriteLine("Введите коэффициенты уравнений y = k1 * x + b1, y = k2 * x + b2");
int a1 = IntoInt();
int b1 = IntoInt();
int a2 = IntoInt();
int b2 = IntoInt();

double coordX = GetCoordCrosX(a1,b1,a2,b2);
double coordY = GetCoordCrosY(a1,b1,a2,b2);
Console.WriteLine($"Точка пересечения двух прямых - ({coordX}; {coordY})");


double GetCoordCrosX(int a1, int b1, int a2, int b2)
{
    if (a1 == a2)
    {
        throw new Exception("Деление на ноль");
    }
    double x = (double)(b2 - b1)/(a1 - a2);
    return x;
}

double GetCoordCrosY(int a1, int b1, int a2, int b2)
{
    double x = GetCoordCrosX(a1, b1, a2, b2);
    double y = a1*x + b1;
    return y;
    
}

int IntoInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);
    if (isParsed)
    {
        return num;
    }
    else
    {
        throw new Exception("Ввели не корректные данные");
    }

}