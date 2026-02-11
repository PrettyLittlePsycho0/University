using System;
using System.Collections.Generic;

namespace ShiritoriApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shiritori my_shiritori = new Shiritori();

            Console.WriteLine(my_shiritori.Play("apple"));
            Console.WriteLine(my_shiritori.Play("ear"));
            Console.WriteLine(my_shiritori.Play("rhino"));
            Console.WriteLine(my_shiritori.Play("corn"));

            PrintWords(my_shiritori.words);

            Console.WriteLine(my_shiritori.Restart());

            PrintWords(my_shiritori.words);

            Console.WriteLine(my_shiritori.Play("hostess"));
            Console.WriteLine(my_shiritori.Play("stash"));
            Console.WriteLine(my_shiritori.Play("hostess"));
        }

        static void PrintWords(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                Console.Write(words[i] + " ");
            }
            Console.WriteLine();
        }
    }

    class Shiritori
    {
        public List<string> words;
        public bool game_over;

        public Shiritori()
        {
            words = new List<string>();
            game_over = false;
        }

        public string Play(string word)
        {
            if (game_over)
            {
                return "game over";
            }

            if (words.Count > 0)
            {
                string lastWord = words[words.Count - 1];
                char lastChar = lastWord[lastWord.Length - 1];
                char firstChar = word[0];

                if (firstChar != lastChar)
                {
                    game_over = true;
                    return "game over";
                }

                for (int i = 0; i < words.Count; i++)
                {
                    if (words[i] == word)
                    {
                        game_over = true;
                        return "game over";
                    }
                }
            }

            words.Add(word);

            string result = "";
            for (int i = 0; i < words.Count; i++)
            {
                result += words[i];
                if (i < words.Count - 1)
                {
                    result += " ";
                }
            }
            return result;
        }

        public string Restart()
        {
            words = new List<string>();
            game_over = false;
            return "game restarted";
        }
    }
}
