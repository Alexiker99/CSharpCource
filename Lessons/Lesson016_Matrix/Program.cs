int [,] matrix = new int [3, 4]; // вывести матрицу [3,4]
 void PrintArray(int[,] matr)
{

 for(int i = 0; i < matr.GetLength(0); i++) //Колличество строк
 {
    for(int j = 0; j < matr.GetLength(1); j++) // Колличество столбцов 
    {
        Console.Write($"{matr[i, j]} "); //Вывод данных
    }
        
  Console.WriteLine();
 }
}

void FillArray(int[,] matr)
{

 for(int i = 0; i < matr.GetLength(0); i++) //Колличество строк
 {
    for(int j = 0; j < matr.GetLength(1); j++) // Колличество столбцов 
    {
        matr[i,j] = new Random().Next(1,10);// Полуинтервал [1;10). Обращаемся к конкретной позиции 
    }

 }

}
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);