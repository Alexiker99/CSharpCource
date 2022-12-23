using static MyLibrary;
public class Ex002ReturnTwoDemensionalMassive
{
    static public void Task50()
    // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    // и возвращает значение этого элемента или же указание, что такого элемента нет.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    {
        Console.WriteLine("Введите № строки");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите № столбца");
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] numbers = new int[10, 10]; // Ввести двумерный массив в диапозоне (10 10)
        FillArrayRandomNumbers(numbers);

        if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
        {
            Console.WriteLine("такого элемента нет");
        }
        else
        {
            Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
        }

        PrintArray(numbers);
    }
}