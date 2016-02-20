using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class GamePlay
    {
        public bool PlayRound(string name)
        {
            int count = 0;

            //create a Random object
            Random random = new Random();
            
            //determine the number to guess
            int theAnswer = random.Next(1, 21);

            bool isNumberGuessed = false;
            do
            {
                // get the player's guess
                Console.WriteLine("{0}, Please enter your guess: ", name);
                Console.Write("The number is between 1-20 ");
                string playerInput = Console.ReadLine();

                //After Player inputs name anytime "q" is typed game will end and ask to play again
                if (playerInput == "q")
                {
                    break;
                }


                //need to make sure we got a number from the user
                int playerGuess;
                if (int.TryParse(playerInput, out playerGuess))
                {
                    if (theAnswer > playerGuess)
                    {
                        Console.WriteLine("{0}, is too low!", playerGuess);
                    }
                    else if (theAnswer < playerGuess)
                    {
                        Console.WriteLine("{0}, is too high!", playerGuess);
                    }
                    else if (theAnswer == playerGuess)
                    {
                        Console.WriteLine("{0}, YOU GOT IT DUDE!!!", name.ToUpper());
                        isNumberGuessed = true;
                    }

                    count++;

                }
            } while (!isNumberGuessed);



            //Ask user if they want to play again
            bool playAnotherRound = false;

            if (count == 1)
            {
                Console.WriteLine("Are you sure you aren't cheating?  It only took you 1 try!");
            }
            else
            {
                Console.WriteLine("{0}, it took you " + count + " guesses", name);
            }

            Console.Write("{0}, would you like to play again? (y/n): ", name);
            string response = Console.ReadLine();

            if (response.ToUpper() == "Y")
            {
                playAnotherRound = true;
            }

            return playAnotherRound;
        }
    }
}
