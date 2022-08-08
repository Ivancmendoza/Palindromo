
using System.Text.RegularExpressions;

string Text = "";
Console.WriteLine("Escribe algo");
Text = Console.ReadLine();
string newText = Regex.Replace(Text, @"\s", "");
char[] charArray = newText.ToCharArray();
string reverse = String.Empty;
for (int i = charArray.Length - 1; i >= 0; i--)
{
    reverse += charArray[i];
}
if (reverse == newText)
{
    Console.WriteLine("{0} SI es un palindromo", Text);
}
else
{
    Console.WriteLine("{0} NO es un palindromo", Text);
}
