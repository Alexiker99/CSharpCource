using static MyLibrary;
public class Ex_003_DoubleDiffMinMax
{
    static public void Task38()
    //Задайте массив вещественных чисел. 
    //Найдите разницу между максимальным и минимальным элементов массива.
    //[3 7 22 2 78] -> 76
    {
        Console.WriteLine("Введите размер массива");
        int size = Convert.ToInt32(Console.ReadLine());
        double[] numbers = new double[size];
        FillArrayRandomDoubleNumbers(numbers);
        Console.WriteLine("Вот наш массив: ");
        PrintDoubleArray(numbers);
        double min = Int32.MaxValue;
        double max = Int32.MinValue;

        for (int z = 0; z < numbers.Length; z++)
        {
            if (numbers[z] > max)
            {
                max = numbers[z];
            }
            if (numbers[z] < min)
                {
                min = numbers[z];
             }
        }  

        Console.WriteLine($"всего {numbers.Length} чисел. MAX = {max}, MAX = {min}");
        Console.WriteLine($"Разница MAX и MIN = {max - min}");
    }
}