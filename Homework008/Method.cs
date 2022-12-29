public class Methods
{
    // Метод заполнения рандомных чисел в двумерный массив
    public static void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
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
    // Метод ввода вывода на экран
    public static int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }
}

