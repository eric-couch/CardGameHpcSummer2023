using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ClassExampleHpcSummer2023;

public class Card
{
    public string suit { get; set; }
    public string rank { get; set; }
    public int val { get; set; }

    /// <summary>
    /// This is a card class for creating playing cards (games)
    /// </summary>
    /// <param name="_suit">spades, hearts, clubs, diamonds</param>
    /// <param name="_rank">2, 3, 4, 5... 10, J, Q, K, A</param>
    /// <param name="_val">2, 3, 4, 5... 10, 11, 12, 13, 14</param>
    public Card(string _suit, string _rank, int _val)
    {
        suit = _suit;
        rank = _rank;
        val = _val;
    }

    public override string? ToString()
    {
        return $"{rank}{suit}";
    }

    public void Shuffle()
    {
        // code to shuffle the deck of cards
    }
}
