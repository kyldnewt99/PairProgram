using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class MadLib
    {
        //declare variables
        static string[] prompts = {"place","adjective","adjective","noun","adjective","color","animal","adjective","noun","adjective","verb","adjective","verb","plural noun" };
        static string [] words = new string[14];

        public static void Run()
        {
            GetWords();
            WriteStory();
            Console.ReadLine();
        }

        

        static void GetWords()
        {
            //ask player to enter words
            //cycles through the words array
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("Enter a/an " + prompts[i]+":");
                words[i] = Console.ReadLine();
            }
        }
        static void WriteStory()
        {
            Console.WriteLine("This year, " + words[0] + " is having a " + words[1] + " Halloween Costume Contest. I hope I win. I'm going to dress up as a " + words[2] + " " + words[3] + ". My best friend is going to be a " + words[4] + " " + words[5] + " " + words[6] + " and my cousin is going to be a " + words[7] + " " + words[8] + ". They're having a " + words[9] +" party and everyone in town shows up to " + words[10] + " all of the " + words[11] + " costumes. We play games, like bobbing for apples and " + words[12] + "ing " + words[13] +" and it is so much fun!");
           
        }
    }
}
