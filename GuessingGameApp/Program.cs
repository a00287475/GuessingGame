using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var randomNumber = new Random().Next(1, 101);  
        var guesses = new List<Guess>(); 

        int userGuess = 0;
        do
        {
            Console.Write("Enter your guess (1-100): ");
            if (!int.TryParse(Console.ReadLine(), out userGuess))

            {
                Console.WriteLine("Error: Please enter a valid number.");
                continue;
            }

            var guess = new Guess(userGuess);  
            guesses.Add(guess);  

            var previousGuess = guesses.FindIndex(g => g.UserGuess == userGuess);
            if (previousGuess != -1 && guesses.Count > 1)
                Console.WriteLine($"You guessed this number {guesses.Count - previousGuess - 1} turns ago!");

            if (userGuess < randomNumber) Console.WriteLine("Too low!");
            else if (userGuess > randomNumber) Console.WriteLine("Too high!");
            else Console.WriteLine($"You Won! The answer was {randomNumber}.");
        }
        while (userGuess != randomNumber);  


       
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey(); 
    }
}
