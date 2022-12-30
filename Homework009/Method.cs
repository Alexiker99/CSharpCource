public class Methods
{
    // Метод ввода вывода на экран
    public static int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }
    // Метод  ввода натуральных чисел
    public static int NaturalNumber(int n, int m)
    {
        if (n == m)
            return n;
        else
            Console.Write($"{NaturalNumber(n, m + 1)}, ");
        return m;
    }
    // Метод нахождения суммы натуральных чисел
    public static int CountNaturalSum(int m, int n)
    {
        if (m == n)
            return n;
        return n + CountNaturalSum(m, n - 1);
    }
    // Метод Аккермана
    public static int Ackerman(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (m > 0 && n == 0)
            return Ackerman(m - 1, 1);
        else
            return Ackerman(m - 1, Ackerman(m, n - 1));
    }


}