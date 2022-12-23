using static MyLibrary;
public class Ex001TwoDemensionalMassiveOfRandomDoubleNumber
{
    static public void Task47()
    // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    // и возвращает значение этого элемента или же указание, что такого элемента нет.
    // m = 3, n = 4.
    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9
    {
        Console.WriteLine("введите количество строк");
        int linesVol = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите количество столбцов");
        int columnsVol = Convert.ToInt32(Console.ReadLine());
        double[,] numbers = new double[linesVol, columnsVol];
        FillArrayRandomDoubleMassiveNumbers(numbers);
        PrintDoubleArray(numbers);
    }
}