//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.Блок схема и Код

//14212 -> нет

//12821 -> да

//23432 -> да

//__СТРОКИ ИСПОЛЬЗОВАТЬ НЕЛЬЗЯ__

void palindrome()
{
  Console.Write("Введите пятизначное число: ");

  int n = Convert.ToInt32(Console.ReadLine()); 
  int n1 = n / 10000 % 10;
  int n2 = n / 1000 % 10;
  int r1 = n / 10 % 10;
  int r2 = n % 10;
  int nul =  n / 10000;
        
 if (nul < 1 || nul > 9)
 {
    Console.WriteLine(n + " -> " + "Не пятизначное число");
 }
 else 
    if  (n1 == r2 && n2 == r1)
    {
        Console.WriteLine(n + " -> Да это палиндром!");
     }
    else
        {
            Console.WriteLine(n + " -> Нет, это не палиндром...");
        }
 }

        for (int i = 0; i < 10; i++)
palindrome();

