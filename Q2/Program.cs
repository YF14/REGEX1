//Q2
using System.Text.RegularExpressions;

static double AverageSentenceLenght(string input)
{
    int lettersLenght = (Regex.Replace(input, @"[^A-Za-z]", "").Length);

    int countWords = Regex.Split(input, @"\W+")
           .Count(x => !string.IsNullOrWhiteSpace(x));

    return Math.Round((double)lettersLenght / countWords, 2);
}