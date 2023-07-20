using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExampleHpcSummer2023;

public class Deck
{
    public List<Card> Cards { get; set; } = new List<Card>();

    public Deck()
    {
        Initialize();
    }

    public void Reset()
    {
        Cards.Clear();
        Initialize();
    }

    public List<Card> DealCards(int numOfCards)
    {
        List<Card> Hand = new List<Card>();
        Random rnd = new Random();
        for (int i = 0; i < numOfCards; i++)
        {
            int cardToDeal = rnd.Next(Cards.Count);
            Hand.Add(Cards[cardToDeal]);
            Cards.RemoveAt(cardToDeal);
        }
        return Hand;
    }

    public static bool CheckForAce(List<Card> cards)
    {
        return cards.Any(c => c.rank == "A");
    }

    public static bool HasPair(List<Card> cards)
    {
        var cardGroups = from c in cards
                         group c by c.rank into g
                         select new { rank = g.Key, count = g.Count() };

        return cardGroups.Any(c => c.count == 2);
    }

    public static bool HasThreeOfAKind(List<Card> cards)
    {
        var cardGroups = from c in cards
                         group c by c.rank into g
                         select new { rank = g.Key, count = g.Count() };

        return cardGroups.Any(c => c.count == 3);
    }

    public void Initialize()
    {
        List<string> suits = new List<string>() { "♠", "♦", "♣", "♥" };
        List<string> ranks = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        List<int> values = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                Card newCard = new Card(suit, rank, values[ranks.IndexOf(rank)]);
                Cards.Add(newCard);
            }
        }

    }
}
