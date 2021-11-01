using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    PigLatin pigLatin = new PigLatin();
        //    string userInput = GetInput("Please input a word or sentence to translate to pig Latin");
        //    //Added this section to split  the string if it's multiple words so that the special characters clauuse doesn't automatically kick them out
        //    string[] splitApart = userInput.Split(' ');
        //    string translation = string.Empty;

        //    foreach(string word in splitApart)
        //    {
        //        translation += pigLatin.ToPigLatin(word) + " ";
        //    }

        //    Console.WriteLine(translation);
        //}

        //public static string GetInput(string prompt)
        //{
        //    Console.WriteLine(prompt);
        //    string input = Console.ReadLine().ToLower().Trim();
        //    return input;
        //}
    }
}
