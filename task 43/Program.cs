// Задача 43: Напишите программу,
// которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// y = y
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x =  (b2 - b1)/(k1 - k2)
// y = k1 * x + b1

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите значения через пробел b1, k1, b2, k2: ");
string[] f = Console.ReadLine().Split();
double b1 = double.Parse(f[0]);
double k1 = double.Parse(f[1]);
double b2 = double.Parse(f[2]);
double k2 = double.Parse(f[3]);

if (ValidateCoordinate(b1, k1, b2, k2))
{
    Console.WriteLine("Координаты заданы верно!");
}
Console.WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));


bool ValidateCoordinate(double intb1, double intk1, double intb2, double intk2)
{

    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельные");
        return false;
    }
    else if(b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
        return false;
    }
    else
    {
        return true;
    }

}
  
double[] GetPoint(double inb1, double ink1, double inb2, double ink2)
{
    double [] result = new double[2];
    result [0] = (inb2 - inb1)/(ink1 - ink2);
    result [1]= (ink1 * result[0] + inb1);
    return result;
}
