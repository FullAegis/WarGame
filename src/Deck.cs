using System;
using System.Data;

namespace WarGame;
public class Deck {
  private Stack<Card> _cards = new();
  public int Length { get => _cards.Count; }
  
  public Deck() {
    foreach (var suit in Enum.GetValues<Suit>()) {
      foreach (var rank in Enum.GetValues<Rank>()) {
        _cards.Push(new(suit, rank));
      }
    }
  }
  
  public Deck(Stack<Card> playerHand) {
    _cards = playerHand;
  }
  
  private static void AssertInRange(int count) {
    if (count < 1 || count > 52) {
      throw new ArgumentOutOfRangeException($"Cannot draw {count} card from a deck of 52.");
    }
  }

  public IEnumerable<Card> Deal(int count = 1) {
    AssertInRange(count);
    var deck = new Stack<Card>();
    while (count-- > 0) {
      deck.Push(_cards.Pop());
    }
    return deck;
  }
  
  public void Shuffle(Int32? seed) {
    var self = _cards.ToArray();
    var r = seed.HasValue ? new Random(seed.Value) : new Random();
    r.Shuffle(self);
    _cards = new(self);
  }
}