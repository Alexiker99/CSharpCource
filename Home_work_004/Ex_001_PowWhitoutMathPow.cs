
using static MyLibrary;
public class Ex_001_PowWithoutMathPow
{
    static public void Task25()
    // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    // 3, 5 -> 243 (3⁵)
    // 2, 4 -> 16
    // НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow
    {
        System.Console.WriteLine(Pow(2,4));
    }
}

