using static MyLibrary;
public class Ex_001_ArrWithRandomPosNumb
{
    static public void Task34()
    //Задайте массив заполненный случайными положительными трёхзначными числами. 
    //Напишите программу, которая покажет количество чётных чисел в массиве.
    //[345, 897, 568, 234] -> 2
    {
        Console.WriteLine("Введите размер массива");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        FillArrayRandomPosNumbers(numbers);
        Console.WriteLine("Вот наш массив: ");
        PrintArray(numbers);
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        if (numbers[i] % 2 == 0)
        count++;

        Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");
    }
}