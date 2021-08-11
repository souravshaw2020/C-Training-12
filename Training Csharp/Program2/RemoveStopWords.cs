using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class RemoveStopWords
    {
        public static void Main(string[] args)
        {
            string sentence;
            string[] stopwords = { "above", "across", "after", "against", "along",
            "among", "around", "at", "before", "behind", "below", "beneath", "beside",
            "between", "by", "down", "during", "for", "from", "in",
            "inside", "into", "near", "of", "off", "on", "onto", "outside",
            "over", "through", "till", "to", "towards", "under", "underneath",
            "until", "up", "a", "an", "the"};
            string[] symbols = {"`", "~", "!", "@", "#", "$", "%",
            "^", "&", "*", "/", "-", "_", "+", "=", ";", ".", "?"};
            Console.Write("Enter a Sentence : ");
            sentence = Console.ReadLine();
            string new_sentence = "";
            foreach (string str in symbols)
            {
                if (sentence.Contains(str))
                {
                    sentence = sentence.Replace(str, "");
                }
            }
            foreach (string word in sentence.Split(' '))
            {
                int count = 0;
                foreach (string str in stopwords)
                {
                    if (word == str)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    new_sentence += word + " ";
                }
            }

            foreach (string word in new_sentence.Split(' '))
            {
                if (word != "")
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadKey();
        }
    }
}