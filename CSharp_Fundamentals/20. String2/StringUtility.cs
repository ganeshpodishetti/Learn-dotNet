using System;
using System.Collections.Generic;
using System.Text;

namespace String2
{
    public class StringUtility
    {
        public static string summaryText(string sentence)
        {
            const int maxLength = 20;

            if (sentence.Length < maxLength)
                return sentence;
            else
            {
                var words = sentence.Split(' ');
                var totalChar = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalChar += word.Length + 1;
                    if (totalChar > maxLength)
                        break;
                }
                return (String.Join(" ", summaryWords) + "...");
            }
        }
    }
}
