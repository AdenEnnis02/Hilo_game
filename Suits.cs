{
class PrintCardSuitSymbls
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Club -> \u2663");
            Console.WriteLine("Spades -> \u2660");
            Console.WriteLine("Diamond -> \u2666");
            Console.WriteLine("Heart -> \u2665");

            Console.ReadKey();
        }
    }
} 