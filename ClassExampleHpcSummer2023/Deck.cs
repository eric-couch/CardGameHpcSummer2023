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

    // method to test for full house
    // a pair and a three of a kind
    public static bool HasFullHouse(List<Card> cards)
    {
        return HasPair(cards) && HasThreeOfAKind(cards);
    }

    // method to test for flush
    public static bool IsFlush(List<Card> cards)
    {
        return cards.GroupBy(c => c.suit).Any(g => g.Count() == 5);
    }

    //method to test for straight
    public static bool IsStraight(List<Card> cards)
    {
        if (cards.Count != 5)
        {
            throw new ArgumentException("Hand must contain 5 cards.");
        }

        var sortedHand = cards.OrderBy(c => c.val).Select(c => c.val).ToList();
        for (int cardIndex = 0; cardIndex < sortedHand.Count; cardIndex++)
        {
            if (sortedHand[cardIndex+1] - sortedHand[cardIndex] != 1)
            {
                return false;
            }
        }
        return true;
    }

    // method to test for straight flush
    public static bool IsStraightFlush(List<Card> cards)
    {
        return IsFlush(cards) && IsStraight(cards);
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
