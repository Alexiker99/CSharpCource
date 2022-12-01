//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. Блок схема и Код
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Start"); // Начало

Console.WriteLine("Введите длину: "); // Вводим строку с названием
int N = int.Parse(Console.ReadLine()); // Входные данные
    
for (int i = 2; i <= N; i += 2){  // Вводим цикл для
    Console.WriteLine(i);
}
  
Console.WriteLine("End"); // Конец
