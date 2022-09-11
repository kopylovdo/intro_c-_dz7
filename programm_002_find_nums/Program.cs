// программа, которая на вход принимает позиции (две) элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

System.Console.WriteLine("Введите количество строк");
int rowsCount = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int columnsCount = Convert.ToInt32(Console.ReadLine());

// Задаем двумерный массив случайных целых чисел
int[,] twoDimArray = new int[rowsCount, columnsCount];
Random rnd = new Random();
for (int i = 0; i < rowsCount; i++)
{
    for (int j = 0; j < columnsCount; j++)
    {
        twoDimArray[i, j] = rnd.Next(1, 100);
        System.Console.Write(twoDimArray[i, j] + "\t");

    }
    System.Console.WriteLine();
}
System.Console.WriteLine();


System.Console.WriteLine("Введите номер строки искомго элемента");
int RowPosition = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер стобца искомго элемента");
int ColumnPosition = Convert.ToInt32(Console.ReadLine());


//Находим значение искомого элемента по введенной пользователем позиции или указываем, что такого элемента нет.
if ((RowPosition >= rowsCount) || (ColumnPosition >= columnsCount))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Искомый элемент - {twoDimArray[RowPosition, ColumnPosition]}");
}