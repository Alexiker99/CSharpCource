﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Юля")
{
    Console.WriteLine("Ура, это же Юля!");
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}