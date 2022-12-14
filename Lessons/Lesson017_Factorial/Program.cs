//Нахождение факотриала с помошью Рекурсии.

double Factorial (int n)
{
    // 1! = 1                                    5! = 5*!4
    // 0! = 1                                            4*!3
    if(n == 1) return 1;                  //                3*!2
    else return n * Factorial (n - 1);     //                  2*!1
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
