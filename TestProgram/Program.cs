using System.Text;
StringBuilder sb = new StringBuilder();

// 1. Add "Hello, world!" to the StringBuilder
sb.Append("Hello, world!");

// 2. Convert StringBuilder content to a string, reverse it, and update the StringBuilder
string reversedString = sb.ToString();
char[] charArray = reversedString.ToCharArray();
Array.Reverse(charArray);
sb.Clear();
sb.Append(charArray);

Console.WriteLine(sb);
