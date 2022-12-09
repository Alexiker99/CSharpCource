// Самый главный и частый метод, который принимает на входе и дает на выходе.
// Пример 
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;

}

string result = Method4(10, "z");
Console.WriteLine(result);