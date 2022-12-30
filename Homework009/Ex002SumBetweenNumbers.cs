using static Methods;
public class Ex002SumBetweenNumbers
{
    static public void Task66()
    // Задайте значения M и N. 
    // Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    // M = 1; N = 15 -> 120
    // M = 4; N = 8. -> 30
    {
        int m = InputInt("Введите M:");
        int n = InputInt("Введите N:");
        Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");
    }
}