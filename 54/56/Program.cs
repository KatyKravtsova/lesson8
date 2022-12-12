//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите размер массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
CreateArray(array);
WriteArray (array);
SearchArrayRowsMinimalSum (array);

void CreateArray(int[,] array) //Метод содания массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,100);
        }
    }
}
void WriteArray(int[,] array) //метод вывода массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void SearchArrayRowsMinimalSum (int [,] array)
{
    int sumFirstString = 0;
    int sumSecondString = 0;
    int minString = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sumFirstString = sumFirstString + array[i, j];
            }

            if (sumSecondString == 0)
            {
                sumSecondString = sumFirstString;
            }

            if (sumFirstString < sumSecondString)
            {
                sumSecondString = sumFirstString;
                minString = i + 1;
            }
            Console.WriteLine($"Сумма каждой строки {sumFirstString}");
            sumFirstString = 0;
        }
    Console.WriteLine();
    Console.WriteLine($"Строка массива с минимальным значением = {minString}");
}

