// Прграмма, которая вычисляет среднее арифметическое элементов в каждом столбце заданного двумерного массива из целых чисел. 

System.Console.WriteLine("Введите количество строк");
int rowsCount = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int columnsCount = Convert.ToInt32(Console.ReadLine());

// Одномерный массив для сохранения результатов вычисдения среднего арифметического
double[] ColumnAverege = new double[columnsCount];

// Задаем двумерный массив случайных целых чисел
int[,] twoDimArray = new int[rowsCount, columnsCount];
Random rnd = new Random();
for (int i = 0; i < rowsCount; i++)
{
    for (int j = 0; j < columnsCount; j++)
    {
        twoDimArray[i, j] = rnd.Next(1, 100);
        ColumnAverege[j] += twoDimArray[i, j];
        System.Console.Write(twoDimArray[i, j] + "\t");

    }
    System.Console.WriteLine();
}

System.Console.WriteLine();

System.Console.WriteLine("Среднее арифметическое элементов в каждом столбце");
for (int index=0; index < columnsCount; index++)
{
    ColumnAverege[index] = ColumnAverege[index] / rowsCount;
    System.Console.Write(Math.Round(ColumnAverege[index],2) + "\t");
}

System.Console.WriteLine();