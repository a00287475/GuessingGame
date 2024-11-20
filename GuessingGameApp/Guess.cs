using System;

public class Guess
{
    // Read-only property for the user's guess
    public int UserGuess { get; }

    // Read-only property for the time of the guess
    public DateTime GuessTime { get; }

    // Constructor to initialize the guess and set the time
    public Guess(int userGuess)
    {
        UserGuess = userGuess;
        GuessTime = DateTime.Now;
    }
}
