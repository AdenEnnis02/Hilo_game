static bool Start()
{
bool start = false;
Score score = new Score();
int userScore = score.score;
Console.WriteLine("Ready to play? y/n");
string userContinues = Console.ReadLine()??"";
if (userContinues = "y")
{
    return true;
}
}
public Game() {
        ;
    }

    Card card = new Card();
    int currentCard = card.cardNum();
    Console.WriteLine("Higher or lower? [h/l]: ");
    string userInput = Console.ReadLine()??"";
    int nextCard = card.cardNum();
    if (userInput.Equals "h")
    {
        scoreUpdate(userInputCorrect, score);
    }
    else if ((currentCard > nextCard && userInput == 'h') || (currentCard < nextCard && userInput == 'l'))
    {
        bool userInputCorrect = false;
        scoreUpdate(userInputCorrect, score);
    }
    Console.WriteLine($" Your score is: {score}");
    Console.WriteLine("Play again? [y/n] ");
    userContinues = Console.ReadLine()??""; 

