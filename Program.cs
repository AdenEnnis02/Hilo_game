using Hilo_game;

namespace Hilo_game
{
    class Hilo
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            // deck.PrintCardsInDeck();
            while (deck.HasMoreCards())
            {
                Card randomCard = deck.DrawRandomCard();
                Console.WriteLine($"The card is {randomCard.Description()}");
                ConsoleKeyInfo keyInfo;
                do
                {
                    Console.WriteLine("Will the next card be higher or lower? h/l: ");
                    keyInfo = Console.ReadKey();
                    if(keyInfo.Key != ConsoleKey.H && keyInfo.Key != ConsoleKey.L){
                        Console.WriteLine($"\nPlease input an h or an l!");
                    }
                } while (keyInfo.Key != ConsoleKey.H && keyInfo.Key != ConsoleKey.L);
                if(keyInfo.Key == ConsoleKey.H){

                }
                
            }
        }
    }

    public class Card
    {
        public string suit;
        public int number;
        public Card(string suit, int number)
        {
            this.suit = suit;
            this.number = number;
        }

        // Returns a description of the card based on its suit and number
        public string Description()
        {
            string nameOfCard = number.ToString();
            if (number == 1)
            {
                nameOfCard = "Ace";
            }
            else if (number == 11)
            {
                nameOfCard = "Jack";
            }
            else if (number == 12)
            {
                nameOfCard = "Queen";
            }
            else if (number == 13)
            {
                nameOfCard = "King";
            }

            return $"{nameOfCard} of {suit}s";
        }
    }

    public class Deck
    {

        // The 4 different valid suits in a 52 deck of cards
        private List<string> suits = new List<string> { "heart", "diamond", "spade", "club" };

        private int cardCountPerSuit = 13;

        // Used for getting random cards from the deck
        private Random generator = new Random();

        private List<Card> Cards = new List<Card>();

        public Deck()
        {
            BuildDeck();
        }

        private void BuildDeck()
        {
            // Do not build the cards if there are already cards in the deck
            if (Cards.Count != 0)
            {
                return;
            }

            // This loop creates 13 cards for each suit, which will result in 52 total cards
            foreach (var suit in suits)
            {
                for (int number = 1; number <= cardCountPerSuit; number++)
                {
                    Card card = new Card(suit, number);
                    Cards.Add(card);
                }
            }
        }

        // Draws a random card and removes it from the deck
        public Card DrawRandomCard()
        {
            int randomIndex = generator.Next(Cards.Count);
            Card randomCard = Cards[randomIndex];
            Cards.RemoveAt(randomIndex);
            return randomCard;
        }

        public bool HasMoreCards()
        {
            return Cards.Count > 0;
        }

        public void PrintCardsInDeck()
        {
            foreach (var card in Cards)
            {
                Console.WriteLine(card.Description());
            }

            Console.WriteLine($"Cards in deck {Cards.Count}");
        }
    }
}