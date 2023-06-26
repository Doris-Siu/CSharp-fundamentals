using System;
namespace CSharp_fundamentals
{
	public class StringUtility
	{
        // declare a re-usable function : SummarizeText()
        public static string SummarizeText(string sentence, int maxLength = 20)
        {
            if (sentence.Length < maxLength)
                return sentence;
            else
            {
                var wordsArr = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in wordsArr)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;

                }

                return String.Join(' ', summaryWords) + "...";
            }

        }
    }
}

