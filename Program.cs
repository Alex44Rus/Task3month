void PrintArray(string[] words)

{
    int size = words.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{words[i]}  ");
    }
}



void FinalTask3month()
{
    string[] words = new string[] { "hello", "2", "world", ":-)" };
    int lengthWords = words.Length;

    string[] newwords = new string[lengthWords];
    int j = 0;
    for (int i = 0; i < lengthWords; i++)
    {
        int count = words[i].Length;
        if (count <= 3)
        {
            newwords[j] = words[i];
            j++;

        }
    }
    lengthWords = j;

    PrintArray(words);
    Console.WriteLine();
    Console.WriteLine();
    PrintArray(newwords);
}



FinalTask3month();