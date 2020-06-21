using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CardSuit {
  Spades,
  Diamonds,
  Clubs,
  Hearts,
}

public struct Card {
  public int Rank {
    // 0 is Joker, 1 is Ace, 11 is Jack, 12 is Queen, 13 is King
    get;
  }

  public CardSuit Suit { get; }

  public Card(int rank, CardSuit suit) {
    if (rank < 0 || rank > 13) {
      this.Rank = 0;
    } else {
      this.Rank = rank;
    }
    this.Suit = suit;
  }
}
