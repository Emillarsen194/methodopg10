using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg10
{
    class Logic
    {
        public static int MakeRandomNumber() //returns a random number between 1 and 1000
        {
            Random rng = new Random();
            int secretNumber = rng.Next(1, 1000);

            return secretNumber;
        }

        public static string GuessTheNumber(int makeAGuess, int secretnumber)
        {
            
            string tmp = ""; //tmp string

            if (makeAGuess < secretnumber) // if number is lower than the random number 
            {
                return "tallet skal være højre";
            }

            else if (makeAGuess > secretnumber) // if guess is higher then say guess should be lower 
            {
                return "tallet skal være lavere";
            }

            else if (makeAGuess == secretnumber)
            {
                
                
                return "tilykke du gættede tallet, tallet var: " + secretnumber;
               
            }

            return tmp;

        }
           
           
            

        public static bool Isgameover (int guess, int secretNumber, bool gameOver) //checks if game is over 
        {
            
               if (guess == secretNumber)
            {
                gameOver = true;
            }
            return gameOver;
            
        }
            
            

          

            

        public static int GuessingTries(int tries) // Count tries 
        {
                tries++;

            return tries;
        }
      
         
    }
}
