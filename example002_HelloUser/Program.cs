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
Console.Write("ВВедите ваше имя ");
string username = ReadLineUTF();
Console.Write("Привет, ");
Console.Write(username);



