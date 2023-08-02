/*// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreatRundom2Array(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for(int i = 0; i < rows; i++)
       for(int j = 0; j < colums; j++)
         array[i,j] = new Random().Next(0, 10);
    return array;
}

void Show2Array (int[,] array)
{
    for(int i= 0; i < array.GetLength(0); i++)
    {
        for(int j= 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
void SortDegreeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(1) - 1; l++)
            {
                if (array[i, l] < array[i, l + 1])
                {
                    int temp = array[i, l + 1];
                    array[i, l + 1] = array[i, l];
                    array[i, l] = temp;
                }
            }
        }
    }
}


Console.Write("Введите число рядов: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число колонок: ");
int colums = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreatRundom2Array(rows, colums);
Show2Array(myArray);
SortDegreeArray(myArray);
Console.WriteLine();
Show2Array(myArray);
*/

/*//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
int[,] CreatRundom2Array(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for(int i = 0; i < rows; i++)
       for(int j = 0; j < colums; j++)
         array[i,j] = new Random().Next(0, 10);
    return array;
}

void Show2Array (int[,] array)
{
    for(int i= 0; i < array.GetLength(0); i++)
    {
        for(int j= 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

void MinSumRow( int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($" МИнимальная сумма чисел в {minSumRow + 1} строке");
}

Console.Write("Введите число рядов: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число колонок: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreatRundom2Array(rows, colums);
Show2Array(myArray);
MinSumRow(myArray);
*/
/*//Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

int[,] FirstRundom2Array(int rows1, int colums1)
{
    int[,] array1 = new int[rows1, colums1];
    for(int i = 0; i < rows1; i++)
       for(int j = 0; j < colums1; j++)
         array1[i,j] = new Random().Next(0, 10);
    return array1;
}

void ShowArray (int[,] array)
{
    for(int m= 0; m < array.GetLength(0); m++)
    {
        for(int n= 0; n < array.GetLength(1); n++)
            Console.Write(array[m,n] + " ");
        
        Console.WriteLine();
    }
}
int[,] SecondRundom2Array(int rows2, int colums2)
{
    int[,] array2 = new int[rows2, colums2];
    for(int i = 0; i < rows2; i++)
       for(int j = 0; j < colums2; j++)
         array2[i,j] = new Random().Next(0, 10);
    return array2;
}


void MultiplyArray(int[,] Array1, int[,] Array2, int[,] resultArray)
{
    if (Array1.GetLength(0) != Array2.GetLength(1))
{
    Console.WriteLine("Нельзя перемножить");
    return;
}
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Array1.GetLength(1); k++)
      {
        sum += Array1[i,k] * Array2[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}

Console.Write("Введите число рядов первого массива: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число колонок первого массива и рядов второго массива: ");
int colums1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число рядов второго массива: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число колонок второго массива: ");
int colums2 = Convert.ToInt32(Console.ReadLine());
int[,] Array1 = FirstRundom2Array(rows1, colums1);
int[,] Array2 = SecondRundom2Array(rows2, colums2);
int[,] resultArray = new int[rows1,colums2];
Console.WriteLine($"Первая матрица:");
ShowArray(Array1);
Console.WriteLine($"Вторая матрица:");
ShowArray(Array2);
MultiplyArray(Array1, Array2, resultArray);
Console.WriteLine($"Произведение первой и второй матриц:");
ShowArray(resultArray);
*/
/*//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] sqareArray = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareArray.GetLength(0) * sqareArray.GetLength(1))
{
  sqareArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

void Show2Array (int[,] array)
{
    for(int i= 0; i < array.GetLength(0); i++)
    {
        for(int j= 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

Show2Array(sqareArray);
*/