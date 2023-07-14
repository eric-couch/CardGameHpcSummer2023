namespace ClassExampleHpcSummer2023;

internal class Program
{
    static void Main(string[] args)
    {
        Deck myCards = new Deck();
        
        foreach (Card thisCard in myCards.DealCards(5) )
        {
            Console.Write($"{thisCard.ToString()}\t");
        }

        //foreach (Card thisCard in myCards.Cards)
        //{
        //    Console.Write($"{thisCard.ToString()} ");
        //}
    }
}