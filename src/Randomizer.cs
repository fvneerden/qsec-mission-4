using System;

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
    }
}
