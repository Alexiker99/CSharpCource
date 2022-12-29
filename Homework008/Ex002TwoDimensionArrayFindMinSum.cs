using static Methods;
public class Ex002TwoDimensionArrayFindMinSum
{
    static public void Task56()
    // Задача 56: Задайте прямоугольный двумерный массив. 
    // Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
    // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
    {
        Console.WriteLine("введите размер квадратного массива");
        int massVol = Convert.ToInt32(Console.ReadLine());
        int[,] numbers = new int[massVol, massVol];
        FillArrayRandomNumbers(numbers);
        PrintArray(numbers);
        int minSum = Int32.MaxValue;
        int indexLine = 0;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            int Sum = 0;
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Sum = Sum + numbers[i, j];
            }
            if (Sum < minSum)
            {
                minSum = Sum;
                indexLine++;
            }
        }

        Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minSum));
    }
}