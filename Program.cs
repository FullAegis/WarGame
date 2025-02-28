using System;
using WarGame;

public class App {
  public static void Main() {
    var card = new Card(Suit.Hearts, Rank.Ace);
    Console.WriteLine(card);
  }
}
