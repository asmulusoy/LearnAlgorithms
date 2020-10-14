using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithms
{
    public static class PalindromicWords
    {
        public static List<string> GetPalindromicWords(string input)
        {
            List<string> words = new List<string>();
            for (int i = 2; i < input.Length; i++)
            {
                string palindromicWord = string.Empty;
                for (int j = 1; 0 < 1; j++)
                {
                    if (i - j > 0 && i + j < input.Length)
                    {
                        if (input[i - j] != input[i + j])
                        {
                            if (!string.IsNullOrEmpty(palindromicWord))
                                words.Add(palindromicWord);
                            break;
                        }
                        else
                        {
                            palindromicWord = input.Substring(i - j, (j * 2) + 1);
                        }
                    }
                    else
                    {
                        break;
                    }

                }
            }
            return words.OrderByDescending(x => x.Length).ToList();
        }

    }
}
