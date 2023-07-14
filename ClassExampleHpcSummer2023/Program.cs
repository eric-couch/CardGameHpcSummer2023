namespace ClassExampleHpcSummer2023;

internal class Program
{
    static void Main(string[] args)
    {
        Deck myCards = new Deck();

        //myCards.Cards
        foreach (Card thisCard in myCards.Cards)
        {
            Console.Write($"{thisCard.ToString()} ");
        }
    }
}