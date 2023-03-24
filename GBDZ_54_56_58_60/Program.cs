////54
//int[,] table = new int[3, 4];
//FillArrayRandom(table);
//PrintArray(table);
//SortToLower(table);
//Console.WriteLine();
//PrintArray(table);


//void FillArrayRandom(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = new Random().Next(1, 10);
//        }
//    }
//}

//void SortToLower(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            for (int k = 0; k < array.GetLength(1) - 1; k++)
//            {
//                if (array[i, k] < array[i, k + 1])
//                {
//                    int temp = array[i, k + 1];
//                    array[i, k + 1] = array[i, k];
//                    array[i, k] = temp;
//                }
//            }
//        }
//    }
//}

//void PrintArray(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write($"{array[i, j]} ");
//        }
//        Console.WriteLine();
//    }
//}
//////56
//int m = 5;
//int n = 5;

//int[,] array = new int[m, n];
//CreateArray(array);
//WriteArray(array);

//int minSumLine = 0;
//int sumLine = SumLineElements(array, 0);
//for (int i = 1; i < array.GetLength(0); i++)
//{
//    int tempSumLine = SumLineElements(array, i);
//    if (sumLine > tempSumLine)
//    {
//        sumLine = tempSumLine;
//        minSumLine = i;
//    }
//}

//Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");


//int SumLineElements(int[,] array, int i)
//{
//    int sumLine = array[i, 0];
//    for (int j = 1; j < array.GetLength(1); j++)
//    {
//        sumLine += array[i, j];
//    }
//    return sumLine;
//}


//void CreateArray(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = new Random().Next(0,9);
//        }
//    }
//}

//void WriteArray(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write(array[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//}
//////58
//Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
//int m = InputNumbers("Введите число строк 1-й матрицы: ");
//int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
//int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
//int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

//int[,] firstMartrix = new int[m, n];
//CreateArray(firstMartrix);
//Console.WriteLine($"Первая матрица:");
//WriteArray(firstMartrix);

//int[,] secomdMartrix = new int[n, p];
//CreateArray(secomdMartrix);
//Console.WriteLine($"Вторая матрица:");
//WriteArray(secomdMartrix);

//int[,] resultMatrix = new int[m, p];

//MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
//Console.WriteLine($"Произведение первой и второй матриц:");
//WriteArray(resultMatrix);

//void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
//{
//    for (int i = 0; i < resultMatrix.GetLength(0); i++)
//    {
//        for (int j = 0; j < resultMatrix.GetLength(1); j++)
//        {
//            int sum = 0;
//            for (int k = 0; k < firstMartrix.GetLength(1); k++)
//            {
//                sum += firstMartrix[i, k] * secomdMartrix[k, j];
//            }
//            resultMatrix[i, j] = sum;
//        }
//    }
//}

//int InputNumbers(string input)
//{
//    Console.Write(input);
//    int output = Convert.ToInt32(Console.ReadLine());
//    return output;
//}

//void CreateArray(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = new Random().Next(range);
//        }
//    }
//}

//void WriteArray(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write(array[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//}
//////60
//int[,,] array3D = new int[2, 2, 2];
//FillArray(array3D);
//PrintIndex(array3D);


//void PrintIndex(int[,,] arr)
//{
//    for (int i = 0; i < array3D.GetLength(0); i++)
//    {
//        for (int j = 0; j < array3D.GetLength(1); j++)
//        {
//            Console.WriteLine();
//            for (int k = 0; k < array3D.GetLength(2); k++)
//            {
//                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//            }
//        }
//    }
//}


//void FillArray(int[,,] arr)
//{
//    int count = 10;
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//        for (int j = 0; j < arr.GetLength(1); j++)
//        {
//            for (int k = 0; k < arr.GetLength(2); k++)
//            {
//                arr[k, i, j] += count;
//                count += 3;
//            }
//        }
//    }
//}
////62
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
    sqareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(sqareMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}