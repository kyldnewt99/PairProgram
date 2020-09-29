using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    static class MadLib
    {
        //declare variables
        static String[] prompts = {"place","adjective","adjective","noun","adjective","color","animal","adjective","noun","adjective","verb","adjective","verb","plural" };
        static String [] words = new string[13];
   

        //method to hold rest of code

        

        public static void GetWords()
        {
            //ask player to enter words
            //cycles through the words array
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("Please enter a " + prompts[i]+":");
                words[i] = Console.ReadLine();
            }
        }
        public static void WriteStory()
        {

        }
    }
}
