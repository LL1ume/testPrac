using System;

public class NumberGuessGame
{
    private readonly int secretNumber;
    private int attempts;

    // Конструктор гри, задає секретне число
    public NumberGuessGame()
    {
        Random random = new Random();
        secretNumber = random.Next(1, 101);
        attempts = 0;
    }

    // Метод для початку гри
    public string Guess(int userGuess)
    {
        attempts++;
        if (userGuess < secretNumber)
            return "Загадане число більше.";
        if (userGuess > secretNumber)
            return "Загадане число менше.";
        return $"Вітаю! Ви вгадали число {secretNumber} за {attempts} спроб.";
    }

    // Метод для отримання кількості спроб
    public int GetAttempts()
    {
        return attempts;
    }
}
