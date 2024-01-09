// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");


StringBuilder sb = new StringBuilder();
string str = sb.ToString();


 static string reverse1(string str)
{
    char[] charArr = str.ToCharArray();
    Array.Reverse(charArr);
    return new string(charArr);
}

string newstr = reverse1(str);
Console.WriteLine(newstr);
