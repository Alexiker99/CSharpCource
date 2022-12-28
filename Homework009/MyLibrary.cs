public class MyLibrary
{
    // Метод выведения двумерного вещественного массива  на экран
    public static void PrintDoubleArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
    // Метод заполнения рандомных вещественных чисел в двумерный массив
    public static void FillArrayRandomDoubleMassiveNumbers(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            }
        }
    }
    // Метод заполнения рандомных чисел в двумерный массив
    public static void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(-100, 100) / 10;
            }
        }
    }
    // Метод выведения массива на экран от (0 ; 10)
    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }

}