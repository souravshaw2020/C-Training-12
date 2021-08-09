using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Frequency
    {
        public static void Main(string[] args)
        {
            string sentence, word;
            int count = 0, i = 0;
            string[] stopwords = { "above", "across", "after", "against", "along",
            "among", "around", "at", "before", "behind", "below", "beneath", "beside",
            "between", "by", "down", "during", "for", "from", "in",
            "inside", "into", "near", "of", "off", "on", "onto", "outside",
            "over", "through", "till", "to", "towards", "under", "underneath",
            "until", "up", "a", "an", "the","`", "~", "!", "@", "#", "$", "%",
            "^", "&", "*", "/", "-", "_", "+", "=", ";"};
            Console.Write("Enter the Sentence : ");
            sentence = Console.ReadLine();
            Console.Write("Enter a Word : ");
            word = Console.ReadLine();
            if (stopwords.Contains(word))
            {
                Console.WriteLine("Not Applicable");
            }
            else
            {
                while ((i = sentence.IndexOf(word, i)) != -1)
                {
                    i = i + word.Length;
                    count++;
                }
                Console.WriteLine(word + " - " + count);
            }
            Console.ReadKey();
        }
    }
}