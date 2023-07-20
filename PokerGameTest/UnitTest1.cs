using ClassExampleHpcSummer2023;

namespace PokerGameTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestCardHandForAce_True()
        {
            // Arrange
            List<Card> Hand = new List<Card>()
            {
                new Card("♣", "A", 14),
                new Card("♠", "5", 5),
                new Card("♣", "6", 6),
                new Card("♣", "7", 7),
                new Card("♦", "8", 8)
            };
            // Act
            bool aceInHand = Deck.CheckForAce(Hand);

            // Assert
            Assert.IsTrue(aceInHand);
        }

        [Test]
        public void TestCardHandForAce_False()
        {
            // Arrange
            List<Card> Hand = new List<Card>()
            {
                new Card("♣", "2", 2),
                new Card("♠", "5", 5),
                new Card("♣", "6", 6),
                new Card("♣", "7", 7),
                new Card("♦", "8", 8)
            };
            // Act
            bool aceInHand = Deck.CheckForAce(Hand);

            // Assert
            Assert.IsFalse(aceInHand);
        }

        [Test]
        public void TestCardHandForPair_True()
        {
            // Arrange
            List<Card> Hand = new List<Card>()
            {
                new Card("♣", "2", 2),
                new Card("♠", "5", 5),
                new Card("♣", "5", 5),
                new Card("♣", "7", 7),
                new Card("♦", "8", 8)
            };
            // Act
            bool hasPairInHand = Deck.HasPair(Hand);

            // Assert 
            Assert.IsTrue(hasPairInHand);
        }

        [Test]
        public void TestCardHandForPair_False()
        {
            // Arrange
            List<Card> Hand = new List<Card>()
            {
                new Card("♣", "2", 2),
                new Card("♠", "5", 5),
                new Card("♣", "9", 9),
                new Card("♣", "7", 7),
                new Card("♦", "8", 8)
            };
            // Act
            bool hasPairInHand = Deck.HasPair(Hand);

            // Assert 
            Assert.IsFalse(hasPairInHand);
        }
    }
}