using Xunit;

public class GuessTheNumberTests
{
    [Fact]
    public void Guess_LowerThanSecret_ReturnsHigherHint()
    {
        var game = new NumberGuessGame(50);  // Загадане число 50
        string result = game.Guess(30);
        Assert.Equal("Загадане число більше.", result);
    }

    [Fact]
    public void Guess_HigherThanSecret_ReturnsLowerHint()
    {
        var game = new NumberGuessGame(50);
        string result = game.Guess(70);
        Assert.Equal("Загадане число менше.", result);
    }

    [Fact]
    public void Guess_CorrectNumber_ReturnsWinningMessage()
    {
        var game = new NumberGuessGame(50);
        string result = game.Guess(50);
        Assert.Contains("Вітаю! Ви вгадали число", result);
    }

    [Fact]
    public void GetAttempts_AfterThreeGuesses_ReturnsThree()
    {
        var game = new NumberGuessGame(50);
        game.Guess(30);
        game.Guess(40);
        game.Guess(50);
        Assert.Equal(3, game.GetAttempts());
    }
}
