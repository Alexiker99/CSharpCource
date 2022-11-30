//Нахождение индекса при помощи Функции//Печать на экран

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)

{
 int count = col.Length;
 int position = 0;
 while (position < count)
 {
    Console.WriteLine(col[position]);
    position++;
 }
}

int IndexOf(Int[] collection, int find)
{
   int count = collection.Length;
   int index = 0;
   int position = 0; 
   while (index < count)
   {
    if(collection[index] == find)
    {
        position = index;
    }
    index++;
   }
    return position;
}

int[] array = new int [10];

array[4] = 4;
array[6] = 4;

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);