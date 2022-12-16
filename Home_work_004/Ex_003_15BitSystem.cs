using static MyLibrary;
public class Ex_003_15BitSystem
{
    
    public static void Task29()
    {
        // Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, 
        // записанного в СС по основанию 15
        // N: 3 [9, 4, 12] => 2097
        // Для проверки можно использовать https://numsys.ru/convert/2097/10/15

        System.Console.WriteLine(SystemBit(new int[] { 9, 4, 12 }));
        int [] ar = CreateArray(5); // Создали Массив из 3 цифр
        Fill(ar);
        int bit = SystemBit(ar);
        System.Console.WriteLine($"{Print(ar)} => {bit}"); // Вывод данных в консоль
    }
    
}