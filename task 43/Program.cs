
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];
Console.Clear();

double[] CrossPoint(double[,] coeff)
{
    crossPoint[0] = (coeff[0, 0] - coeff[1, 0]) / (coeff[1, 1] - coeff[0, 1]);
    crossPoint[1] = (coeff[0, 1] * coeff[1, 0] - coeff[1, 1] * coeff[0, 0]) / (coeff[0, 1] - coeff[1, 1]);
    return crossPoint;
}
void inData()
{
    for (int i = 0; i < coeff.GetLength(0); i++)
    {
        for (int j = 0; j < coeff.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.Write($"Введите значение b" + (i + 1) + ": ");
            }
            else
            {
                Console.Write($"Введите значение k" + (i + 1) + ": ");
            }

            coeff[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }


}
void outData(double[,] coeff)
{
    if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] == coeff[1, 1])
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] != coeff[1, 1])
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        CrossPoint(coeff);
        Console.WriteLine($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

inData();
outData(coeff);