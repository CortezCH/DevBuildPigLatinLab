using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigLatin
{
    class PigLatin
    {

        public bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };


            //return c.ToString() == vowels.ToString();
            //Changed it to check and see if any of the vowels are what we passed in.
            return vowels.Contains(c);
        }

        public bool IsSpecialChar(string word)
        {
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            word = word.ToLower();
            //foreach (char c in specialChars)
            //{
            //    foreach (char w in word)
            //    {
            //        if (w == c)
            //        {
            //            Console.WriteLine("That word has special characters, we will return that section as is");
            //            return true;
            //        }
            //    }
            //}


            //changed this to be more concise. No need for two for loops due to .Contains()
            foreach(char w in word)
            {
                if (specialChars.Contains(w))
                {
                    return true;
                }
            }

            return false;

        }

        public bool StringHasVowels(string word)
        {
            foreach (char letter in word)
            {
                if (IsVowel(letter))
                {
                    return true;
                }
            }
            return false;
        }

        public string ToPigLatin(string word)
        {


            if (IsSpecialChar(word))
            {
                return word;
            }
            else if (!StringHasVowels(word))
            {
                return word;
            }

            char firstLetter = word[0];
            string output = "placeholder";
            if (IsVowel(firstLetter) == true)
            {
                //added a missing w to this seciton so that words with first letter vowel get correct suffix
                output = word + "way";
            }
            else
            {
                int vowelIndex = -1;
                //Handle going through all the consonants
                for (int i = 0; i <= word.Length; i++)
                {
                    if (IsVowel(word[i]) == true)
                    {
                        vowelIndex = i;
                        break;
                    }
                }


                //fixed these two indexes so that we can see if it's working correctly
                string sub = word.Substring(vowelIndex);
                string postFix = word.Substring(0, vowelIndex);

                output = sub + postFix + "ay";
            }

            return output;
        }
    }
}
