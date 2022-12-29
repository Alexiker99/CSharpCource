using static Methods;
public class Ex001TwoDimensionArrayOrdering
{
    static public void Task54()
    // Задача 54: Задайте двумерный массив. 
    // Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // В итоге получается вот такой массив:
    // 7 4 2 1
    // 9 5 3 2
    // 8 4 4 2
    {
        Console.WriteLine("введите количество строк");
        int linesVol = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите количество столбцов");
        int columnsVol = Convert.ToInt32(Console.ReadLine());
        int[,] numbers = new int[linesVol, columnsVol];
        FillArrayRandomNumbers(numbers);
        Console.WriteLine();
        Console.WriteLine("Массив до изменения");
        PrintArray(numbers);

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1) - 1; j++)
            {
                for (int z = 0; z < numbers.GetLength(1) - 1; z++)
                {
                    if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                    {
                        int temp = 0;
                        temp = numbers[i, z];
                        numbers[i, z] = numbers[i, z + 1];
                        numbers[i, z + 1] = temp;
                    }
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Массив с упорядоченными значениями");
        PrintArray(numbers);

    }
}