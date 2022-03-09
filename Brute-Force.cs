using System.Collections.Generic;
using System.Numerics;

namespace Brute_Force
{
    public class Brute_Force
    {
        public List<string> BruteForce(List<string> words)
        {
            List<string> _words = new List<string>();
            _words.Add("");
            foreach (string word in words)
            {
                _words.Add(word);
            }

            int[] index = new int[_words.Count];

            for (int i = 0; i < index.Length; i++)
            {
                index[i] = 0;
            }

            List<string> returnwords = new List<string>();

            while (index[index.Length - 1] < index.Length)
            {
                index[0]++;

                if (index[index.Length - 1] == index.Length)
                {
                    break;
                }

                for (int i = 0; i < index.Length - 1; i++)
                {
                    if (index[i] >= index.Length)
                    {
                        index[i] = 1;
                        index[i + 1]++;
                    }
                }

                string tempword = "";
                for (int i = 1; i < index.Length; i++)
                {
                    tempword += _words[index[i - 1]];
                }
                returnwords.Add(tempword);
            }
            return returnwords;
        }     
    }
}