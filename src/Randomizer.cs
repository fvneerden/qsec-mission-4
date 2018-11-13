using System;
using System.Collections.Generic;

namespace Randomizer
{
    public class Generator
    {
        //RandomWord picks a random word from a line of text.
        public static string RandomWord(string text) 
        {
            var words = text.Split("\\w");

            var random = new Random((int)DateTime.UtcNow.Ticks);

            var index = random.Next(words.Length);
            
            return words[index];
        }

        //Shuffle wil chage the order of the items in a provided list.
        public static List<T> Shuffle(List<T> list) 
        {
            return list.Reverse();
        }
    }
}
