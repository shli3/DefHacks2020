using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardInHand : MonoBehaviour {
  [SerializeField] private TextMeshProUGUI cardText;

  private Card card;
  public Card Card {
    get => this.card;
    set {
      this.card = value;
      
      string suitString;
      switch (value.Suit) {
        case CardSuit.Spades: 
          suitString = "}";
          break;
        case CardSuit.Clubs: 
          suitString = "]";
          break;
        case CardSuit.Diamonds: 
          suitString = "[";
          break;
        case CardSuit.Hearts: 
          suitString = "{";
          break;
        default:
          suitString = "}";
          break;
      }

      string rankString;
      switch (value.Rank) {
        case 0:
          rankString = "*";
          suitString = "*";
          break;
        case 1:
          rankString = "A";
          break;
        case 10:
          rankString = "X";
          break;
        case 11:
          rankString = "J";
          break;
        case 12:
          rankString = "Q";
          break;
        case 13:
          rankString = "K";
          break;
        default:
          rankString = value.Rank.ToString();
          break;
      }

      this.cardText.text = rankString + "\n" + suitString;
      this.cardText.color = value.Suit == CardSuit.Spades || value.Suit == CardSuit.Clubs ? Color.black : Color.red;
    }
  }

  private void Awake() {
    this.Card = new Card(UnityEngine.Random.Range(0, 13), (CardSuit)UnityEngine.Random.Range(0, 3));
  }
}
