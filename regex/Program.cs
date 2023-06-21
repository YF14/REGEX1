using System.Linq;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp9;

public static class StringMinapulation
{
    //Q1

    public static bool IsHex(string hex)
    {
        if (hex.StartsWith("#"))
        {
            if (hex.Length == 7)
            {
                hex = hex.Substring(1);
                if (Regex.IsMatch(hex, @"^[a-zA-Z0-9]+$"))
                {

                    return true;
                }
            }

        }
        return false;
    }
    //Q2
    static double AverageSentenceLenght(string input)
    {
        int lettersLenght = (Regex.Replace(input, @"[^A-Za-z]", "").Length);

        int countWords = Regex.Split(input, @"\W+")
               .Count(x => !string.IsNullOrWhiteSpace(x));

        return Math.Round((double)lettersLenght / countWords, 2);
    }

    //Q4
    public static bool IsPasswordValid(string text)
    {
       return text.Length >= 7 && text.Length <= 16 &&
       Regex.IsMatch(text, "[A-Z]") &&
       Regex.IsMatch(text, "[a-z]") &&
        Regex.IsMatch(text, @"\d") &&
        Regex.IsMatch(text, @"[!-/:-@[-{-~]") &&
       !Regex.IsMatch(text, @"[^\dA-Za-z!-/:-@[-{-~]");

    }
 
    
       




//Q6
public static int OccurrencesRepeatedInSentence(string sentence)
    {

        string[] words = Regex.Split(sentence, @"\W+");
        
        var count = words.GroupBy(x => x).Count(x => x.Count() > 1);
    
        return count;
    }

    //Q7
    public static bool IsVaildCurrency(string currency)
    {

        return Regex.IsMatch(currency, @"^[\d,\d]+[\p{Sc}]");

    }
    //Q8
    public static string StripWord(string word)
    {
        return Regex.Replace(word, @"[^A-Za-z]", "");
    }
    //Q9
    public static string FindWord(string sentence)
    {
        return Regex.IsMatch(sentence, "[C#]+") ? "C# document found." : "Sorry no C# document!";
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IsPasswordValid("Suuu$21g@"));
    }
}