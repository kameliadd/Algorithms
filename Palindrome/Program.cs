using System;

while (true)
{
    Console.Write("Enter word: ");

    string word = Console.ReadLine();

    bool isPalindrome = false;
    int j = word.Length - 1;


    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] == word[j])
        {
            isPalindrome = true;
        }
        else
        {
            isPalindrome = false;
            break;
        }

        j--;
    }


    if (isPalindrome)
        Console.Write("It's Palendorm.");
    else
        Console.Write("It's not Palendorm.");

    Console.WriteLine(string.Join(Environment.NewLine, Enumerable.Repeat(string.Empty, 2)));
}
