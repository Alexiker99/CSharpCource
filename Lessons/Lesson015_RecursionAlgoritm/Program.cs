
string[,] table = new string [2, 5];
//String.Emty
//table [0,0] table[0,1] table[0, 2] table[0, 4]
//table [1,0] table[1,1] table [1, 2] table [1,4]
table[1, 2] = "Привет";
// Воспользуемся циклом в цикле

for(int rows = 0; rows < 2; rows++) //Колличество строк
{
    for(int columns = 0; columns < 5; columns++) // Колличество столбцов 
    {
        Console.WriteLine($"-{table[rows, columns]}-"); //Вывод данных
    }
        
}
