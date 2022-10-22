// Поиск слова
void FindWords(string alphabet, char[] word, int length)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{new String(word)}"); return;
    }
    for (int i = 0; i <= alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[5], 5);