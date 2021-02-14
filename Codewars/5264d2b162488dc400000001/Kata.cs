using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

public class Kata
{
    public static string SpinWords(string sentence)
    {
        Console.WriteLine(sentence);
        List<string> words = new List<string>();
        words = sentence.Split(' ').ToList();
        for (int i = 0; i <= words.Count() - 1; i++)
        {
            if (words[i].Length >= 5)
            {
                Console.WriteLine(words[i] + " is gt 5");
                words[i] = Reverse(words[i]);
            }
        }
        var output = String.Join(" ", words);
        Console.WriteLine(output);
        return output;
    }

    private static string Reverse(string word)
    {
      Console.WriteLine("Reversing " + word);
        StringBuilder sb = new();
        for (int i = word.Length - 1; i >= 0; i--)
        {
            sb.Append(word[i]);
        }
        Console.WriteLine(sb.ToString());
        return sb.ToString();
    }
}