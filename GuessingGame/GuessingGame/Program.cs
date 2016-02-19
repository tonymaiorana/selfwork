using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)

        {
            //Gets the Player's name
            Console.Write("Please Enter your Name: ");
            string name = Console.ReadLine();

            bool keepPlaying = false;
            do
            {
                //creates a GamePlay Object
                GamePlay game = new GamePlay();
               keepPlaying = game.PlayRound(name);
            } while (keepPlaying);

        }
    }
}