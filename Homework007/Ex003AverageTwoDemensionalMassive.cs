using static MyLibrary;
public class Ex003AverageTwoDemensionalMassive
{
    static public void Task52()
    // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
    // Например, задан массив: 1 4 7 2 5 9 2 3 8 4 2 4 
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    {
        Console.WriteLine("введите количество строк");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите количество столбцов");
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] numbers = new int[n, m];
        FillArrayRandomNumbers(numbers);


        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            double avarage = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                avarage = (avarage + numbers[i, j]);
            }
            avarage = avarage / n;
            Console.Write(avarage + "; ");
        }
        Console.WriteLine();
        PrintArray(numbers);
    }
}