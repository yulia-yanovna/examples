using System;
using System.Text;

static string ReadLineUTF()
{
    ConsoleKeyInfo currentKey;
    var sBuilder = new StringBuilder();
    do
    {
        currentKey = Console.ReadKey();
        if (currentKey.Key != ConsoleKey.Enter)
            sBuilder.Append(currentKey.KeyChar);
    }
    while (currentKey.Key != ConsoleKey.Enter);
    Console.WriteLine();
    return sBuilder.ToString();
}


Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "yulia")
{
    Console.WriteLine("Ура, это же Yulia");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}