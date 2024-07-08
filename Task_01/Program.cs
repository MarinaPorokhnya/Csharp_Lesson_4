// Двумерные массивы
// Массив массивов - матрица.

// int[,] table = new int[3, 5]; //[,] номер строки, номер элемента
//                               // 3 - количество строк, 5 - количество элементов в строке
//                               // table - имя

// Способы создания двумерного массива
// int[,] table = new int[2, 4] {
//     { 1, 1, 1, 1 },
//     { 2, 2, 2, 2 }
// };

// int[,] table2 = new int[,] {
//     { 1, 1, 1, 1 },
//     { 2, 2, 2, 2 }
// };

// int[,] table3 = {
//     { 1, 1, 1, 1 },
//     { 2, 2, 2, 2 }
// };

// Задача 1
// Создать двумерный массив с размерами
// 3х5, состоящий из целых чисел.
// Вывести его элементы на экран.
// int[,] matrix = new int[3, 5];

// Random rnd = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {

//         matrix[i, j] = rnd.Next(1, 11);
//     }
// }

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");// Интерполяция строк.
//     }
//     Console.WriteLine();
// }
int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);