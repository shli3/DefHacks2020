using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CardSuit {
  Spades,
  Diamonds,
  Clubs,
  Hearts
}

public class Card {
  private int rank;
  public int Rank {
    // 0 is Joker, 1 is Ace, 11 is Jack, 12 is Queen, 13 is King
    get => this.rank;
    private set {
      if (value < 0 || value > 13) {
        this.rank = 0;
      } else {
        this.rank = value;
      }
    }
  }

  public CardSuit Suit { get; private set; }

  public Card(int rank, CardSuit suit) {
    this.Rank = rank;
    this.Suit = suit;
  }
}
