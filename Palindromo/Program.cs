
string text = "";
Console.WriteLine("Escribe algo");
text = Console.ReadLine();
char[] charArray = text.ToCharArray();
string reverse = String.Empty;
for (int i = charArray.Length - 1; i >= 0; i--)
{
    reverse += charArray[i];
}
if (reverse == text)
{
    Console.WriteLine("Este texto es un palindromo");
}
else
{
    Console.WriteLine("Este texto no es un palindromo");
}

