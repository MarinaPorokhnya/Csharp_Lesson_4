// функция для создания двухмерного массива.
int [,] CreatMatrix(int rowsCount, int ColumnsCount)
{
    int[,] matrix = new int [rowsCount, ColumnsCount];

    Random rnd = new Random ();
    for (int i = 0; i < matrix.GetLength (0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix; // Возврат значения.
}
void ShowMatrix(int [,] matrix) //Функция для вывода массива на экран.Не возвращает значение.

{
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {

            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = CreatMatrix(3, 4);
ShowMatrix(matrix);// Цикл для перебора элементов массива:Foreach- не подходит для изменения элементов.
foreach (int e in matrix)
{
    if(IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if(sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}
