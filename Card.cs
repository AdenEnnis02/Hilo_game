// public class Card{
//     public int cardNum;
//     public void getANewCard()
//     {
//     Random randomnum = new Random();
//     cardNum = randomnum.Next(1,13);
//     Console.WriteLine(cardNum);
//     }
// }

// public class Card
// {
//     public static void carNum()
//     {
//         List<int> cards = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
 
//         Random rnd = new Random();
//         int randIndex = rnd.Next(cards.Count);
//         int random = cards[randIndex];
 
//         Console.WriteLine(random);
//     }
// }
static void cardNum()
    {
        List<int> cards = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
 
        Random rnd = new Random();
        int randIndex = rnd.Next(cards.Count);
        int random = cards[randIndex];
 
        Console.WriteLine(random);
    }
    cardNum();