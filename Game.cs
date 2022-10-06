
class Game{
    int score = 300;

    public bool IsPlaying()
    {
        while (score > 0){
            return true;
        }
        return false;
    }

    public void HiOrLo()
    {
        Console.WriteLine("Higher or lower? [h/l] ");
        string userInput = Console.ReadLine();

    }
}