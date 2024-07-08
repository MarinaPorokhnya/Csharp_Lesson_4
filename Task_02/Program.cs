// 1- Функция выделяет память под массив некоторого размера 
//   и заполняет его случайными целыми числами.
// 
// 2- Для выделения участка памяти,нужно знать его размер.Размер матрицы в виде 
//    числа строк: rowsCount и числа столбцов: ColumnsCount,
//    передаем в качестве параметра. 
// 
// 3- Двумерный массив функция возвращает в качестве возвращаемого значения: int [,].
// 
// Функция CreateMatrix(Двумерный массив),которая генерирует двумерный массив
// из случайных целых чисел:

int [,] CreatMatrix(int rowsCount, int ColumnsCount)
{
    int [,] matrix = new int [rowsCount, ColumnsCount];

    Random rnd = new Random ();
    for (int i = 0; i < matrix.GetLength (0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i, j] = rnd.Next(1, 11);
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
int[,] matrix = CreatMatrix(4, 5);
ShowMatrix(matrix);