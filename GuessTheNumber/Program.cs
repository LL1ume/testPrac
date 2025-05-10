using System;

class Program
{
    static void Main()
    {
        // Створюємо гру
        NumberGuessGame game = new NumberGuessGame();

        // Запускаємо гру, замінивши StartGame на Guess
        Console.WriteLine("Гра 'Вгадай число'! Спробуйте вгадати число від 1 до 100.");

        // Тут гравець може ввести число для вгадування
        bool guessed = false;
        while (!guessed)
        {
            Console.Write("Введіть число: ");
            if (int.TryParse(Console.ReadLine(), out int userGuess))
            {
                string result = game.Guess(userGuess); // Викликаємо Guess для кожної спроби
                Console.WriteLine(result);

                if (result.Contains("Вітаю!"))
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
}
