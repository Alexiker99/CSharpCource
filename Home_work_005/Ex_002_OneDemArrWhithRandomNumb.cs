using static MyLibrary;
public class Ex_002_OneDemArrWhithRandomNumb
{
    static public void Task36()
    //Задайте одномерный массив, заполненный случайными числами. 
    //Найдите сумму элементов, стоящих на нечётных позициях.
    //[3, 7, 23, 12] -> 19
    //[-4, -6, 89, 6] -> 0
    {
        Console.WriteLine("Введите размер массива");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        FillArrayRandomNumbers(numbers);
        Console.WriteLine("Вот наш массив: ");
        PrintArray(numbers);
        int sum = 0;

        for (int i = 0; i < numbers.Length; i+=2)
        sum = sum + numbers[i];

        Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");
    }
}