using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determine_Word_Occurrences_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Below are actual data thats given in asiignmnet two "Determine Word Occurrences in a String"
            string[] myWords = { "My", "NEW", "Test", "Fix", "cup", "Car" };
            string longString =@"jsdfkfjslffTESTrtyty4my73589347yeqw672345[l;fxnnadfsleqwrewurmyydsfTesthcverTetswewyrklsdg9i
                               erhdsfixjhfewycupriuewyqodhfsooiemywryuhdflyaewirhdfliuycupehivjlfixyeocnFIXyiernewpanvlhdtwu
                               terga[] dsfu96456834256new896jksdnvgFixaesi0erw0car - eryn7h467newhn6mn78k89m,9 < (< 0.<
                               ht6";
            // convert in lowercase without using buld in function
            string longString_lowerCase = converInlowerCase(longString);
           
            //Count occurrences of each word from the long string
            foreach (string word in myWords)
            {
                
                string[] result = longString_lowerCase.Split(new string[] { converInlowerCase(word) }, StringSplitOptions.None);
                int count = result.Length - 1;
                Console.WriteLine($"The word '{word}' occurred {count} times.");
            }

            Console.ReadLine();
        }
        // Function to convert to lowercase without using built-in functions.
        static string converInlowerCase(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    chars[i] = (char)(chars[i] + 32); // Adding 32 to its ASCII value for converting lowercase
                }
            }
            return new string(chars);
        }


    }
}
