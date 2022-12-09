//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

var n = Math.Abs(Convert.ToInt64(Console.ReadLine())); //Входные данные

while (n >= 100)
{
    n /= 10; 
}
var result = n % 10;
Console.WriteLine(result);