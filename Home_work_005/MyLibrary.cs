public class MyLibrary
{
  // Метод заполнения рандомным трехзначным числом
 static public void FillArrayRandomPosNumbers(int[] numbers)
  {
    for(int i = 0; i < numbers.Length; i++)
    {
      numbers[i] = new Random().Next(100,999);
    }
  }
  // Метод заоплнения рандомным двухзначным числом от [-99 99]
  static public void FillArrayRandomNumbers(int[] numbers)
  {
    for(int i = 0; i < numbers.Length; i++)
    {
      numbers[i] = new Random().Next(-99,99);
    }
  }
  // Метод вывода в консоль 
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
  // Метод вывода в консоль  вещественых чисел
  static public void PrintDoubleArray(double[] numbers)
  {
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
      Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
  }
  // Метод заполнения для рандомных вещественных чисел
  public static void FillArrayRandomDoubleNumbers(double[] numbers)
{
  for(int i = 0; i < numbers.Length; i++)
  {
   numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
  }
}
}
