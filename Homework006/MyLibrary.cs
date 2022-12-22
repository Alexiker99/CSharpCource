public class MyLibrary
{
// Метод вывода результата на экран
  static public void PrintArray(int[] numbers)
  {
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
     Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
  }
}
 