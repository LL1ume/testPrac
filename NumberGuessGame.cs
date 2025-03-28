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

    // Конструктор для тестів (з фіксованим числом)
    public NumberGuessGame(int fixedNumber)
    {
        secretNumber = fixedNumber;
        attempts = 0;
    }

    // Метод для початку гри
    public void StartGame()
    {
        bool guessed = false;
        Console.WriteLine("Гра 'Вгадай число'! Спробуйте вгадати число від 1 до 100.");

        while (!guessed)
        {
            Console.Write("Введіть число: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int userGuess))
            {
                Console.WriteLine(Guess(userGuess));
                if (userGuess == secretNumber)
                {
                    guessed = true;
                }
            }
            else
            {
                Console.WriteLine("Будь ласка, введіть коректне число.");
            }
        }
    }

    // Метод для перевірки числа
    public string Guess(int userGuess)
    {
        attempts++;
        if (userGuess < secretNumber)
        {
            return "Загадане число більше.";
        }
        else if (userGuess > secretNumber)
        {
            return "Загадане число менше.";
        }
        else
        {
            return $"Вітаю! Ви вгадали число {secretNumber} за {attempts} спроб.";
        }
    }

    // Метод для отримання кількості спроб
    public int GetAttempts()
    {
        return attempts;
    }
}
