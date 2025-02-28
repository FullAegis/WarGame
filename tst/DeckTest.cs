using NUnit.Framework;
using WarGame;

namespace WarGame.tst;
[TestFixture]
public class DeckTest {
  [Test]
  public void EmptyDeck() {
    var deck = new Deck();
    _ = deck.Deal(count: 52);
    Assert.That(deck, Is.Empty);
  }
}