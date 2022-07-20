void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
           
        {
            matr[i, j] = new Random().Next(1, 10);
        }

    }
}

void PrintTwoDimArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] matrix1 = new int[4, 4];
FillArray(matrix1);
PrintTwoDimArray(matrix1);
Console.WriteLine();
SortTwoDimArray(matrix1);

 static void BubbleSort(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
                for (int j = 0; j < inArray.Length - i - 1; j++)
                {
                    if (inArray[j] < inArray[j + 1])
                    {
                        int temp = inArray[j];
                        inArray[j] = inArray[j + 1];
                        inArray[j + 1] = temp;
                    }
                }
        }


void SortTwoDimArray(int[,] matr)
{

     int[] row = new int[matr.GetLength(1)];
     for (int i = 0; i < matr.GetLength(0); i++)
     {
         for (int j = 0; j < matr.GetLength(1); j++)
             row[j] = matr[i, j];
         BubbleSort(row);
         Insert(true, i, row, matr);
     }
     PrintTwoDimArray(matr);
}


void Insert(bool isRow, int dim, int[] source, int[,] dest)
 {
     for (int k = 0; k < source.Length; k++)
     {
         if (isRow)
             dest[dim, k] = source[k];
         else
             dest[k, dim] = source[k];
     }
 }

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] matrix2 = new int[5, 4];
FillArray(matrix2);
PrintTwoDimArray(matrix2);

int MinRowSum = int.MaxValue, indexMinRow = 0;
void FindMinSum(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)   
        {
            Sum += matr[i, j];

        }
       if (Sum < MinRowSum)
       {
        MinRowSum = Sum;
       indexMinRow = i;
       }
    }

        Console.WriteLine("Строка с наименьшей суммой элементов: ");
        for (int j = 0; j<matr.GetLength(1); j++)
        Console.Write(matr[indexMinRow, j]);
}
FindMinSum(matrix2);



//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] matr1 = new int[4, 4];
int[,] matr2 = new int[4, 4];
FillArray(matr1);
FillArray(matr2);
PrintTwoDimArray(matr1);
Console.WriteLine();
PrintTwoDimArray(matr2);

int j = 0;
void MatrProduct(int[,] m1, int[,] m2)
{

for (int i = 0; i < m1.GetLength(0); i++)
 {
                for (j = 0; j < m1.GetLength(1); j++)
                { m1[i, j] = m1[i, j] * m2[i, j];
                Console.Write(m1[i, j]);
                Console.WriteLine("\n");
                }
              
 }
}

MatrProduct(matr1, matr2);


//Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int x = 3;
int y = 3;
int z = 3;

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"x({i}),y({j}),z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

//Задача 62: Заполните спирально массив 4 на 4.
int[,] SpireFill(int n)
        {
            var result = new int[n, n];
            for (int currentChar = 1, padding = 0; padding < n/2; padding++)
            {
                for (int j = padding; j < n - padding; j++)
                    result[padding, j] = currentChar;
                for (int j = padding; j < n - padding; j++)
                    result[n - padding - 1, j] = currentChar;
                for (int i = padding + 2; i < n - padding - 1; i++)
                    result[i, padding] = currentChar;
                for (int i = padding + 1; i < n - padding - 1; i++)
                    result[i, n - padding - 1] = currentChar;
                currentChar = 1 - currentChar;
                result[padding + 1, padding] = currentChar;
            }
            if (n%2 != 0 && result[0, 0] == 1)
                result[n/2, n/2] = 1;
            return result;
        }
PrintTwoDimArray(SpireFill(4));