static void scoreUpdate(userInputCorrect, score)
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

static void cardNum()
    {
        List<int> cards = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
 
        Random rnd = new Random();
        int randIndex = rnd.Next(cards.Count);
        int random = cards[randIndex];
 
        Console.WriteLine(random);
    }


Console.WriteLine("Ready to play? [y/n] ");
int score = 300;
char userContinues = Console.ReadLine();
while (userContinues == 'y' && score > 0)
{
    int currentCard = cardNum();
    Console.WriteLine("Higher or lower? [h/l] ");
    char userInput = Console.WriteLine();
    int nextCard = cardNum();
    if ((currentCard > nextCard && userInput == 'l') || (currentCard < nextCard && userInput == 'h'))
    {
        bool userInputCorrect = true;
        scoreUpdate(userInputCorrect, score);
    }
    else if ((currentCard > nextCard && userInput == 'h') || (currentCard < nextCard && userInput == 'l'))
    {
        bool userInputCorrect = false;
        scoreUpdate(userInputCorrect, score);
    }
    Console.WriteLine($" Your score is: {score}");
    Console.WriteLine("Play again? [y/n] ");
    userContinues = Console.ReadLine(); 
}

