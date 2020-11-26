using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of video game names.
            //Order the list of games by length of the game name.

            List<string> GameNames = new List<string>
            {"Black Flag", "Brotherhood", "Odyssey", "Rogue", "Valhalla"};

            var Game = from element in GameNames
                       orderby element.Length
                       select element;
            foreach (string str in Game)
            {
                Console.WriteLine(str);
            }
        }
    }
}
