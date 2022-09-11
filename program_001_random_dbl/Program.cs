// Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами

double GenerateDoubleInRange(double lowerBound,double UpperBound)
{
    Random rnd = new Random();
    double RandomDouble = lowerBound + rnd.NextDouble() * (UpperBound - lowerBound);
    return RandomDouble;
}

System.Console.WriteLine("Введите количество строк");
int rowsCount = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int columnsCount = Convert.ToInt32(Console.ReadLine());

double[,] twoDimArray = new double[rowsCount, columnsCount];

//переменная, определяющая количество знаком для округления числа double при выводе на экран
int round_quality = 4;

for (int i = 0; i < rowsCount; i++)
{
    for (int j = 0; j < columnsCount; j++)
    {
        twoDimArray[i, j] = GenerateDoubleInRange(-10,10);
        System.Console.Write(Math.Round(twoDimArray[i, j],round_quality) + "\t\t");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();