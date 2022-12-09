//Метод который ничего ни принимает, но дает какой то аргумент
//Пример

int Method3()
{
   return DateTime.Now.Year; 

}

int year = Method3();
Console.WriteLine(year);