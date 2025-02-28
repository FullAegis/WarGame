using System.Drawing;
using Pastel; // For string color using ANSI codes (https://github.com/silkfire/Pastel)

namespace WarGame;
public enum Suit {
  Clubs = '♣',
  Diamonds = '♦',
  Hearts = '♥',
  Spades = '♠',
};

public enum Rank {
  Two = 2,
  Three = 3,
  Four = 4,
  Five = 5,
  Six = 6,
  Seven = 7,
  Eight = 8,
  Nine = 9,
  Jack = 10,
  Queen = 11,
  King = 12,
  Ace = 13,
};

public class Card(Suit suit, Rank rank) {
  public Suit suit { get; set; } = suit;
  public Rank rank { get; set; } = rank;
  
  public override string ToString() {
    var symbol = rank switch {
      Rank.Jack  => "J",
      Rank.Queen => "Q",
      Rank.King  => "K",
      Rank.Ace   => "A",
      _ => ((int)rank).ToString()
    };
    
    return $"{symbol}{(char)suit}"
      .PastelBg(Color.White)
      .Pastel(suit switch { Suit.Diamonds or Suit.Hearts => Color.Red, _ => Color.Black })
      ;
  }
}