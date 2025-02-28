using NUnit.Framework;
using WarGame;

namespace WarGame.tst;
[TestFixture]
public class DeckTest {
  [Test]
  public void EmptyDeck() {
    var deck = new Deck();
    _ = deck.Deal(count: 52);
    Assert.That(deck.Empty, Is.True);
  }
  
  [Test]
  public void Deck_Deal_RemovesCardFromDeck() {
    Deck deck = new Deck();
    var dealtCards = deck.Deal(1);
    Assert.That(dealtCards, Is.Not.Empty);
    Assert.That(dealtCards.Count, Is.EqualTo(1));
    Assert.That(deck.Length, Is.EqualTo(51));
  }
}