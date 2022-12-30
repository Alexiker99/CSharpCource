using static Methods;
public class Ex003AckermanFunction
{
    static public void Task68()
    // Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    // Даны два неотрицательных числа m и n.
    // m = 2, n = 3 -> A(m,n) = 9
    // m = 3, n = 2 -> A(m,n) = 29
    {
        Console.WriteLine("Введите два положительных числа: m и n.");
        int m = InputInt("Введите m: ");
        int n = InputInt("Введите n: ");
        Console.WriteLine($"A({m}, {n}) = {Ackerman(m, n)}");
    }
}