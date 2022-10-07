public class Score
{
    public bool userInputCorrect = true;
    public int score = 300;

    public int scoreUpdate(bool userInputCorrect, int score)
    {
        if (userInputCorrect == true)
        {
            score += 100;
        }
        else if (userInputCorrect == false)
        {
            score -= 75;
        }
        return score;
    }

    public void cardNum(bool userInputCorrect, int score)
    {
        List<int> cards = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

        Random rnd = new Random();
        int randIndex = rnd.Next(cards.Count);
        int random = cards[randIndex];

        Console.WriteLine(random);
    }
}

