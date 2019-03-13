using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NLP
{
    class Program
    {
        static string WHQustion;
        static void Main(string[] args)
        {
            string[] WHQustions = new string[] { "what", "how", "where", "why", "when" };
            string[] VToBs = new string[] { "is", "are", "you", "we", "our", "i", "they", "\'s", "your" };
            string inpot;
            List<string> CurrevtVToBs = new List<string>();
            Console.WriteLine("Please enter your Qustion");
            List<string> KeyWords = new List<string>();
            inpot = Console.ReadLine().ToLower();

            for (int i = 0; i < WHQustions.Length; i++)
            {
                if(inpot.Contains(WHQustions[i]))
                {
                    WHQustion = WHQustions[i];
                    break;
                }
            }
            for (int i = 0; i < VToBs.Length; i++)
            {
                if (inpot.Contains(VToBs[i]))
                {
                    CurrevtVToBs.Add(VToBs[i]);
                }
            }
            KeyWords = new List<string>(inpot.Split());
            for (int i = 0; i < KeyWords.Count; i++)
            {
                if (KeyWords[i] == WHQustion)
                KeyWords.Remove(WHQustion);
                foreach (var VToB in CurrevtVToBs)
                {
                    
                    if (KeyWords[i] == VToB)
                        KeyWords.Remove(VToB);
                }
                
            }
            Console.WriteLine("WHQustions: " + WHQustion);
            Console.WriteLine("keywords: ");
            foreach (var Keyword in KeyWords)
            {
                Console.WriteLine(Keyword);
            }
            Console.Read();
        }
    }
}
