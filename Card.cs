public class Card
{
    public static void carNum()
    {
        List<int> cards = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
 
        Random rnd = new Random();
        int randIndex = rnd.Next(cards.Count);
        int random = cards[randIndex];
 
        Console.WriteLine(random);
    }
}