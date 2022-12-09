// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К", 
// а большие "С" заменить маленькими "С".


string text = "- Я думаю, -сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винцегероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// если string s = "qwerty"
//                  012345
//s[3]//r

string Replace(string text, char oldvValue, char newValue)
{
    string result = string.Empty;
    
    int length = text.Length;
    for(int i = 0; i < length;i++)
    {
       if (text [i] == oldvValue) result = result + $"{newValue}";
       else result = result + $"{text[i]}";
    }
   
   return result;
}  
string newText = Replace(text, ' ', '_');

Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
