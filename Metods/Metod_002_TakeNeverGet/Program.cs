// Метод который принимает , но не возвращает 
// Пример:

void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.Write(msg);
        i++; //Инкримент
    }
}
Method2("Текст", 4);