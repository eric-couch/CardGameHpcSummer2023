namespace ClassExampleHpcSummer2023;

internal class Program
{
    static void Main(string[] args)
    {
        Deck myCards = new Deck();

        List<Card> Hand = new List<Card>();

        foreach (Card thisCard in myCards.DealCards(5) )
        {
            Hand.Add(thisCard);
            Console.Write($"{thisCard.ToString()}\t");
        }
        Console.WriteLine($"Does this hand have an Ace? {Deck.CheckForAce(Hand)}");

    }
}