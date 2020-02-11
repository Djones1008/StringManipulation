using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringManipulation
{
   class Program
   {
      static void Main(string[] args)
      {
         string sentence = "The quick brown fox jumped over the lazy dog";
         string convertedSentence = "";

         Console.WriteLine(sentence);

         Console.WriteLine(sentence.ToLower());
         Console.WriteLine(sentence.ToUpper());

         Console.WriteLine($"Character count: {sentence.Length}");
         Console.WriteLine($"Does the sentence contain the word 'fox'? {sentence.Contains("fox")}");


         Console.WriteLine($"Index of 'q': {sentence.IndexOf("q")}");

         Console.WriteLine($"Extract the word 'fox': {sentence.Substring(sentence.IndexOf('f'), 3)}");
      }
   }
}
