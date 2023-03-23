using System;

namespace OppgavePurePuzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            //OppgaveEn();
            //OppgaveTo();
            // OppgaveTre();
            OppgaveFire();
        }
        
        static void OppgaveEn()
        {
            /*
                 ########
                  ######
                   ####
                    ##
             */
            for (int row = 0; row <= 3; row++)
            {
               // Spaces
               for (int i = 0; i < row; i++) Console.Write(" ");
               // Hashes
               for (int i = 0; i < 8 - (row * 2); i++) Console.Write("#");
               
               Console.WriteLine();
            }
        }
        static void OppgaveTo()
        {
            /*
                  ##
                 ####
                ######
               ########
               ########
                ######
                 ####
                  ##
            */
            
            // Top half
            for (int row = 0; row < 4; row++)
            {
                // Spaces
                int amountOfSpacesTop = 3 - row;
                for (int i = 0; i < amountOfSpacesTop; i++)
                {
                    Console.Write(" ");
                }
                // Hashes
                int amountOfHashesTop = 2 + (row * 2);
                for (int i = 0; i < amountOfHashesTop; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            // Lower half
            for (int row = 0; row < 4; row++)
            {
                // Spaces
                for (int i = 0; i < row; i++)
                {
                    Console.Write(" ");
                }
                // Hashes
                int amountOfHashesBottom = 8 - (row * 2);
                for (int i = 0; i < amountOfHashesBottom; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        /*
             #            #
              ##        ##
               ###    ###
                ########
                ########
               ###    ###
              ##        ##
             #            # 
         */
        static void OppgaveTre()
        {
            // spaces 0,1,2,3
            // spaces 12,8,4
            int[] hashPattern = { 0, 1, 2, 3, 3, 2, 1, 0 };
                
            // Rows
            for (int row = 0; row < hashPattern.Length; row++)
            {
                // First set of spaces
               for (int i = 0; i < hashPattern[row]; i++)
               {
                   Console.Write(" ");
               }
               // First set of hashes
               for (int i = 0; i < hashPattern[row] + 1; i++)
               {
                   Console.Write("#");
               }
               // Second set of spaces
               for (int i = 0; i < 12 - (hashPattern[row] * 4); i++)
               {
                   Console.Write(" ");
               }
               // Second set of hashes
               for (int i = 0; i < hashPattern[row] + 1; i++)
               {
                   Console.Write("#");
               }
               Console.WriteLine();
            }
        }
        static void OppgaveFire()
        {
            Console.Write("Enter a word: ");
            var userInput = Console.ReadLine() + " ";

            int numberOfWords = 0;
            int lengthOfLongestWord = 0;
            int greatestNumberOfVowelsInAWord = 0;
            
            foreach (var c in userInput)
            {
                int currentWordLength = 0;
                int currentVowels = 0;
                
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') currentVowels++;
                else if (c != ' ') currentWordLength++;
                else
                {
                    numberOfWords++;
                }
                lengthOfLongestWord = lengthOfLongestWord > currentWordLength ? lengthOfLongestWord : currentWordLength;
                greatestNumberOfVowelsInAWord = greatestNumberOfVowelsInAWord > currentVowels ? greatestNumberOfVowelsInAWord : currentVowels;
            }
            Console.WriteLine($"Number of words: {numberOfWords}");
            Console.WriteLine($"Length of longest word: {lengthOfLongestWord}");
            Console.WriteLine($"Greatest number of vowels in a word: {greatestNumberOfVowelsInAWord}");
        }
    }
}